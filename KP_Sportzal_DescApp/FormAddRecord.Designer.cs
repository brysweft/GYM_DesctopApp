namespace KP_Sportzal_DescApp
{
    partial class FormAddRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddRecord));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label kLIENTLabel;
            System.Windows.Forms.Label tRAININGLabel;
            System.Windows.Forms.Label dATE_RECLabel;
            System.Windows.Forms.Label vISITLabel;
            this.dataSet1 = new KP_Sportzal_DescApp.DataSet1();
            this.rECORDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rECORDSTableAdapter = new KP_Sportzal_DescApp.DataSet1TableAdapters.RECORDSTableAdapter();
            this.tableAdapterManager = new KP_Sportzal_DescApp.DataSet1TableAdapters.TableAdapterManager();
            this.rECORDSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.rECORDSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.dATE_RECDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vISITTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.kLIENTComboBox = new System.Windows.Forms.ComboBox();
            this.tRAININGComboBox = new System.Windows.Forms.ComboBox();
            this.sPORTCUSTUMERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPORTCUSTUMERSTableAdapter = new KP_Sportzal_DescApp.DataSet1TableAdapters.SPORTCUSTUMERSTableAdapter();
            this.sPORTRECORDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPORTRECORDSTableAdapter = new KP_Sportzal_DescApp.DataSet1TableAdapters.SPORTRECORDSTableAdapter();
            this.sPORTTIMETABLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPORTTIMETABLETableAdapter = new KP_Sportzal_DescApp.DataSet1TableAdapters.SPORTTIMETABLETableAdapter();
            iDLabel = new System.Windows.Forms.Label();
            kLIENTLabel = new System.Windows.Forms.Label();
            tRAININGLabel = new System.Windows.Forms.Label();
            dATE_RECLabel = new System.Windows.Forms.Label();
            vISITLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECORDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECORDSBindingNavigator)).BeginInit();
            this.rECORDSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPORTCUSTUMERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPORTRECORDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPORTTIMETABLEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rECORDSBindingSource
            // 
            this.rECORDSBindingSource.DataMember = "RECORDS";
            this.rECORDSBindingSource.DataSource = this.dataSet1;
            // 
            // rECORDSTableAdapter
            // 
            this.rECORDSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ABONEMENTSTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CUSTOMERSTableAdapter = null;
            this.tableAdapterManager.RECORDSTableAdapter = this.rECORDSTableAdapter;
            this.tableAdapterManager.ROOMSTableAdapter = null;
            this.tableAdapterManager.SECTIONSTableAdapter = null;
            this.tableAdapterManager.SPORTSESSIONSTableAdapter = null;
            this.tableAdapterManager.SPORTUSERSTableAdapter = null;
            this.tableAdapterManager.TIMETABLETableAdapter = null;
            this.tableAdapterManager.TRAINERSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KP_Sportzal_DescApp.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rECORDSBindingNavigator
            // 
            this.rECORDSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rECORDSBindingNavigator.BindingSource = this.rECORDSBindingSource;
            this.rECORDSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rECORDSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rECORDSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.rECORDSBindingNavigatorSaveItem});
            this.rECORDSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rECORDSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rECORDSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rECORDSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rECORDSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rECORDSBindingNavigator.Name = "rECORDSBindingNavigator";
            this.rECORDSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rECORDSBindingNavigator.Size = new System.Drawing.Size(536, 25);
            this.rECORDSBindingNavigator.TabIndex = 0;
            this.rECORDSBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // rECORDSBindingNavigatorSaveItem
            // 
            this.rECORDSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rECORDSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rECORDSBindingNavigatorSaveItem.Image")));
            this.rECORDSBindingNavigatorSaveItem.Name = "rECORDSBindingNavigatorSaveItem";
            this.rECORDSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.rECORDSBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.rECORDSBindingNavigatorSaveItem.Click += new System.EventHandler(this.rECORDSBindingNavigatorSaveItem_Click);
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(33, 31);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(44, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "Номер:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rECORDSBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(83, 28);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(200, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // kLIENTLabel
            // 
            kLIENTLabel.AutoSize = true;
            kLIENTLabel.Location = new System.Drawing.Point(31, 57);
            kLIENTLabel.Name = "kLIENTLabel";
            kLIENTLabel.Size = new System.Drawing.Size(46, 13);
            kLIENTLabel.TabIndex = 3;
            kLIENTLabel.Text = "Клиент:";
            // 
            // tRAININGLabel
            // 
            tRAININGLabel.AutoSize = true;
            tRAININGLabel.Location = new System.Drawing.Point(25, 83);
            tRAININGLabel.Name = "tRAININGLabel";
            tRAININGLabel.Size = new System.Drawing.Size(52, 13);
            tRAININGLabel.TabIndex = 5;
            tRAININGLabel.Text = "Занятие:";
            // 
            // dATE_RECLabel
            // 
            dATE_RECLabel.AutoSize = true;
            dATE_RECLabel.Location = new System.Drawing.Point(289, 31);
            dATE_RECLabel.Name = "dATE_RECLabel";
            dATE_RECLabel.Size = new System.Drawing.Size(21, 13);
            dATE_RECLabel.TabIndex = 7;
            dATE_RECLabel.Text = "от:";
            // 
            // dATE_RECDateTimePicker
            // 
            this.dATE_RECDateTimePicker.CustomFormat = "d.MM.yyyy HH:m";
            this.dATE_RECDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rECORDSBindingSource, "DATE_REC", true));
            this.dATE_RECDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dATE_RECDateTimePicker.Location = new System.Drawing.Point(316, 28);
            this.dATE_RECDateTimePicker.Name = "dATE_RECDateTimePicker";
            this.dATE_RECDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dATE_RECDateTimePicker.TabIndex = 8;
            this.dATE_RECDateTimePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // vISITTextBox
            // 
            this.vISITTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rECORDSBindingSource, "VISIT", true));
            this.vISITTextBox.Enabled = false;
            this.vISITTextBox.Location = new System.Drawing.Point(83, 106);
            this.vISITTextBox.Name = "vISITTextBox";
            this.vISITTextBox.Size = new System.Drawing.Size(63, 20);
            this.vISITTextBox.TabIndex = 10;
            // 
            // vISITLabel
            // 
            vISITLabel.AutoSize = true;
            vISITLabel.Enabled = false;
            vISITLabel.Location = new System.Drawing.Point(8, 109);
            vISITLabel.Name = "vISITLabel";
            vISITLabel.Size = new System.Drawing.Size(69, 13);
            vISITLabel.TabIndex = 9;
            vISITLabel.Text = "Посещение:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 20);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(152, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(331, 20);
            this.textBox2.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(490, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(490, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kLIENTComboBox
            // 
            this.kLIENTComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rECORDSBindingSource, "KLIENT", true));
            this.kLIENTComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rECORDSBindingSource, "KLIENT", true));
            this.kLIENTComboBox.DataSource = this.sPORTCUSTUMERSBindingSource;
            this.kLIENTComboBox.DisplayMember = "KLIENT_ID";
            this.kLIENTComboBox.FormattingEnabled = true;
            this.kLIENTComboBox.Location = new System.Drawing.Point(83, 54);
            this.kLIENTComboBox.Name = "kLIENTComboBox";
            this.kLIENTComboBox.Size = new System.Drawing.Size(63, 21);
            this.kLIENTComboBox.TabIndex = 15;
            this.kLIENTComboBox.ValueMember = "KLIENT_ID";
            this.kLIENTComboBox.SelectedIndexChanged += new System.EventHandler(this.kLIENTComboBox_SelectedIndexChanged);
            this.kLIENTComboBox.TextUpdate += new System.EventHandler(this.kLIENTComboBox_TextUpdate);
            // 
            // tRAININGComboBox
            // 
            this.tRAININGComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rECORDSBindingSource, "TRAINING", true));
            this.tRAININGComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rECORDSBindingSource, "TRAINING", true));
            this.tRAININGComboBox.DataSource = this.sPORTTIMETABLEBindingSource;
            this.tRAININGComboBox.DisplayMember = "TRAINING_ID";
            this.tRAININGComboBox.FormattingEnabled = true;
            this.tRAININGComboBox.Location = new System.Drawing.Point(83, 78);
            this.tRAININGComboBox.Name = "tRAININGComboBox";
            this.tRAININGComboBox.Size = new System.Drawing.Size(63, 21);
            this.tRAININGComboBox.TabIndex = 16;
            this.tRAININGComboBox.ValueMember = "TRAINING_ID";
            this.tRAININGComboBox.SelectedIndexChanged += new System.EventHandler(this.tRAININGComboBox_SelectedIndexChanged);
            this.tRAININGComboBox.TextUpdate += new System.EventHandler(this.tRAININGComboBox_TextUpdate);
            // 
            // sPORTCUSTUMERSBindingSource
            // 
            this.sPORTCUSTUMERSBindingSource.DataMember = "SPORTCUSTUMERS";
            this.sPORTCUSTUMERSBindingSource.DataSource = this.dataSet1;
            // 
            // sPORTCUSTUMERSTableAdapter
            // 
            this.sPORTCUSTUMERSTableAdapter.ClearBeforeFill = true;
            // 
            // sPORTRECORDSBindingSource
            // 
            this.sPORTRECORDSBindingSource.DataMember = "SPORTRECORDS";
            this.sPORTRECORDSBindingSource.DataSource = this.dataSet1;
            // 
            // sPORTRECORDSTableAdapter
            // 
            this.sPORTRECORDSTableAdapter.ClearBeforeFill = true;
            // 
            // sPORTTIMETABLEBindingSource
            // 
            this.sPORTTIMETABLEBindingSource.DataMember = "SPORTTIMETABLE";
            this.sPORTTIMETABLEBindingSource.DataSource = this.dataSet1;
            // 
            // sPORTTIMETABLETableAdapter
            // 
            this.sPORTTIMETABLETableAdapter.ClearBeforeFill = true;
            // 
            // FormAddRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 146);
            this.Controls.Add(this.tRAININGComboBox);
            this.Controls.Add(this.kLIENTComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(kLIENTLabel);
            this.Controls.Add(tRAININGLabel);
            this.Controls.Add(dATE_RECLabel);
            this.Controls.Add(this.dATE_RECDateTimePicker);
            this.Controls.Add(vISITLabel);
            this.Controls.Add(this.vISITTextBox);
            this.Controls.Add(this.rECORDSBindingNavigator);
            this.Name = "FormAddRecord";
            this.Text = "Запись на занятие";
            this.Load += new System.EventHandler(this.FormAddRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECORDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECORDSBindingNavigator)).EndInit();
            this.rECORDSBindingNavigator.ResumeLayout(false);
            this.rECORDSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPORTCUSTUMERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPORTRECORDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPORTTIMETABLEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource rECORDSBindingSource;
        private DataSet1TableAdapters.RECORDSTableAdapter rECORDSTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rECORDSBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton rECORDSBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.DateTimePicker dATE_RECDateTimePicker;
        private System.Windows.Forms.TextBox vISITTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox kLIENTComboBox;
        private System.Windows.Forms.ComboBox tRAININGComboBox;
        private System.Windows.Forms.BindingSource sPORTCUSTUMERSBindingSource;
        private DataSet1TableAdapters.SPORTCUSTUMERSTableAdapter sPORTCUSTUMERSTableAdapter;
        private System.Windows.Forms.BindingSource sPORTRECORDSBindingSource;
        private DataSet1TableAdapters.SPORTRECORDSTableAdapter sPORTRECORDSTableAdapter;
        private System.Windows.Forms.BindingSource sPORTTIMETABLEBindingSource;
        private DataSet1TableAdapters.SPORTTIMETABLETableAdapter sPORTTIMETABLETableAdapter;
    }
}