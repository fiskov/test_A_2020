namespace Task_3
{
    partial class Form1
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
            this.lblTask = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelGraphic = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.chkShowSteps = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnChangeSize = new System.Windows.Forms.Button();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3.SuspendLayout();
            this.panelGraphic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTask.Location = new System.Drawing.Point(0, 0);
            this.lblTask.Margin = new System.Windows.Forms.Padding(5);
            this.lblTask.Name = "lblTask";
            this.lblTask.Padding = new System.Windows.Forms.Padding(5);
            this.lblTask.Size = new System.Drawing.Size(772, 27);
            this.lblTask.TabIndex = 1;
            this.lblTask.Text = "Определение минимального количества ходов конём из одной клетки в другую с выреза" +
    "нными клетками на поле";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panelGraphic);
            this.panel3.Controls.Add(this.panelLeft);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(909, 567);
            this.panel3.TabIndex = 2;
            // 
            // panelGraphic
            // 
            this.panelGraphic.BackColor = System.Drawing.Color.White;
            this.panelGraphic.Controls.Add(this.pictureBox);
            this.panelGraphic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraphic.Location = new System.Drawing.Point(0, 0);
            this.panelGraphic.Name = "panelGraphic";
            this.panelGraphic.Size = new System.Drawing.Size(713, 567);
            this.panelGraphic.TabIndex = 2;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(713, 567);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.txtLog);
            this.panelLeft.Controls.Add(this.label4);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLeft.Location = new System.Drawing.Point(713, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(5);
            this.panelLeft.Size = new System.Drawing.Size(196, 567);
            this.panelLeft.TabIndex = 1;
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.Window;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(5, 26);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(186, 536);
            this.txtLog.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(5, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Результаты : ";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.panel9);
            this.panelTop.Controls.Add(this.panel10);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 27);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(909, 93);
            this.panelTop.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel4);
            this.panel9.Controls.Add(this.panel1);
            this.panel9.Controls.Add(this.panel5);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(539, 93);
            this.panel9.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.panelBlue);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 58);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(539, 29);
            this.panel4.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(25, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Левой кнопкой мыши выбери конечную клетку";
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.SteelBlue;
            this.panelBlue.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBlue.Location = new System.Drawing.Point(5, 5);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(20, 19);
            this.panelBlue.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panelGreen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(539, 29);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(25, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Правой кнопкой мыши выбери начальную клетку";
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Lime;
            this.panelGreen.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGreen.Location = new System.Drawing.Point(5, 5);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(20, 19);
            this.panelGreen.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.panelRed);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5);
            this.panel5.Size = new System.Drawing.Size(539, 29);
            this.panel5.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(25, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(452, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Средней кнопкой мыши (колесиком) выбери непроходимые клетки";
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Crimson;
            this.panelRed.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRed.Location = new System.Drawing.Point(5, 5);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(20, 19);
            this.panelRed.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.chkShowSteps);
            this.panel10.Controls.Add(this.btnSearch);
            this.panel10.Controls.Add(this.btnChangeSize);
            this.panel10.Controls.Add(this.cbSize);
            this.panel10.Controls.Add(this.label6);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(539, 0);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(5);
            this.panel10.Size = new System.Drawing.Size(370, 93);
            this.panel10.TabIndex = 10;
            // 
            // chkShowSteps
            // 
            this.chkShowSteps.AutoSize = true;
            this.chkShowSteps.Location = new System.Drawing.Point(6, 56);
            this.chkShowSteps.Name = "chkShowSteps";
            this.chkShowSteps.Size = new System.Drawing.Size(186, 21);
            this.chkShowSteps.TabIndex = 6;
            this.chkShowSteps.Text = "Показать номера ходов";
            this.chkShowSteps.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(213, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(145, 40);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Найти путь";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnChangeSize
            // 
            this.btnChangeSize.Location = new System.Drawing.Point(213, 0);
            this.btnChangeSize.Name = "btnChangeSize";
            this.btnChangeSize.Size = new System.Drawing.Size(145, 40);
            this.btnChangeSize.TabIndex = 4;
            this.btnChangeSize.Text = "Изменить размер";
            this.toolTip1.SetToolTip(this.btnChangeSize, "Изменение размеров поля приведет \r\nк сбросу значения клеток");
            this.btnChangeSize.UseVisualStyleBackColor = true;
            this.btnChangeSize.Click += new System.EventHandler(this.btnChangeSize_Click);
            // 
            // cbSize
            // 
            this.cbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "3 x 3",
            "4 x 4",
            "5 x 5",
            "6 x 6",
            "7 x 7",
            "8 x 8",
            "9 x 9",
            "10 x 10",
            "11 x 11",
            "12 x 12",
            "13 x 13",
            "14 x 14",
            "15 x 15",
            "16 x 16",
            "17 x 17",
            "18 x 18",
            "19 x 19",
            "20 x 20"});
            this.cbSize.Location = new System.Drawing.Point(112, 9);
            this.cbSize.MaxDropDownItems = 10;
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(77, 24);
            this.cbSize.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Размер поля :";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Внимание";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 687);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.lblTask);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(900, 730);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задача 3";
            this.panel3.ResumeLayout(false);
            this.panelGraphic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnChangeSize;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panelGraphic;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.CheckBox chkShowSteps;
    }
}

