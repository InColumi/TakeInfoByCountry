namespace TakeInfoAboutCountry.Forms
{
    partial class EnterNameCountryMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterNameCountryMenu));
            this.textBoxInputNameCountry = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.textBoxCountryName = new System.Windows.Forms.TextBox();
            this.textBoxNumbeOfCountry = new System.Windows.Forms.TextBox();
            this.textBoxCapital = new System.Windows.Forms.TextBox();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.textBoxPopulation = new System.Windows.Forms.TextBox();
            this.textBoxRegion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAddToDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInputNameCountry
            // 
            this.textBoxInputNameCountry.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxInputNameCountry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInputNameCountry.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInputNameCountry.ForeColor = System.Drawing.Color.Silver;
            this.textBoxInputNameCountry.Location = new System.Drawing.Point(12, 12);
            this.textBoxInputNameCountry.Name = "textBoxInputNameCountry";
            this.textBoxInputNameCountry.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxInputNameCountry.Size = new System.Drawing.Size(463, 30);
            this.textBoxInputNameCountry.TabIndex = 0;
            this.textBoxInputNameCountry.Text = "Введите название страны";
            this.textBoxInputNameCountry.Click += new System.EventHandler(this.TextBoxInputNameCountry_Click);
            this.textBoxInputNameCountry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxInputNameCountry_KeyDown);
            this.textBoxInputNameCountry.Leave += new System.EventHandler(this.TextBoxInputNameCountry_Leave);
            // 
            // buttonFind
            // 
            this.buttonFind.FlatAppearance.BorderSize = 0;
            this.buttonFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFind.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFind.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonFind.Location = new System.Drawing.Point(481, 12);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(133, 30);
            this.buttonFind.TabIndex = 3;
            this.buttonFind.Text = "Найти";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.ButtonFind_Click);
            // 
            // textBoxCountryName
            // 
            this.textBoxCountryName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxCountryName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCountryName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCountryName.ForeColor = System.Drawing.Color.Black;
            this.textBoxCountryName.Location = new System.Drawing.Point(171, 52);
            this.textBoxCountryName.Name = "textBoxCountryName";
            this.textBoxCountryName.ReadOnly = true;
            this.textBoxCountryName.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxCountryName.Size = new System.Drawing.Size(443, 30);
            this.textBoxCountryName.TabIndex = 0;
            this.textBoxCountryName.TabStop = false;
            // 
            // textBoxNumbeOfCountry
            // 
            this.textBoxNumbeOfCountry.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxNumbeOfCountry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumbeOfCountry.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumbeOfCountry.ForeColor = System.Drawing.Color.Black;
            this.textBoxNumbeOfCountry.Location = new System.Drawing.Point(171, 88);
            this.textBoxNumbeOfCountry.Name = "textBoxNumbeOfCountry";
            this.textBoxNumbeOfCountry.ReadOnly = true;
            this.textBoxNumbeOfCountry.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxNumbeOfCountry.Size = new System.Drawing.Size(443, 30);
            this.textBoxNumbeOfCountry.TabIndex = 0;
            this.textBoxNumbeOfCountry.TabStop = false;
            // 
            // textBoxCapital
            // 
            this.textBoxCapital.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxCapital.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCapital.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCapital.ForeColor = System.Drawing.Color.Black;
            this.textBoxCapital.Location = new System.Drawing.Point(171, 124);
            this.textBoxCapital.Name = "textBoxCapital";
            this.textBoxCapital.ReadOnly = true;
            this.textBoxCapital.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxCapital.Size = new System.Drawing.Size(443, 30);
            this.textBoxCapital.TabIndex = 0;
            this.textBoxCapital.TabStop = false;
            // 
            // textBoxArea
            // 
            this.textBoxArea.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxArea.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxArea.ForeColor = System.Drawing.Color.Black;
            this.textBoxArea.Location = new System.Drawing.Point(171, 160);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.ReadOnly = true;
            this.textBoxArea.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxArea.Size = new System.Drawing.Size(443, 30);
            this.textBoxArea.TabIndex = 0;
            this.textBoxArea.TabStop = false;
            // 
            // textBoxPopulation
            // 
            this.textBoxPopulation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxPopulation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPopulation.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPopulation.ForeColor = System.Drawing.Color.Black;
            this.textBoxPopulation.Location = new System.Drawing.Point(171, 196);
            this.textBoxPopulation.Name = "textBoxPopulation";
            this.textBoxPopulation.ReadOnly = true;
            this.textBoxPopulation.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPopulation.Size = new System.Drawing.Size(443, 30);
            this.textBoxPopulation.TabIndex = 0;
            this.textBoxPopulation.TabStop = false;
            // 
            // textBoxRegion
            // 
            this.textBoxRegion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxRegion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRegion.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRegion.ForeColor = System.Drawing.Color.Black;
            this.textBoxRegion.Location = new System.Drawing.Point(171, 232);
            this.textBoxRegion.Name = "textBoxRegion";
            this.textBoxRegion.ReadOnly = true;
            this.textBoxRegion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxRegion.Size = new System.Drawing.Size(443, 30);
            this.textBoxRegion.TabIndex = 0;
            this.textBoxRegion.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Код страны:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Столица:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Площадь:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Население:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 30);
            this.label6.TabIndex = 4;
            this.label6.Text = "Регион:";
            // 
            // buttonAddToDB
            // 
            this.buttonAddToDB.AutoSize = true;
            this.buttonAddToDB.FlatAppearance.BorderSize = 0;
            this.buttonAddToDB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonAddToDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddToDB.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddToDB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddToDB.Location = new System.Drawing.Point(445, 268);
            this.buttonAddToDB.Name = "buttonAddToDB";
            this.buttonAddToDB.Size = new System.Drawing.Size(169, 34);
            this.buttonAddToDB.TabIndex = 5;
            this.buttonAddToDB.Text = "Добавить в БД";
            this.buttonAddToDB.UseVisualStyleBackColor = true;
            this.buttonAddToDB.Click += new System.EventHandler(this.ButtonAddToDB_Click);
            // 
            // EnterNameCountryMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(82)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(622, 312);
            this.Controls.Add(this.buttonAddToDB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.textBoxRegion);
            this.Controls.Add(this.textBoxPopulation);
            this.Controls.Add(this.textBoxCapital);
            this.Controls.Add(this.textBoxArea);
            this.Controls.Add(this.textBoxNumbeOfCountry);
            this.Controls.Add(this.textBoxCountryName);
            this.Controls.Add(this.textBoxInputNameCountry);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "EnterNameCountryMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Поиск страны по названию";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInputNameCountry;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.TextBox textBoxCountryName;
        private System.Windows.Forms.TextBox textBoxNumbeOfCountry;
        private System.Windows.Forms.TextBox textBoxCapital;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.TextBox textBoxPopulation;
        private System.Windows.Forms.TextBox textBoxRegion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAddToDB;
    }
}