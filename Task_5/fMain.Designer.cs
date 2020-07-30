namespace Task_5
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelGraphic = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnChangeSize = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.btnDisable = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTask = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panelGraphic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panelGraphic);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(986, 594);
            this.panel3.TabIndex = 2;
            // 
            // panelGraphic
            // 
            this.panelGraphic.AutoScroll = true;
            this.panelGraphic.BackColor = System.Drawing.Color.White;
            this.panelGraphic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGraphic.Controls.Add(this.pictureBox);
            this.panelGraphic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraphic.Location = new System.Drawing.Point(0, 0);
            this.panelGraphic.Name = "panelGraphic";
            this.panelGraphic.Size = new System.Drawing.Size(986, 594);
            this.panelGraphic.TabIndex = 2;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(8, 8);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(500, 500);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnDisable);
            this.panel10.Controls.Add(this.numHeight);
            this.panel10.Controls.Add(this.label1);
            this.panel10.Controls.Add(this.btnGenerate);
            this.panel10.Controls.Add(this.numWidth);
            this.panel10.Controls.Add(this.btnEnable);
            this.panel10.Controls.Add(this.btnChangeSize);
            this.panel10.Controls.Add(this.label6);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(417, 0);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(5);
            this.panel10.Size = new System.Drawing.Size(569, 93);
            this.panel10.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ширина";
            // 
            // btnChangeSize
            // 
            this.btnChangeSize.Location = new System.Drawing.Point(164, 5);
            this.btnChangeSize.Name = "btnChangeSize";
            this.btnChangeSize.Size = new System.Drawing.Size(93, 82);
            this.btnChangeSize.TabIndex = 4;
            this.btnChangeSize.Text = "Изменить размер";
            this.btnChangeSize.UseVisualStyleBackColor = true;
            this.btnChangeSize.Click += new System.EventHandler(this.btnChangeSize_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(364, 5);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(91, 82);
            this.btnEnable.TabIndex = 5;
            this.btnEnable.Text = "Включить светофор";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // numWidth
            // 
            this.numWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numWidth.Location = new System.Drawing.Point(8, 41);
            this.numWidth.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numWidth.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(71, 30);
            this.numWidth.TabIndex = 9;
            this.numWidth.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(264, 5);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(94, 82);
            this.btnGenerate.TabIndex = 10;
            this.btnGenerate.Text = "Генери- ровать стены";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Высота";
            // 
            // numHeight
            // 
            this.numHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numHeight.Location = new System.Drawing.Point(85, 41);
            this.numHeight.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numHeight.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(73, 30);
            this.numHeight.TabIndex = 12;
            this.numHeight.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // btnDisable
            // 
            this.btnDisable.Enabled = false;
            this.btnDisable.Location = new System.Drawing.Point(461, 5);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(96, 82);
            this.btnDisable.TabIndex = 13;
            this.btnDisable.Text = "Выключить светофор";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel4);
            this.panel9.Controls.Add(this.panel1);
            this.panel9.Controls.Add(this.lblTask);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(417, 93);
            this.panel9.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panelGreen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(417, 29);
            this.panel1.TabIndex = 9;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Black;
            this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreen.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGreen.Location = new System.Drawing.Point(5, 5);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(20, 19);
            this.panelGreen.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(25, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Правой кнопкой мыши поставь светофор";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.panelBlue);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 56);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(417, 29);
            this.panel4.TabIndex = 10;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Silver;
            this.panelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlue.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBlue.Location = new System.Drawing.Point(5, 5);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(20, 19);
            this.panelBlue.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(25, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Левой кнопкой мыши поставь/убери стенку";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.panel9);
            this.panelTop.Controls.Add(this.panel10);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(986, 93);
            this.panelTop.TabIndex = 5;
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTask.Location = new System.Drawing.Point(0, 0);
            this.lblTask.Margin = new System.Windows.Forms.Padding(5);
            this.lblTask.Name = "lblTask";
            this.lblTask.Padding = new System.Windows.Forms.Padding(5);
            this.lblTask.Size = new System.Drawing.Size(385, 27);
            this.lblTask.TabIndex = 11;
            this.lblTask.Text = "Построение лучей светофора в зеркальном лабиринте";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 687);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelTop);
            this.MinimumSize = new System.Drawing.Size(900, 530);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задача 5";
            this.panel3.ResumeLayout(false);
            this.panelGraphic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelGraphic;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnChangeSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Panel panelTop;
    }
}

