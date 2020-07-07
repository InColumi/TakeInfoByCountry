namespace TakeInfoAboutCountry.Forms
{
    partial class ShowAllNameCountryMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowAllNameCountryMenu));
            this.dataGridViewShowInfo = new System.Windows.Forms.DataGridView();
            this.NameCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfCounty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapitalCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Population = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShowInfo
            // 
            this.dataGridViewShowInfo.AllowUserToAddRows = false;
            this.dataGridViewShowInfo.AllowUserToDeleteRows = false;
            this.dataGridViewShowInfo.AllowUserToOrderColumns = true;
            this.dataGridViewShowInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewShowInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewShowInfo.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewShowInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewShowInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewShowInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewShowInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameCountry,
            this.NumberOfCounty,
            this.CapitalCity,
            this.Area,
            this.Population,
            this.Region});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewShowInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewShowInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewShowInfo.GridColor = System.Drawing.Color.White;
            this.dataGridViewShowInfo.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewShowInfo.Name = "dataGridViewShowInfo";
            this.dataGridViewShowInfo.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewShowInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewShowInfo.Size = new System.Drawing.Size(884, 561);
            this.dataGridViewShowInfo.TabIndex = 3;
            // 
            // NameCountry
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            this.NameCountry.DefaultCellStyle = dataGridViewCellStyle2;
            this.NameCountry.HeaderText = "Название";
            this.NameCountry.Name = "NameCountry";
            this.NameCountry.ReadOnly = true;
            // 
            // NumberOfCounty
            // 
            this.NumberOfCounty.HeaderText = "Код страны";
            this.NumberOfCounty.Name = "NumberOfCounty";
            this.NumberOfCounty.ReadOnly = true;
            // 
            // CapitalCity
            // 
            this.CapitalCity.HeaderText = "Столица";
            this.CapitalCity.Name = "CapitalCity";
            this.CapitalCity.ReadOnly = true;
            // 
            // Area
            // 
            this.Area.HeaderText = "Площадь";
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            // 
            // Population
            // 
            this.Population.HeaderText = "Население";
            this.Population.Name = "Population";
            this.Population.ReadOnly = true;
            // 
            // Region
            // 
            this.Region.HeaderText = "Регион";
            this.Region.Name = "Region";
            this.Region.ReadOnly = true;
            // 
            // ShowAllNameCountryMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.dataGridViewShowInfo);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShowAllNameCountryMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Вывод всех стран с БД";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShowInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfCounty;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapitalCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Population;
        private System.Windows.Forms.DataGridViewTextBoxColumn Region;
    }
}