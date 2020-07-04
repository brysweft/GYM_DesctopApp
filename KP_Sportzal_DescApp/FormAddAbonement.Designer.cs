namespace KP_Sportzal_DescApp
{
    partial class FormAddAbonement
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label kLIENTLabel;
            System.Windows.Forms.Label bEGINLabel;
            System.Windows.Forms.Label eNDLabel;
            System.Windows.Forms.Label dISCOUNTLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddAbonement));
            this.dataSet1 = new KP_Sportzal_DescApp.DataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.aBONEMENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBONEMENTSTableAdapter = new KP_Sportzal_DescApp.DataSet1TableAdapters.ABONEMENTSTableAdapter();
            this.tableAdapterManager = new KP_Sportzal_DescApp.DataSet1TableAdapters.TableAdapterManager();
            this.aBONEMENTSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aBONEMENTSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.kLIENTComboBox = new System.Windows.Forms.ComboBox();
            this.bEGINDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.eNDDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dISCOUNTTextBox = new System.Windows.Forms.TextBox();
            this.sPORTCUSTUMERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPORTCUSTUMERSTableAdapter = new KP_Sportzal_DescApp.DataSet1TableAdapters.SPORTCUSTUMERSTableAdapter();
            iDLabel = new System.Windows.Forms.Label();
            kLIENTLabel = new System.Windows.Forms.Label();
            bEGINLabel = new System.Windows.Forms.Label();
            eNDLabel = new System.Windows.Forms.Label();
            dISCOUNTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBONEMENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBONEMENTSBindingNavigator)).BeginInit();
            this.aBONEMENTSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPORTCUSTUMERSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(55, 42);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(27, 13);
            iDLabel.TabIndex = 14;
            iDLabel.Text = "ИД:";
            // 
            // kLIENTLabel
            // 
            kLIENTLabel.AutoSize = true;
            kLIENTLabel.Location = new System.Drawing.Point(36, 68);
            kLIENTLabel.Name = "kLIENTLabel";
            kLIENTLabel.Size = new System.Drawing.Size(46, 13);
            kLIENTLabel.TabIndex = 16;
            kLIENTLabel.Text = "Клиент:";
            // 
            // bEGINLabel
            // 
            bEGINLabel.AutoSize = true;
            bEGINLabel.Location = new System.Drawing.Point(35, 96);
            bEGINLabel.Name = "bEGINLabel";
            bEGINLabel.Size = new System.Drawing.Size(47, 13);
            bEGINLabel.TabIndex = 18;
            bEGINLabel.Text = "Начало:";
            // 
            // eNDLabel
            // 
            eNDLabel.AutoSize = true;
            eNDLabel.Location = new System.Drawing.Point(17, 124);
            eNDLabel.Name = "eNDLabel";
            eNDLabel.Size = new System.Drawing.Size(65, 13);
            eNDLabel.TabIndex = 20;
            eNDLabel.Text = "Окончание:";
            // 
            // dISCOUNTLabel
            // 
            dISCOUNTLabel.AutoSize = true;
            dISCOUNTLabel.Location = new System.Drawing.Point(35, 147);
            dISCOUNTLabel.Name = "dISCOUNTLabel";
            dISCOUNTLabel.Size = new System.Drawing.Size(47, 13);
            dISCOUNTLabel.TabIndex = 22;
            dISCOUNTLabel.Text = "Скидка:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 11;
            // 
            // aBONEMENTSBindingSource
            // 
            this.aBONEMENTSBindingSource.DataMember = "ABONEMENTS";
            this.aBONEMENTSBindingSource.DataSource = this.dataSet1;
            // 
            // aBONEMENTSTableAdapter
            // 
            this.aBONEMENTSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ABONEMENTSTableAdapter = this.aBONEMENTSTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
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
            // aBONEMENTSBindingNavigator
            // 
            this.aBONEMENTSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aBONEMENTSBindingNavigator.BindingSource = this.aBONEMENTSBindingSource;
            this.aBONEMENTSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aBONEMENTSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aBONEMENTSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.aBONEMENTSBindingNavigatorSaveItem});
            this.aBONEMENTSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.aBONEMENTSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aBONEMENTSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aBONEMENTSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aBONEMENTSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aBONEMENTSBindingNavigator.Name = "aBONEMENTSBindingNavigator";
            this.aBONEMENTSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aBONEMENTSBindingNavigator.Size = new System.Drawing.Size(392, 25);
            this.aBONEMENTSBindingNavigator.TabIndex = 14;
            this.aBONEMENTSBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // aBONEMENTSBindingNavigatorSaveItem
            // 
            this.aBONEMENTSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aBONEMENTSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aBONEMENTSBindingNavigatorSaveItem.Image")));
            this.aBONEMENTSBindingNavigatorSaveItem.Name = "aBONEMENTSBindingNavigatorSaveItem";
            this.aBONEMENTSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.aBONEMENTSBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.aBONEMENTSBindingNavigatorSaveItem.Click += new System.EventHandler(this.aBONEMENTSBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aBONEMENTSBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(82, 39);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(56, 20);
            this.iDTextBox.TabIndex = 15;
            // 
            // kLIENTComboBox
            // 
            this.kLIENTComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aBONEMENTSBindingSource, "KLIENT", true));
            this.kLIENTComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.aBONEMENTSBindingSource, "KLIENT", true));
            this.kLIENTComboBox.DataSource = this.sPORTCUSTUMERSBindingSource;
            this.kLIENTComboBox.DisplayMember = "KLIENT_ID";
            this.kLIENTComboBox.FormattingEnabled = true;
            this.kLIENTComboBox.Location = new System.Drawing.Point(82, 65);
            this.kLIENTComboBox.Name = "kLIENTComboBox";
            this.kLIENTComboBox.Size = new System.Drawing.Size(66, 21);
            this.kLIENTComboBox.TabIndex = 17;
            this.kLIENTComboBox.ValueMember = "KLIENT_ID";
            this.kLIENTComboBox.SelectedIndexChanged += new System.EventHandler(this.kLIENTComboBox_SelectedIndexChanged);
            this.kLIENTComboBox.TextUpdate += new System.EventHandler(this.kLIENTComboBox_TextUpdate);
            // 
            // bEGINDateTimePicker
            // 
            this.bEGINDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aBONEMENTSBindingSource, "BEGIN", true));
            this.bEGINDateTimePicker.Location = new System.Drawing.Point(82, 92);
            this.bEGINDateTimePicker.Name = "bEGINDateTimePicker";
            this.bEGINDateTimePicker.Size = new System.Drawing.Size(236, 20);
            this.bEGINDateTimePicker.TabIndex = 19;
            // 
            // eNDDateTimePicker
            // 
            this.eNDDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aBONEMENTSBindingSource, "END", true));
            this.eNDDateTimePicker.Location = new System.Drawing.Point(82, 118);
            this.eNDDateTimePicker.Name = "eNDDateTimePicker";
            this.eNDDateTimePicker.Size = new System.Drawing.Size(236, 20);
            this.eNDDateTimePicker.TabIndex = 21;
            // 
            // dISCOUNTTextBox
            // 
            this.dISCOUNTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aBONEMENTSBindingSource, "DISCOUNT", true));
            this.dISCOUNTTextBox.Location = new System.Drawing.Point(82, 144);
            this.dISCOUNTTextBox.Name = "dISCOUNTTextBox";
            this.dISCOUNTTextBox.Size = new System.Drawing.Size(66, 20);
            this.dISCOUNTTextBox.TabIndex = 23;
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
            // FormAddAbonement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 180);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(kLIENTLabel);
            this.Controls.Add(this.kLIENTComboBox);
            this.Controls.Add(bEGINLabel);
            this.Controls.Add(this.bEGINDateTimePicker);
            this.Controls.Add(eNDLabel);
            this.Controls.Add(this.eNDDateTimePicker);
            this.Controls.Add(dISCOUNTLabel);
            this.Controls.Add(this.dISCOUNTTextBox);
            this.Controls.Add(this.aBONEMENTSBindingNavigator);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "FormAddAbonement";
            this.Text = "Абонемент";
            this.Load += new System.EventHandler(this.FormAddAbonement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBONEMENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBONEMENTSBindingNavigator)).EndInit();
            this.aBONEMENTSBindingNavigator.ResumeLayout(false);
            this.aBONEMENTSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPORTCUSTUMERSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource aBONEMENTSBindingSource;
        private DataSet1TableAdapters.ABONEMENTSTableAdapter aBONEMENTSTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator aBONEMENTSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton aBONEMENTSBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.ComboBox kLIENTComboBox;
        private System.Windows.Forms.DateTimePicker bEGINDateTimePicker;
        private System.Windows.Forms.DateTimePicker eNDDateTimePicker;
        private System.Windows.Forms.TextBox dISCOUNTTextBox;
        private System.Windows.Forms.BindingSource sPORTCUSTUMERSBindingSource;
        private DataSet1TableAdapters.SPORTCUSTUMERSTableAdapter sPORTCUSTUMERSTableAdapter;
    }
}