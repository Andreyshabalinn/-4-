namespace DatabaseConnect
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataSet1 = new DatabaseConnect.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eMPLOYEESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEESTableAdapter = new DatabaseConnect.DataSet1TableAdapters.EMPLOYEESTableAdapter();
            this.eMPLOYEEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRSTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lASTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONENUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hIREDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jOBIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALARYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMMISSIONPCTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mANAGERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPARTMENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1BindingSource1
            // 
            this.dataSet1BindingSource1.DataSource = this.dataSet1;
            this.dataSet1BindingSource1.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eMPLOYEEIDDataGridViewTextBoxColumn,
            this.fIRSTNAMEDataGridViewTextBoxColumn,
            this.lASTNAMEDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.pHONENUMBERDataGridViewTextBoxColumn,
            this.hIREDATEDataGridViewTextBoxColumn,
            this.jOBIDDataGridViewTextBoxColumn,
            this.sALARYDataGridViewTextBoxColumn,
            this.cOMMISSIONPCTDataGridViewTextBoxColumn,
            this.mANAGERIDDataGridViewTextBoxColumn,
            this.dEPARTMENTIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eMPLOYEESBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-5, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1144, 254);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // eMPLOYEESBindingSource
            // 
            this.eMPLOYEESBindingSource.DataMember = "EMPLOYEES";
            this.eMPLOYEESBindingSource.DataSource = this.dataSet1;
            // 
            // eMPLOYEESTableAdapter
            // 
            this.eMPLOYEESTableAdapter.ClearBeforeFill = true;
            // 
            // eMPLOYEEIDDataGridViewTextBoxColumn
            // 
            this.eMPLOYEEIDDataGridViewTextBoxColumn.DataPropertyName = "EMPLOYEE_ID";
            this.eMPLOYEEIDDataGridViewTextBoxColumn.HeaderText = "EMPLOYEE_ID";
            this.eMPLOYEEIDDataGridViewTextBoxColumn.Name = "eMPLOYEEIDDataGridViewTextBoxColumn";
            // 
            // fIRSTNAMEDataGridViewTextBoxColumn
            // 
            this.fIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRST_NAME";
            this.fIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "FIRST_NAME";
            this.fIRSTNAMEDataGridViewTextBoxColumn.Name = "fIRSTNAMEDataGridViewTextBoxColumn";
            // 
            // lASTNAMEDataGridViewTextBoxColumn
            // 
            this.lASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LAST_NAME";
            this.lASTNAMEDataGridViewTextBoxColumn.HeaderText = "LAST_NAME";
            this.lASTNAMEDataGridViewTextBoxColumn.Name = "lASTNAMEDataGridViewTextBoxColumn";
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            // 
            // pHONENUMBERDataGridViewTextBoxColumn
            // 
            this.pHONENUMBERDataGridViewTextBoxColumn.DataPropertyName = "PHONE_NUMBER";
            this.pHONENUMBERDataGridViewTextBoxColumn.HeaderText = "PHONE_NUMBER";
            this.pHONENUMBERDataGridViewTextBoxColumn.Name = "pHONENUMBERDataGridViewTextBoxColumn";
            // 
            // hIREDATEDataGridViewTextBoxColumn
            // 
            this.hIREDATEDataGridViewTextBoxColumn.DataPropertyName = "HIRE_DATE";
            this.hIREDATEDataGridViewTextBoxColumn.HeaderText = "HIRE_DATE";
            this.hIREDATEDataGridViewTextBoxColumn.Name = "hIREDATEDataGridViewTextBoxColumn";
            // 
            // jOBIDDataGridViewTextBoxColumn
            // 
            this.jOBIDDataGridViewTextBoxColumn.DataPropertyName = "JOB_ID";
            this.jOBIDDataGridViewTextBoxColumn.HeaderText = "JOB_ID";
            this.jOBIDDataGridViewTextBoxColumn.Name = "jOBIDDataGridViewTextBoxColumn";
            // 
            // sALARYDataGridViewTextBoxColumn
            // 
            this.sALARYDataGridViewTextBoxColumn.DataPropertyName = "SALARY";
            this.sALARYDataGridViewTextBoxColumn.HeaderText = "SALARY";
            this.sALARYDataGridViewTextBoxColumn.Name = "sALARYDataGridViewTextBoxColumn";
            // 
            // cOMMISSIONPCTDataGridViewTextBoxColumn
            // 
            this.cOMMISSIONPCTDataGridViewTextBoxColumn.DataPropertyName = "COMMISSION_PCT";
            this.cOMMISSIONPCTDataGridViewTextBoxColumn.HeaderText = "COMMISSION_PCT";
            this.cOMMISSIONPCTDataGridViewTextBoxColumn.Name = "cOMMISSIONPCTDataGridViewTextBoxColumn";
            // 
            // mANAGERIDDataGridViewTextBoxColumn
            // 
            this.mANAGERIDDataGridViewTextBoxColumn.DataPropertyName = "MANAGER_ID";
            this.mANAGERIDDataGridViewTextBoxColumn.HeaderText = "MANAGER_ID";
            this.mANAGERIDDataGridViewTextBoxColumn.Name = "mANAGERIDDataGridViewTextBoxColumn";
            // 
            // dEPARTMENTIDDataGridViewTextBoxColumn
            // 
            this.dEPARTMENTIDDataGridViewTextBoxColumn.DataPropertyName = "DEPARTMENT_ID";
            this.dEPARTMENTIDDataGridViewTextBoxColumn.HeaderText = "DEPARTMENT_ID";
            this.dEPARTMENTIDDataGridViewTextBoxColumn.Name = "dEPARTMENTIDDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выполнить запрос";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(256, 391);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(256, 299);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите id записи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Вывод:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 454);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource dataSet1BindingSource1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource eMPLOYEESBindingSource;
        private DataSet1TableAdapters.EMPLOYEESTableAdapter eMPLOYEESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPLOYEEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRSTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lASTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONENUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hIREDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOBIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALARYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMMISSIONPCTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANAGERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPARTMENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

