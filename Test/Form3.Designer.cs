namespace Test
{
    partial class AdminWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminWin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйПользовательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйПользовательToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйЗаказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйКлиентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BDGridView = new System.Windows.Forms.DataGridView();
            this.SaveBut = new System.Windows.Forms.Button();
            this.Privet = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ReportZone = new System.Windows.Forms.Panel();
            this.Report = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BDGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ReportZone.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SandyBrown;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.новыйПользовательToolStripMenuItem,
            this.отчетностьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.menuStrip1.Size = new System.Drawing.Size(646, 58);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(85, 28);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // новыйПользовательToolStripMenuItem
            // 
            this.новыйПользовательToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйПользовательToolStripMenuItem1,
            this.новыйЗаказToolStripMenuItem,
            this.новыйКлиентToolStripMenuItem,
            this.услугиToolStripMenuItem});
            this.новыйПользовательToolStripMenuItem.Name = "новыйПользовательToolStripMenuItem";
            this.новыйПользовательToolStripMenuItem.Size = new System.Drawing.Size(156, 28);
            this.новыйПользовательToolStripMenuItem.Text = "Редакция БД";
            // 
            // новыйПользовательToolStripMenuItem1
            // 
            this.новыйПользовательToolStripMenuItem1.Name = "новыйПользовательToolStripMenuItem1";
            this.новыйПользовательToolStripMenuItem1.Size = new System.Drawing.Size(224, 28);
            this.новыйПользовательToolStripMenuItem1.Text = "Пользователи";
            this.новыйПользовательToolStripMenuItem1.Click += new System.EventHandler(this.UsersMenuItem_Click);
            // 
            // новыйЗаказToolStripMenuItem
            // 
            this.новыйЗаказToolStripMenuItem.Name = "новыйЗаказToolStripMenuItem";
            this.новыйЗаказToolStripMenuItem.Size = new System.Drawing.Size(263, 28);
            this.новыйЗаказToolStripMenuItem.Text = "Номерной фонд";
            this.новыйЗаказToolStripMenuItem.Click += new System.EventHandler(this.NumberMenuItem_Click);
            // 
            // новыйКлиентToolStripMenuItem
            // 
            this.новыйКлиентToolStripMenuItem.Name = "новыйКлиентToolStripMenuItem";
            this.новыйКлиентToolStripMenuItem.Size = new System.Drawing.Size(263, 28);
            this.новыйКлиентToolStripMenuItem.Text = "Статус номера";
            this.новыйКлиентToolStripMenuItem.Click += new System.EventHandler(this.StatusMenuItem_Click);
            // 
            // услугиToolStripMenuItem
            // 
            this.услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
            this.услугиToolStripMenuItem.Size = new System.Drawing.Size(263, 28);
            this.услугиToolStripMenuItem.Text = "Постояльцы";
            this.услугиToolStripMenuItem.Click += new System.EventHandler(this.ClientMenuItem_Click);
            // 
            // отчетностьToolStripMenuItem
            // 
            this.отчетностьToolStripMenuItem.Name = "отчетностьToolStripMenuItem";
            this.отчетностьToolStripMenuItem.Size = new System.Drawing.Size(139, 28);
            this.отчетностьToolStripMenuItem.Text = "Отчетность";
            this.отчетностьToolStripMenuItem.Click += new System.EventHandler(this.ReportMenuItem_Click);
            // 
            // BDGridView
            // 
            this.BDGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BDGridView.Location = new System.Drawing.Point(12, 97);
            this.BDGridView.Name = "BDGridView";
            this.BDGridView.Size = new System.Drawing.Size(622, 362);
            this.BDGridView.TabIndex = 2;
            this.BDGridView.Visible = false;
            // 
            // SaveBut
            // 
            this.SaveBut.AutoSize = true;
            this.SaveBut.BackColor = System.Drawing.Color.SandyBrown;
            this.SaveBut.FlatAppearance.BorderSize = 0;
            this.SaveBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SaveBut.Location = new System.Drawing.Point(34, 495);
            this.SaveBut.Name = "SaveBut";
            this.SaveBut.Size = new System.Drawing.Size(199, 49);
            this.SaveBut.TabIndex = 3;
            this.SaveBut.Text = "Cохранить изменения";
            this.SaveBut.UseVisualStyleBackColor = false;
            this.SaveBut.Visible = false;
            this.SaveBut.Click += new System.EventHandler(this.SaveBut_Click);
            // 
            // Privet
            // 
            this.Privet.AutoSize = true;
            this.Privet.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Privet.Location = new System.Drawing.Point(29, 133);
            this.Privet.Name = "Privet";
            this.Privet.Size = new System.Drawing.Size(590, 60);
            this.Privet.TabIndex = 4;
            this.Privet.Text = "Добро пожаловать в систему, Администратор!\r\n                     Удачной вам рабо" +
    "ты!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(125, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 243);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // ReportZone
            // 
            this.ReportZone.AutoScroll = true;
            this.ReportZone.Controls.Add(this.Report);
            this.ReportZone.Location = new System.Drawing.Point(12, 78);
            this.ReportZone.Name = "ReportZone";
            this.ReportZone.Size = new System.Drawing.Size(622, 411);
            this.ReportZone.TabIndex = 8;
            this.ReportZone.Visible = false;
            // 
            // Report
            // 
            this.Report.AutoSize = true;
            this.Report.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Report.Location = new System.Drawing.Point(3, 3);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(787, 483);
            this.Report.TabIndex = 0;
            this.Report.Text = resources.GetString("Report.Text");
            // 
            // AdminWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 580);
            this.Controls.Add(this.ReportZone);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Privet);
            this.Controls.Add(this.SaveBut);
            this.Controls.Add(this.BDGridView);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminWin_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BDGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ReportZone.ResumeLayout(false);
            this.ReportZone.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйПользовательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйПользовательToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem новыйЗаказToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйКлиентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem;
        private System.Windows.Forms.DataGridView BDGridView;
        private System.Windows.Forms.Button SaveBut;
        private System.Windows.Forms.Label Privet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel ReportZone;
        private System.Windows.Forms.Label Report;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}