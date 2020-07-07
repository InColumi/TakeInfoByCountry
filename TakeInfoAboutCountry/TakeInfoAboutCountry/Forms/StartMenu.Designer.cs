namespace TakeInfoAboutCountry
{
    partial class StartMenu
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
            if(disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEnterNameCountry = new System.Windows.Forms.Button();
            this.buttonShowAllCountryFromDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 536);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Created by Panov";
            // 
            // buttonEnterNameCountry
            // 
            this.buttonEnterNameCountry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEnterNameCountry.AutoSize = true;
            this.buttonEnterNameCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonEnterNameCountry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEnterNameCountry.FlatAppearance.BorderSize = 0;
            this.buttonEnterNameCountry.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonEnterNameCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnterNameCountry.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnterNameCountry.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEnterNameCountry.Location = new System.Drawing.Point(149, 237);
            this.buttonEnterNameCountry.Name = "buttonEnterNameCountry";
            this.buttonEnterNameCountry.Size = new System.Drawing.Size(291, 42);
            this.buttonEnterNameCountry.TabIndex = 1;
            this.buttonEnterNameCountry.TabStop = false;
            this.buttonEnterNameCountry.Text = "Ввод названия страны";
            this.buttonEnterNameCountry.UseVisualStyleBackColor = false;
            this.buttonEnterNameCountry.Click += new System.EventHandler(this.ButtonEnterNameCountry_Click);
            // 
            // buttonShowAllCountryFromDB
            // 
            this.buttonShowAllCountryFromDB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowAllCountryFromDB.AutoSize = true;
            this.buttonShowAllCountryFromDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonShowAllCountryFromDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowAllCountryFromDB.FlatAppearance.BorderSize = 0;
            this.buttonShowAllCountryFromDB.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonShowAllCountryFromDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowAllCountryFromDB.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowAllCountryFromDB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonShowAllCountryFromDB.Location = new System.Drawing.Point(144, 288);
            this.buttonShowAllCountryFromDB.Name = "buttonShowAllCountryFromDB";
            this.buttonShowAllCountryFromDB.Size = new System.Drawing.Size(301, 42);
            this.buttonShowAllCountryFromDB.TabIndex = 1;
            this.buttonShowAllCountryFromDB.TabStop = false;
            this.buttonShowAllCountryFromDB.Text = "Вывод всех стран с БД";
            this.buttonShowAllCountryFromDB.UseVisualStyleBackColor = false;
            this.buttonShowAllCountryFromDB.Click += new System.EventHandler(this.ButtonShowAllCountryFromDB_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.buttonShowAllCountryFromDB);
            this.Controls.Add(this.buttonEnterNameCountry);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "StartMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приложение по получению информации о странах";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartMenu_FormClosing);
            this.Load += new System.EventHandler(this.StartMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEnterNameCountry;
        private System.Windows.Forms.Button buttonShowAllCountryFromDB;
    }
}

