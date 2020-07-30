using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4
{
    class HelperDB
    {
        public const string DBFileName = "db.sqlite";
        public const string DatabaseSource = "data source=" + DBFileName;

        internal static void CheckDatabaseExists()
        {
            //Создаем базу данных и таблицы, если их ещё не было
            //SQLite не поддерживает автоматическое создание при работе через ORM
            if (!File.Exists(DBFileName))
            {
                SQLiteConnection.CreateFile(DBFileName);

                // Connect to the database 
                using (var connection = new SQLiteConnection(DatabaseSource))
                // Create a database command
                using (var command = new SQLiteCommand(connection))
                {
                    connection.Open();

                    // Create the table
                    command.CommandText = @"CREATE TABLE IF NOT EXISTS [Mazes](
                            [ID]    INTEGER NOT NULL UNIQUE,
                            [NAME]  TEXT NOT NULL,
                            [DT]    TEXT NOT NULL,
                            [SIZE]  INTEGER NOT NULL DEFAULT 8,
                            PRIMARY KEY([ID] AUTOINCREMENT)
                        );
                        CREATE TABLE IF NOT EXISTS [Cells](
                            [ID]    INTEGER NOT NULL,
                            [IDMAZE]    INTEGER NOT NULL,
                            [X] INTEGER NOT NULL,
                            [Y] INTEGER NOT NULL,
                            [VALUE] INTEGER NOT NULL,
                            PRIMARY KEY([ID] AUTOINCREMENT),
                            FOREIGN KEY([IDMAZE]) REFERENCES [Mazes]([ID])
                        );";
                    command.ExecuteNonQuery();
                }
            }
        }

        internal static void LoadNames(DataGridView dgv)
        {
            using (var connection = new SQLiteConnection(DatabaseSource))
            using (var command = new SQLiteCommand(connection))
            {
                connection.Open();

                command.CommandText = "Select [ID], [NAME], [DT], [SIZE] FROM [Mazes]";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        dgv.Rows.Add(new object[] {
                            reader.GetInt16(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetInt16(3)
                        });
                }

                connection.Close(); // Close the connection to the database
            }
        }

        internal static void LoadMazeFromDB(int id, int size)
        {
            using (var connection = new SQLiteConnection(DatabaseSource))
            using (var command = new SQLiteCommand(connection))            
            {
                connection.Open();

                command.CommandText = "Select [X], [Y], [VALUE] FROM [Cells] WHERE [IDMAZE]="+id.ToString();

                MazeData maze = new MazeData(size);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        maze.cellsList.Add(new cellStruct(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2)));
                }

                connection.Close(); // Close the connection to the database

                Helper.SetFieldData(maze);                
            }
        }

        internal static void SaveMazeToDB(MazeData maze, string name, string dt)
        {
            using (var connection = new SQLiteConnection(DatabaseSource))
            using (var command = new SQLiteCommand(connection))
            {
                connection.Open();

                //сохраняем имя таблицы
                command.CommandText = $"INSERT INTO [Mazes]([NAME], [DT], [SIZE]) "+
                    $"VALUES(\"{name}\", \"{dt}\", {maze.fieldSize});";
                command.ExecuteNonQuery();

                //считываем номер записанной таблицы
                int id = 0;
                command.CommandText = "SELECT MAX(ID) FROM [Mazes];";
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                        id = reader.GetInt32(0);
                }

                using (var transaction = connection.BeginTransaction())
                {
                    //вставляем в цикле (?) ячейки из списка 
                    string insertCmd = "INSERT INTO [Cells] (IDMAZE, X, Y, VALUE) VALUES(?, ?, ?, ?)";
                    foreach (var cell in maze.cellsList)
                    {
                        using (var cmd = new SQLiteCommand(insertCmd, connection))
                        {
                            cmd.Parameters.AddWithValue("@IDMAZE", id);
                            cmd.Parameters.AddWithValue("@X", cell.x);
                            cmd.Parameters.AddWithValue("@Y", cell.y);
                            cmd.Parameters.AddWithValue("@VALUE", cell.value);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    transaction.Commit();
                }

                connection.Close(); // Close the connection to the database
            }
        }
    }
}
