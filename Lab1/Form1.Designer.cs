namespace Lab1
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
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewService = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.Report1YearInput = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewReport1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Report2CategorySelect = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewReport2 = new System.Windows.Forms.DataGridView();
            this.ServiceIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceClassCostCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceCategoryCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatronymicCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BirthdateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Report1YearInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCol,
            this.SurnameCol,
            this.NameCol,
            this.PatronymicCol,
            this.GenderCol,
            this.BirthdateCol});
            this.dataGridViewClients.Location = new System.Drawing.Point(4, 52);
            this.dataGridViewClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewClients.MultiSelect = false;
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.RowHeadersWidth = 82;
            this.dataGridViewClients.RowTemplate.Height = 33;
            this.dataGridViewClients.Size = new System.Drawing.Size(792, 458);
            this.dataGridViewClients.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(810, 542);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewService);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(802, 513);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Services";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewService
            // 
            this.dataGridViewService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceIdCol,
            this.ServiceNameCol,
            this.ServiceClassCostCol,
            this.ServiceCategoryCol});
            this.dataGridViewService.Location = new System.Drawing.Point(4, 50);
            this.dataGridViewService.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewService.Name = "dataGridViewService";
            this.dataGridViewService.RowHeadersWidth = 82;
            this.dataGridViewService.RowTemplate.Height = 33;
            this.dataGridViewService.Size = new System.Drawing.Size(792, 460);
            this.dataGridViewService.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 42);
            this.button2.TabIndex = 0;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridViewClients);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(802, 513);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clients";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.Report1YearInput);
            this.tabPage3.Controls.Add(this.dataGridViewReport1);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Size = new System.Drawing.Size(802, 513);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Report 1";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Clients by birth year";
            // 
            // Report1YearInput
            // 
            this.Report1YearInput.Location = new System.Drawing.Point(171, 21);
            this.Report1YearInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Report1YearInput.Maximum = new decimal(new int[] {
            2999,
            0,
            0,
            0});
            this.Report1YearInput.Name = "Report1YearInput";
            this.Report1YearInput.Size = new System.Drawing.Size(132, 22);
            this.Report1YearInput.TabIndex = 3;
            // 
            // dataGridViewReport1
            // 
            this.dataGridViewReport1.AllowUserToAddRows = false;
            this.dataGridViewReport1.AllowUserToDeleteRows = false;
            this.dataGridViewReport1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport1.Location = new System.Drawing.Point(4, 61);
            this.dataGridViewReport1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewReport1.Name = "dataGridViewReport1";
            this.dataGridViewReport1.ReadOnly = true;
            this.dataGridViewReport1.RowHeadersWidth = 82;
            this.dataGridViewReport1.RowTemplate.Height = 33;
            this.dataGridViewReport1.Size = new System.Drawing.Size(792, 449);
            this.dataGridViewReport1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(348, 13);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 34);
            this.button3.TabIndex = 0;
            this.button3.Text = "Find";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.Report2CategorySelect);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.dataGridViewReport2);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(802, 513);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Report 2";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Report2CategorySelect
            // 
            this.Report2CategorySelect.FormattingEnabled = true;
            this.Report2CategorySelect.Location = new System.Drawing.Point(175, 20);
            this.Report2CategorySelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Report2CategorySelect.Name = "Report2CategorySelect";
            this.Report2CategorySelect.Size = new System.Drawing.Size(139, 24);
            this.Report2CategorySelect.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(373, 12);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 35);
            this.button4.TabIndex = 2;
            this.button4.Text = "Find";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Services by category";
            // 
            // dataGridViewReport2
            // 
            this.dataGridViewReport2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport2.Location = new System.Drawing.Point(5, 57);
            this.dataGridViewReport2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewReport2.Name = "dataGridViewReport2";
            this.dataGridViewReport2.RowHeadersWidth = 82;
            this.dataGridViewReport2.RowTemplate.Height = 33;
            this.dataGridViewReport2.Size = new System.Drawing.Size(792, 454);
            this.dataGridViewReport2.TabIndex = 0;
            // 
            // ServiceIdCol
            // 
            this.ServiceIdCol.DataPropertyName = "id";
            this.ServiceIdCol.HeaderText = "ID";
            this.ServiceIdCol.MinimumWidth = 10;
            this.ServiceIdCol.Name = "ServiceIdCol";
            this.ServiceIdCol.ReadOnly = true;
            this.ServiceIdCol.Width = 50;
            // 
            // ServiceNameCol
            // 
            this.ServiceNameCol.DataPropertyName = "name";
            this.ServiceNameCol.HeaderText = "Имя";
            this.ServiceNameCol.MinimumWidth = 10;
            this.ServiceNameCol.Name = "ServiceNameCol";
            this.ServiceNameCol.Width = 200;
            // 
            // ServiceClassCostCol
            // 
            this.ServiceClassCostCol.DataPropertyName = "class_cost";
            this.ServiceClassCostCol.HeaderText = "Стоимость занятия";
            this.ServiceClassCostCol.MinimumWidth = 10;
            this.ServiceClassCostCol.Name = "ServiceClassCostCol";
            this.ServiceClassCostCol.Width = 80;
            // 
            // ServiceCategoryCol
            // 
            this.ServiceCategoryCol.DataPropertyName = "service_category_id";
            this.ServiceCategoryCol.HeaderText = "Категория";
            this.ServiceCategoryCol.MinimumWidth = 10;
            this.ServiceCategoryCol.Name = "ServiceCategoryCol";
            this.ServiceCategoryCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ServiceCategoryCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ServiceCategoryCol.Width = 120;
            // 
            // IdCol
            // 
            this.IdCol.DataPropertyName = "id";
            this.IdCol.HeaderText = "ID";
            this.IdCol.MinimumWidth = 10;
            this.IdCol.Name = "IdCol";
            this.IdCol.ReadOnly = true;
            this.IdCol.Width = 50;
            // 
            // SurnameCol
            // 
            this.SurnameCol.DataPropertyName = "surname";
            this.SurnameCol.HeaderText = "Фамилия";
            this.SurnameCol.MinimumWidth = 10;
            this.SurnameCol.Name = "SurnameCol";
            this.SurnameCol.Width = 120;
            // 
            // NameCol
            // 
            this.NameCol.DataPropertyName = "Name";
            this.NameCol.HeaderText = "Имя";
            this.NameCol.MinimumWidth = 10;
            this.NameCol.Name = "NameCol";
            this.NameCol.Width = 120;
            // 
            // PatronymicCol
            // 
            this.PatronymicCol.DataPropertyName = "patronymic";
            this.PatronymicCol.HeaderText = "Отчество";
            this.PatronymicCol.MinimumWidth = 10;
            this.PatronymicCol.Name = "PatronymicCol";
            this.PatronymicCol.Width = 120;
            // 
            // GenderCol
            // 
            this.GenderCol.DataPropertyName = "gender";
            this.GenderCol.HeaderText = "Мужчина?";
            this.GenderCol.MinimumWidth = 10;
            this.GenderCol.Name = "GenderCol";
            this.GenderCol.Width = 50;
            // 
            // BirthdateCol
            // 
            this.BirthdateCol.DataPropertyName = "birth_date";
            this.BirthdateCol.HeaderText = "Дата рождения";
            this.BirthdateCol.MinimumWidth = 10;
            this.BirthdateCol.Name = "BirthdateCol";
            this.BirthdateCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BirthdateCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.BirthdateCol.Width = 70;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(812, 545);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Report1YearInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewService;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridViewReport1;
        private System.Windows.Forms.NumericUpDown Report1YearInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox Report2CategorySelect;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewReport2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceClassCostCol;
        private System.Windows.Forms.DataGridViewComboBoxColumn ServiceCategoryCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatronymicCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn GenderCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthdateCol;
    }
}

