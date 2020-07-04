namespace KP_Sportzal_DescApp
{
    partial class FormAddTraning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddTraning));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label tRAINERLabel;
            System.Windows.Forms.Label sECTIONLabel;
            System.Windows.Forms.Label rOOMLabel;
            System.Windows.Forms.Label tBEGINLabel;
            System.Windows.Forms.Label tENDLabel;
            System.Windows.Forms.Label cOSTLabel;
            this.dataSet1 = new KP_Sportzal_DescApp.DataSet1();
            this.tIMETABLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tIMETABLETableAdapter = new KP_Sportzal_DescApp.DataSet1TableAdapters.TIMETABLETableAdapter();
            this.tableAdapterManager = new KP_Sportzal_DescApp.DataSet1TableAdapters.TableAdapterManager();
            this.tIMETABLEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tIMETABLEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.tRAINERComboBox = new System.Windows.Forms.ComboBox();
            this.sECTIONComboBox = new System.Windows.Forms.ComboBox();
            this.rOOMComboBox = new System.Windows.Forms.ComboBox();
            this.tBEGINDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tENDDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cOSTTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.sPORTTRAINERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPORTTRAINERSTableAdapter = new KP_Sportzal_DescApp.DataSet1TableAdapters.SPORTTRAINERSTableAdapter();
            this.sECTIONSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sECTIONSTableAdapter = new KP_Sportzal_DescApp.DataSet1TableAdapters.SECTIONSTableAdapter();
            this.rOOMSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rOOMSTableAdapter = new KP_Sportzal_DescApp.DataSet1TableAdapters.ROOMSTableAdapter();
            iDLabel = new System.Windows.Forms.Label();
            tRAINERLabel = new System.Windows.Forms.Label();
            sECTIONLabel = new System.Windows.Forms.Label();
            rOOMLabel = new System.Windows.Forms.Label();
            tBEGINLabel = new System.Windows.Forms.Label();
            tENDLabel = new System.Windows.Forms.Label();
            cOSTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIMETABLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIMETABLEBindingNavigator)).BeginInit();
            this.tIMETABLEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPORTTRAINERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sECTIONSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOOMSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tIMETABLEBindingSource
            // 
            this.tIMETABLEBindingSource.DataMember = "TIMETABLE";
            this.tIMETABLEBindingSource.DataSource = this.dataSet1;
            // 
            // tIMETABLETableAdapter
            // 
            this.tIMETABLETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ABONEMENTSTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CUSTOMERSTableAdapter = null;
            this.tableAdapterManager.RECORDSTableAdapter = null;
            this.tableAdapterManager.ROOMSTableAdapter = this.rOOMSTableAdapter;
            this.tableAdapterManager.SECTIONSTableAdapter = this.sECTIONSTableAdapter;
            this.tableAdapterManager.SPORTSESSIONSTableAdapter = null;
            this.tableAdapterManager.SPORTUSERSTableAdapter = null;
            this.tableAdapterManager.TIMETABLETableAdapter = this.tIMETABLETableAdapter;
            this.tableAdapterManager.TRAINERSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KP_Sportzal_DescApp.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tIMETABLEBindingNavigator
            // 
            this.tIMETABLEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tIMETABLEBindingNavigator.BindingSource = this.tIMETABLEBindingSource;
            this.tIMETABLEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tIMETABLEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tIMETABLEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tIMETABLEBindingNavigatorSaveItem});
            this.tIMETABLEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tIMETABLEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tIMETABLEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tIMETABLEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tIMETABLEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tIMETABLEBindingNavigator.Name = "tIMETABLEBindingNavigator";
            this.tIMETABLEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tIMETABLEBindingNavigator.Size = new System.Drawing.Size(396, 25);
            this.tIMETABLEBindingNavigator.TabIndex = 0;
            this.tIMETABLEBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // tIMETABLEBindingNavigatorSaveItem
            // 
            this.tIMETABLEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tIMETABLEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tIMETABLEBindingNavigatorSaveItem.Image")));
            this.tIMETABLEBindingNavigatorSaveItem.Name = "tIMETABLEBindingNavigatorSaveItem";
            this.tIMETABLEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tIMETABLEBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.tIMETABLEBindingNavigatorSaveItem.Click += new System.EventHandler(this.tIMETABLEBindingNavigatorSaveItem_Click);
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(43, 42);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(29, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "Код:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tIMETABLEBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(78, 39);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(65, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // tRAINERLabel
            // 
            tRAINERLabel.AutoSize = true;
            tRAINERLabel.Location = new System.Drawing.Point(25, 68);
            tRAINERLabel.Name = "tRAINERLabel";
            tRAINERLabel.Size = new System.Drawing.Size(47, 13);
            tRAINERLabel.TabIndex = 3;
            tRAINERLabel.Text = "Тренер:";
            // 
            // tRAINERComboBox
            // 
            this.tRAINERComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tIMETABLEBindingSource, "TRAINER", true));
            this.tRAINERComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tIMETABLEBindingSource, "TRAINER", true));
            this.tRAINERComboBox.DataSource = this.sPORTTRAINERSBindingSource;
            this.tRAINERComboBox.DisplayMember = "KLIENT_ID";
            this.tRAINERComboBox.FormattingEnabled = true;
            this.tRAINERComboBox.Location = new System.Drawing.Point(78, 65);
            this.tRAINERComboBox.Name = "tRAINERComboBox";
            this.tRAINERComboBox.Size = new System.Drawing.Size(65, 21);
            this.tRAINERComboBox.TabIndex = 4;
            this.tRAINERComboBox.ValueMember = "KLIENT_ID";
            this.tRAINERComboBox.SelectedIndexChanged += new System.EventHandler(this.tRAINERComboBox_SelectedIndexChanged);
            this.tRAINERComboBox.TextUpdate += new System.EventHandler(this.tRAINERComboBox_TextUpdate);
            // 
            // sECTIONLabel
            // 
            sECTIONLabel.AutoSize = true;
            sECTIONLabel.Location = new System.Drawing.Point(25, 95);
            sECTIONLabel.Name = "sECTIONLabel";
            sECTIONLabel.Size = new System.Drawing.Size(47, 13);
            sECTIONLabel.TabIndex = 5;
            sECTIONLabel.Text = "Секция:";
            // 
            // sECTIONComboBox
            // 
            this.sECTIONComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tIMETABLEBindingSource, "SECTION", true));
            this.sECTIONComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tIMETABLEBindingSource, "SECTION", true));
            this.sECTIONComboBox.DataSource = this.sECTIONSBindingSource;
            this.sECTIONComboBox.DisplayMember = "ID";
            this.sECTIONComboBox.FormattingEnabled = true;
            this.sECTIONComboBox.Location = new System.Drawing.Point(78, 92);
            this.sECTIONComboBox.Name = "sECTIONComboBox";
            this.sECTIONComboBox.Size = new System.Drawing.Size(65, 21);
            this.sECTIONComboBox.TabIndex = 6;
            this.sECTIONComboBox.ValueMember = "ID";
            this.sECTIONComboBox.SelectedIndexChanged += new System.EventHandler(this.sECTIONComboBox_SelectedIndexChanged);
            this.sECTIONComboBox.TextUpdate += new System.EventHandler(this.sECTIONComboBox_TextUpdate);
            // 
            // rOOMLabel
            // 
            rOOMLabel.AutoSize = true;
            rOOMLabel.Location = new System.Drawing.Point(1, 123);
            rOOMLabel.Name = "rOOMLabel";
            rOOMLabel.Size = new System.Drawing.Size(71, 13);
            rOOMLabel.TabIndex = 7;
            rOOMLabel.Text = "Помещение:";
            // 
            // rOOMComboBox
            // 
            this.rOOMComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tIMETABLEBindingSource, "ROOM", true));
            this.rOOMComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tIMETABLEBindingSource, "ROOM", true));
            this.rOOMComboBox.DataSource = this.rOOMSBindingSource;
            this.rOOMComboBox.DisplayMember = "ID";
            this.rOOMComboBox.FormattingEnabled = true;
            this.rOOMComboBox.Location = new System.Drawing.Point(78, 119);
            this.rOOMComboBox.Name = "rOOMComboBox";
            this.rOOMComboBox.Size = new System.Drawing.Size(65, 21);
            this.rOOMComboBox.TabIndex = 8;
            this.rOOMComboBox.ValueMember = "ID";
            this.rOOMComboBox.SelectedIndexChanged += new System.EventHandler(this.rOOMComboBox_SelectedIndexChanged);
            this.rOOMComboBox.TextUpdate += new System.EventHandler(this.rOOMComboBox_TextUpdate);
            // 
            // tBEGINLabel
            // 
            tBEGINLabel.AutoSize = true;
            tBEGINLabel.Location = new System.Drawing.Point(25, 150);
            tBEGINLabel.Name = "tBEGINLabel";
            tBEGINLabel.Size = new System.Drawing.Size(47, 13);
            tBEGINLabel.TabIndex = 9;
            tBEGINLabel.Text = "Начало:";
            // 
            // tBEGINDateTimePicker
            // 
            this.tBEGINDateTimePicker.CustomFormat = "d.MM.yyyy HH:m";
            this.tBEGINDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tIMETABLEBindingSource, "TBEGIN", true));
            this.tBEGINDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tBEGINDateTimePicker.Location = new System.Drawing.Point(78, 146);
            this.tBEGINDateTimePicker.Name = "tBEGINDateTimePicker";
            this.tBEGINDateTimePicker.Size = new System.Drawing.Size(298, 20);
            this.tBEGINDateTimePicker.TabIndex = 10;
            this.tBEGINDateTimePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // tENDLabel
            // 
            tENDLabel.AutoSize = true;
            tENDLabel.Location = new System.Drawing.Point(7, 178);
            tENDLabel.Name = "tENDLabel";
            tENDLabel.Size = new System.Drawing.Size(65, 13);
            tENDLabel.TabIndex = 11;
            tENDLabel.Text = "Окончание:";
            // 
            // tENDDateTimePicker
            // 
            this.tENDDateTimePicker.CustomFormat = "d.MM.yyyy HH:m";
            this.tENDDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tIMETABLEBindingSource, "TEND", true));
            this.tENDDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tENDDateTimePicker.Location = new System.Drawing.Point(78, 172);
            this.tENDDateTimePicker.Name = "tENDDateTimePicker";
            this.tENDDateTimePicker.Size = new System.Drawing.Size(298, 20);
            this.tENDDateTimePicker.TabIndex = 12;
            this.tENDDateTimePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // cOSTLabel
            // 
            cOSTLabel.AutoSize = true;
            cOSTLabel.Location = new System.Drawing.Point(7, 201);
            cOSTLabel.Name = "cOSTLabel";
            cOSTLabel.Size = new System.Drawing.Size(65, 13);
            cOSTLabel.TabIndex = 13;
            cOSTLabel.Text = "Стоимость:";
            // 
            // cOSTTextBox
            // 
            this.cOSTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tIMETABLEBindingSource, "COST", true));
            this.cOSTTextBox.Location = new System.Drawing.Point(78, 198);
            this.cOSTTextBox.Name = "cOSTTextBox";
            this.cOSTTextBox.Size = new System.Drawing.Size(65, 20);
            this.cOSTTextBox.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 20);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(149, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 20);
            this.textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(149, 120);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(189, 20);
            this.textBox3.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(344, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(344, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            // sECTIONSBindingSource
            // 
            this.sECTIONSBindingSource.DataMember = "SECTIONS";
            this.sECTIONSBindingSource.DataSource = this.dataSet1;
            // 
            // sECTIONSTableAdapter
            // 
            this.sECTIONSTableAdapter.ClearBeforeFill = true;
            // 
            // rOOMSBindingSource
            // 
            this.rOOMSBindingSource.DataMember = "ROOMS";
            this.rOOMSBindingSource.DataSource = this.dataSet1;
            // 
            // rOOMSTableAdapter
            // 
            this.rOOMSTableAdapter.ClearBeforeFill = true;
            // 
            // FormAddTraning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 241);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(tRAINERLabel);
            this.Controls.Add(this.tRAINERComboBox);
            this.Controls.Add(sECTIONLabel);
            this.Controls.Add(this.sECTIONComboBox);
            this.Controls.Add(rOOMLabel);
            this.Controls.Add(this.rOOMComboBox);
            this.Controls.Add(tBEGINLabel);
            this.Controls.Add(this.tBEGINDateTimePicker);
            this.Controls.Add(tENDLabel);
            this.Controls.Add(this.tENDDateTimePicker);
            this.Controls.Add(cOSTLabel);
            this.Controls.Add(this.cOSTTextBox);
            this.Controls.Add(this.tIMETABLEBindingNavigator);
            this.Name = "FormAddTraning";
            this.Text = "Занятие";
            this.Load += new System.EventHandler(this.FormAddTraning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIMETABLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIMETABLEBindingNavigator)).EndInit();
            this.tIMETABLEBindingNavigator.ResumeLayout(false);
            this.tIMETABLEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPORTTRAINERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sECTIONSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOOMSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tIMETABLEBindingSource;
        private DataSet1TableAdapters.TIMETABLETableAdapter tIMETABLETableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tIMETABLEBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tIMETABLEBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.ComboBox tRAINERComboBox;
        private System.Windows.Forms.ComboBox sECTIONComboBox;
        private System.Windows.Forms.ComboBox rOOMComboBox;
        private System.Windows.Forms.DateTimePicker tBEGINDateTimePicker;
        private System.Windows.Forms.DateTimePicker tENDDateTimePicker;
        private System.Windows.Forms.TextBox cOSTTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource sPORTTRAINERSBindingSource;
        private DataSet1TableAdapters.SPORTTRAINERSTableAdapter sPORTTRAINERSTableAdapter;
        private DataSet1TableAdapters.SECTIONSTableAdapter sECTIONSTableAdapter;
        private System.Windows.Forms.BindingSource sECTIONSBindingSource;
        private DataSet1TableAdapters.ROOMSTableAdapter rOOMSTableAdapter;
        private System.Windows.Forms.BindingSource rOOMSBindingSource;
    }
}