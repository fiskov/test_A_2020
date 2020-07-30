namespace Task_6
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblTower = new System.Windows.Forms.Label();
            this.btnCreateTower = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numPower = new System.Windows.Forms.NumericUpDown();
            this.btnClearTowerList = new System.Windows.Forms.Button();
            this.btnAddTower = new System.Windows.Forms.Button();
            this.btnClearTower = new System.Windows.Forms.Button();
            this.btnAddPower = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTowers = new System.Windows.Forms.ListBox();
            this.lbTowersSort = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPower)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(841, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Приложение сортировки массива башен степеней по возрастанию";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnSave);
            this.panelTop.Controls.Add(this.btnLoad);
            this.panelTop.Controls.Add(this.lblTower);
            this.panelTop.Controls.Add(this.btnCreateTower);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Controls.Add(this.numPower);
            this.panelTop.Controls.Add(this.btnClearTowerList);
            this.panelTop.Controls.Add(this.btnAddTower);
            this.panelTop.Controls.Add(this.btnClearTower);
            this.panelTop.Controls.Add(this.btnAddPower);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(3, 20);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(841, 146);
            this.panelTop.TabIndex = 1;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(451, 99);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(183, 37);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "Загрузить из файла...";
            this.toolTip1.SetToolTip(this.btnLoad, "В каждой строке идут числа разделенные пробелом");
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblTower
            // 
            this.lblTower.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTower.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTower.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTower.Location = new System.Drawing.Point(9, 49);
            this.lblTower.Name = "lblTower";
            this.lblTower.Size = new System.Drawing.Size(825, 44);
            this.lblTower.TabIndex = 9;
            // 
            // btnCreateTower
            // 
            this.btnCreateTower.Location = new System.Drawing.Point(528, 5);
            this.btnCreateTower.Name = "btnCreateTower";
            this.btnCreateTower.Size = new System.Drawing.Size(148, 37);
            this.btnCreateTower.TabIndex = 8;
            this.btnCreateTower.Text = "Случайная башня";
            this.btnCreateTower.UseVisualStyleBackColor = true;
            this.btnCreateTower.Click += new System.EventHandler(this.btnCreateTower_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Новая степень";
            // 
            // numPower
            // 
            this.numPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numPower.Location = new System.Drawing.Point(121, 10);
            this.numPower.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numPower.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPower.Name = "numPower";
            this.numPower.Size = new System.Drawing.Size(79, 30);
            this.numPower.TabIndex = 4;
            this.numPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPower.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btnClearTowerList
            // 
            this.btnClearTowerList.Location = new System.Drawing.Point(236, 99);
            this.btnClearTowerList.Name = "btnClearTowerList";
            this.btnClearTowerList.Size = new System.Drawing.Size(209, 37);
            this.btnClearTowerList.TabIndex = 3;
            this.btnClearTowerList.Text = "Очистить массив башен";
            this.btnClearTowerList.UseVisualStyleBackColor = true;
            this.btnClearTowerList.Click += new System.EventHandler(this.btnClearTowerList_Click);
            // 
            // btnAddTower
            // 
            this.btnAddTower.Location = new System.Drawing.Point(12, 99);
            this.btnAddTower.Name = "btnAddTower";
            this.btnAddTower.Size = new System.Drawing.Size(218, 37);
            this.btnAddTower.TabIndex = 2;
            this.btnAddTower.Text = "Добавить башню в массив";
            this.btnAddTower.UseVisualStyleBackColor = true;
            this.btnAddTower.Click += new System.EventHandler(this.btnAddTower_Click);
            // 
            // btnClearTower
            // 
            this.btnClearTower.Location = new System.Drawing.Point(373, 5);
            this.btnClearTower.Name = "btnClearTower";
            this.btnClearTower.Size = new System.Drawing.Size(148, 37);
            this.btnClearTower.TabIndex = 1;
            this.btnClearTower.Text = "Очистить башню";
            this.btnClearTower.UseVisualStyleBackColor = true;
            this.btnClearTower.Click += new System.EventHandler(this.btnClearTower_Click);
            // 
            // btnAddPower
            // 
            this.btnAddPower.Location = new System.Drawing.Point(219, 5);
            this.btnAddPower.Name = "btnAddPower";
            this.btnAddPower.Size = new System.Drawing.Size(148, 37);
            this.btnAddPower.TabIndex = 0;
            this.btnAddPower.Text = "Добавить степень";
            this.btnAddPower.UseVisualStyleBackColor = true;
            this.btnAddPower.Click += new System.EventHandler(this.btnAddPower_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbTowers, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbTowersSort, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 166);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(841, 281);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Не сортированный массив башен степеней";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTowers
            // 
            this.lbTowers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTowers.FormattingEnabled = true;
            this.lbTowers.ItemHeight = 16;
            this.lbTowers.Location = new System.Drawing.Point(6, 26);
            this.lbTowers.Name = "lbTowers";
            this.lbTowers.Size = new System.Drawing.Size(411, 249);
            this.lbTowers.TabIndex = 1;
            // 
            // lbTowersSort
            // 
            this.lbTowersSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTowersSort.FormattingEnabled = true;
            this.lbTowersSort.ItemHeight = 16;
            this.lbTowersSort.Location = new System.Drawing.Point(423, 26);
            this.lbTowersSort.Name = "lbTowersSort";
            this.lbTowersSort.Size = new System.Drawing.Size(412, 249);
            this.lbTowersSort.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Сортированный массив башен степеней";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Формат файла";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(640, 99);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(176, 37);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Сохранить в файл...";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задача 6";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPower)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateTower;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numPower;
        private System.Windows.Forms.Button btnClearTowerList;
        private System.Windows.Forms.Button btnAddTower;
        private System.Windows.Forms.Button btnClearTower;
        private System.Windows.Forms.Button btnAddPower;
        private System.Windows.Forms.ListBox lbTowers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbTowersSort;
        private System.Windows.Forms.Label lblTower;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSave;
    }
}

