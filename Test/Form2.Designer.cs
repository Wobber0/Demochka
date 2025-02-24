namespace Test
{
    partial class UserWin
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserWin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.моиЗадачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информационнаяПанельToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserGridView = new System.Windows.Forms.DataGridView();
            this.info = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Privet = new System.Windows.Forms.Label();
            this.SaveBut = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SandyBrown;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.моиЗадачиToolStripMenuItem,
            this.информационнаяПанельToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.menuStrip1.Size = new System.Drawing.Size(646, 58);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // моиЗадачиToolStripMenuItem
            // 
            this.моиЗадачиToolStripMenuItem.Name = "моиЗадачиToolStripMenuItem";
            this.моиЗадачиToolStripMenuItem.Size = new System.Drawing.Size(147, 28);
            this.моиЗадачиToolStripMenuItem.Text = "Мои задачи";
            this.моиЗадачиToolStripMenuItem.Click += new System.EventHandler(this.MyTasksMenuItem_Click);
            // 
            // информационнаяПанельToolStripMenuItem
            // 
            this.информационнаяПанельToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.информационнаяПанельToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.информационнаяПанельToolStripMenuItem.Name = "информационнаяПанельToolStripMenuItem";
            this.информационнаяПанельToolStripMenuItem.Size = new System.Drawing.Size(170, 28);
            this.информационнаяПанельToolStripMenuItem.Text = "Информация";
            this.информационнаяПанельToolStripMenuItem.Click += new System.EventHandler(this.InfoMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(85, 28);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // UserGridView
            // 
            this.UserGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserGridView.Location = new System.Drawing.Point(40, 91);
            this.UserGridView.Name = "UserGridView";
            this.UserGridView.Size = new System.Drawing.Size(571, 316);
            this.UserGridView.TabIndex = 1;
            this.UserGridView.Visible = false;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info.Location = new System.Drawing.Point(3, 0);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(0, 22);
            this.info.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Privet);
            this.panel1.Controls.Add(this.info);
            this.panel1.Location = new System.Drawing.Point(12, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 450);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(119, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 243);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Privet
            // 
            this.Privet.AutoSize = true;
            this.Privet.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Privet.Location = new System.Drawing.Point(105, 38);
            this.Privet.Name = "Privet";
            this.Privet.Size = new System.Drawing.Size(381, 60);
            this.Privet.TabIndex = 5;
            this.Privet.Text = "Добро пожаловать в систему!\r\n       Удачной вам работы!";
            // 
            // SaveBut
            // 
            this.SaveBut.AutoSize = true;
            this.SaveBut.BackColor = System.Drawing.Color.SandyBrown;
            this.SaveBut.FlatAppearance.BorderSize = 0;
            this.SaveBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SaveBut.Location = new System.Drawing.Point(12, 506);
            this.SaveBut.Name = "SaveBut";
            this.SaveBut.Size = new System.Drawing.Size(199, 49);
            this.SaveBut.TabIndex = 7;
            this.SaveBut.Text = "Cохранить изменения";
            this.SaveBut.UseVisualStyleBackColor = false;
            this.SaveBut.Visible = false;
            // 
            // UserWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(646, 584);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UserGridView);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.SaveBut);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem информационнаяПанельToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.DataGridView UserGridView;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem моиЗадачиToolStripMenuItem;
        private System.Windows.Forms.Label Privet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SaveBut;
    }
}