namespace KP_Sportzal_DescApp
{
    partial class FormSelTrener
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
            this.dataSet1 = new KP_Sportzal_DescApp.DataSet1();
            this.sPORTTRAINERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPORTTRAINERSTableAdapter = new KP_Sportzal_DescApp.DataSet1TableAdapters.SPORTTRAINERSTableAdapter();
            this.tableAdapterManager = new KP_Sportzal_DescApp.DataSet1TableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.tRAINERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRAINERSTableAdapter = new KP_Sportzal_DescApp.DataSet1TableAdapters.TRAINERSTableAdapter();
            this.tRAINERSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPORTTRAINERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAINERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAINERSDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPORTTRAINERSBindingSource
            // 
            this.sPORTTRAINERSBindingSource.DataMember = "SPORTTRAINERS";
            this.sPORTTRAINERSBindingSource.DataSource = this.dataSet1;
            // 
            // sPORTTRAINERSTableAdapter
            // 
            this.sPORTTRAINERSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CUSTOMERSTableAdapter = null;
            this.tableAdapterManager.RECORDSTableAdapter = null;
            this.tableAdapterManager.ROOMSTableAdapter = null;
            this.tableAdapterManager.SECTIONSTableAdapter = null;
            this.tableAdapterManager.SPORTSESSIONSTableAdapter = null;
            this.tableAdapterManager.SPORTUSERSTableAdapter = null;
            this.tableAdapterManager.TIMETABLETableAdapter = null;
            this.tableAdapterManager.TRAINERSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KP_Sportzal_DescApp.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выбор";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tRAINERSBindingSource
            // 
            this.tRAINERSBindingSource.DataMember = "TRAINERS";
            this.tRAINERSBindingSource.DataSource = this.dataSet1;
            // 
            // tRAINERSTableAdapter
            // 
            this.tRAINERSTableAdapter.ClearBeforeFill = true;
            // 
            // tRAINERSDataGridView
            // 
            this.tRAINERSDataGridView.AutoGenerateColumns = false;
            this.tRAINERSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tRAINERSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tRAINERSDataGridView.DataSource = this.tRAINERSBindingSource;
            this.tRAINERSDataGridView.Location = new System.Drawing.Point(16, 32);
            this.tRAINERSDataGridView.Name = "tRAINERSDataGridView";
            this.tRAINERSDataGridView.Size = new System.Drawing.Size(533, 220);
            this.tRAINERSDataGridView.TabIndex = 2;
            this.tRAINERSDataGridView.DoubleClick += new System.EventHandler(this.tRAINERSDataGridView_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SURNAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NAME";
            this.dataGridViewTextBoxColumn3.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PATRONYMIC";
            this.dataGridViewTextBoxColumn4.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CONTACT";
            this.dataGridViewTextBoxColumn5.HeaderText = "Контакты";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // FormSelTrener
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 272);
            this.Controls.Add(this.tRAINERSDataGridView);
            this.Controls.Add(this.button1);
            this.Name = "FormSelTrener";
            this.Text = "Тренеры";
            this.Load += new System.EventHandler(this.FormSelTrener_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPORTTRAINERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAINERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAINERSDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource sPORTTRAINERSBindingSource;
        private DataSet1TableAdapters.SPORTTRAINERSTableAdapter sPORTTRAINERSTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource tRAINERSBindingSource;
        private DataSet1TableAdapters.TRAINERSTableAdapter tRAINERSTableAdapter;
        private System.Windows.Forms.DataGridView tRAINERSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}