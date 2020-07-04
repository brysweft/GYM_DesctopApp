namespace KP_Sportzal_DescApp
{
    partial class FormAddClient
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
            System.Windows.Forms.Label sURNAMELabel;
            System.Windows.Forms.Label nAMELabel;
            System.Windows.Forms.Label pATRONYMICLabel;
            System.Windows.Forms.Label dATE_BIRTHLabel;
            System.Windows.Forms.Label cONTACTLabel;
            System.Windows.Forms.Label gENDERLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddClient));
            this.dataSet1 = new KP_Sportzal_DescApp.DataSet1();
            this.cUSTOMERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOMERSTableAdapter = new KP_Sportzal_DescApp.DataSet1TableAdapters.CUSTOMERSTableAdapter();
            this.tableAdapterManager = new KP_Sportzal_DescApp.DataSet1TableAdapters.TableAdapterManager();
            this.cUSTOMERSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cUSTOMERSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.sURNAMETextBox = new System.Windows.Forms.TextBox();
            this.nAMETextBox = new System.Windows.Forms.TextBox();
            this.pATRONYMICTextBox = new System.Windows.Forms.TextBox();
            this.dATE_BIRTHDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cONTACTTextBox = new System.Windows.Forms.TextBox();
            this.gENDERComboBox = new System.Windows.Forms.ComboBox();
            iDLabel = new System.Windows.Forms.Label();
            sURNAMELabel = new System.Windows.Forms.Label();
            nAMELabel = new System.Windows.Forms.Label();
            pATRONYMICLabel = new System.Windows.Forms.Label();
            dATE_BIRTHLabel = new System.Windows.Forms.Label();
            cONTACTLabel = new System.Windows.Forms.Label();
            gENDERLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSBindingNavigator)).BeginInit();
            this.cUSTOMERSBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(45, 38);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(29, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "Код:";
            // 
            // sURNAMELabel
            // 
            sURNAMELabel.AutoSize = true;
            sURNAMELabel.Location = new System.Drawing.Point(5, 64);
            sURNAMELabel.Name = "sURNAMELabel";
            sURNAMELabel.Size = new System.Drawing.Size(59, 13);
            sURNAMELabel.TabIndex = 3;
            sURNAMELabel.Text = "Фамилия:";
            // 
            // nAMELabel
            // 
            nAMELabel.AutoSize = true;
            nAMELabel.Location = new System.Drawing.Point(234, 64);
            nAMELabel.Name = "nAMELabel";
            nAMELabel.Size = new System.Drawing.Size(32, 13);
            nAMELabel.TabIndex = 5;
            nAMELabel.Text = "Имя:";
            // 
            // pATRONYMICLabel
            // 
            pATRONYMICLabel.AutoSize = true;
            pATRONYMICLabel.Location = new System.Drawing.Point(432, 64);
            pATRONYMICLabel.Name = "pATRONYMICLabel";
            pATRONYMICLabel.Size = new System.Drawing.Size(57, 13);
            pATRONYMICLabel.TabIndex = 7;
            pATRONYMICLabel.Text = "Отчество:";
            // 
            // dATE_BIRTHLabel
            // 
            dATE_BIRTHLabel.AutoSize = true;
            dATE_BIRTHLabel.Location = new System.Drawing.Point(207, 94);
            dATE_BIRTHLabel.Name = "dATE_BIRTHLabel";
            dATE_BIRTHLabel.Size = new System.Drawing.Size(68, 13);
            dATE_BIRTHLabel.TabIndex = 11;
            dATE_BIRTHLabel.Text = "Дата рожд.:";
            // 
            // cONTACTLabel
            // 
            cONTACTLabel.AutoSize = true;
            cONTACTLabel.Location = new System.Drawing.Point(216, 120);
            cONTACTLabel.Name = "cONTACTLabel";
            cONTACTLabel.Size = new System.Drawing.Size(59, 13);
            cONTACTLabel.TabIndex = 13;
            cONTACTLabel.Text = "Контакты:";
            // 
            // gENDERLabel
            // 
            gENDERLabel.AutoSize = true;
            gENDERLabel.Location = new System.Drawing.Point(13, 94);
            gENDERLabel.Name = "gENDERLabel";
            gENDERLabel.Size = new System.Drawing.Size(30, 13);
            gENDERLabel.TabIndex = 14;
            gENDERLabel.Text = "Пол:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTOMERSBindingSource
            // 
            this.cUSTOMERSBindingSource.DataMember = "CUSTOMERS";
            this.cUSTOMERSBindingSource.DataSource = this.dataSet1;
            // 
            // cUSTOMERSTableAdapter
            // 
            this.cUSTOMERSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ABONEMENTSTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CUSTOMERSTableAdapter = this.cUSTOMERSTableAdapter;
            this.tableAdapterManager.RECORDSTableAdapter = null;
            this.tableAdapterManager.ROOMSTableAdapter = null;
            this.tableAdapterManager.SECTIONSTableAdapter = null;
            this.tableAdapterManager.SPORTSESSIONSTableAdapter = null;
            this.tableAdapterManager.SPORTUSERSTableAdapter = null;
            this.tableAdapterManager.TIMETABLETableAdapter = null;
            this.tableAdapterManager.TRAINERSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KP_Sportzal_DescApp.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cUSTOMERSBindingNavigator
            // 
            this.cUSTOMERSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cUSTOMERSBindingNavigator.BindingSource = this.cUSTOMERSBindingSource;
            this.cUSTOMERSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cUSTOMERSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cUSTOMERSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cUSTOMERSBindingNavigatorSaveItem});
            this.cUSTOMERSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cUSTOMERSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cUSTOMERSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cUSTOMERSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cUSTOMERSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cUSTOMERSBindingNavigator.Name = "cUSTOMERSBindingNavigator";
            this.cUSTOMERSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cUSTOMERSBindingNavigator.Size = new System.Drawing.Size(623, 25);
            this.cUSTOMERSBindingNavigator.TabIndex = 0;
            this.cUSTOMERSBindingNavigator.Text = "bindingNavigator1";
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
            // cUSTOMERSBindingNavigatorSaveItem
            // 
            this.cUSTOMERSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cUSTOMERSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cUSTOMERSBindingNavigatorSaveItem.Image")));
            this.cUSTOMERSBindingNavigatorSaveItem.Name = "cUSTOMERSBindingNavigatorSaveItem";
            this.cUSTOMERSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cUSTOMERSBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.cUSTOMERSBindingNavigatorSaveItem.Click += new System.EventHandler(this.cUSTOMERSBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERSBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(75, 35);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(60, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // sURNAMETextBox
            // 
            this.sURNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERSBindingSource, "SURNAME", true));
            this.sURNAMETextBox.Location = new System.Drawing.Point(75, 61);
            this.sURNAMETextBox.Name = "sURNAMETextBox";
            this.sURNAMETextBox.Size = new System.Drawing.Size(153, 20);
            this.sURNAMETextBox.TabIndex = 4;
            // 
            // nAMETextBox
            // 
            this.nAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERSBindingSource, "NAME", true));
            this.nAMETextBox.Location = new System.Drawing.Point(281, 61);
            this.nAMETextBox.Name = "nAMETextBox";
            this.nAMETextBox.Size = new System.Drawing.Size(145, 20);
            this.nAMETextBox.TabIndex = 6;
            // 
            // pATRONYMICTextBox
            // 
            this.pATRONYMICTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERSBindingSource, "PATRONYMIC", true));
            this.pATRONYMICTextBox.Location = new System.Drawing.Point(495, 61);
            this.pATRONYMICTextBox.Name = "pATRONYMICTextBox";
            this.pATRONYMICTextBox.Size = new System.Drawing.Size(119, 20);
            this.pATRONYMICTextBox.TabIndex = 8;
            // 
            // dATE_BIRTHDateTimePicker
            // 
            this.dATE_BIRTHDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cUSTOMERSBindingSource, "DATE_BIRTH", true));
            this.dATE_BIRTHDateTimePicker.Location = new System.Drawing.Point(281, 91);
            this.dATE_BIRTHDateTimePicker.Name = "dATE_BIRTHDateTimePicker";
            this.dATE_BIRTHDateTimePicker.Size = new System.Drawing.Size(333, 20);
            this.dATE_BIRTHDateTimePicker.TabIndex = 12;
            this.dATE_BIRTHDateTimePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // cONTACTTextBox
            // 
            this.cONTACTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERSBindingSource, "CONTACT", true));
            this.cONTACTTextBox.Location = new System.Drawing.Point(281, 117);
            this.cONTACTTextBox.Multiline = true;
            this.cONTACTTextBox.Name = "cONTACTTextBox";
            this.cONTACTTextBox.Size = new System.Drawing.Size(333, 38);
            this.cONTACTTextBox.TabIndex = 14;
            // 
            // gENDERComboBox
            // 
            this.gENDERComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERSBindingSource, "GENDER", true));
            this.gENDERComboBox.FormattingEnabled = true;
            this.gENDERComboBox.Items.AddRange(new object[] {
            "м",
            "ж"});
            this.gENDERComboBox.Location = new System.Drawing.Point(75, 91);
            this.gENDERComboBox.Name = "gENDERComboBox";
            this.gENDERComboBox.Size = new System.Drawing.Size(60, 21);
            this.gENDERComboBox.TabIndex = 15;
            // 
            // FormAddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 167);
            this.Controls.Add(gENDERLabel);
            this.Controls.Add(this.gENDERComboBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(sURNAMELabel);
            this.Controls.Add(this.sURNAMETextBox);
            this.Controls.Add(nAMELabel);
            this.Controls.Add(this.nAMETextBox);
            this.Controls.Add(pATRONYMICLabel);
            this.Controls.Add(this.pATRONYMICTextBox);
            this.Controls.Add(dATE_BIRTHLabel);
            this.Controls.Add(this.dATE_BIRTHDateTimePicker);
            this.Controls.Add(cONTACTLabel);
            this.Controls.Add(this.cONTACTTextBox);
            this.Controls.Add(this.cUSTOMERSBindingNavigator);
            this.Name = "FormAddClient";
            this.Text = "Клиент";
            this.Load += new System.EventHandler(this.FormAddClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSBindingNavigator)).EndInit();
            this.cUSTOMERSBindingNavigator.ResumeLayout(false);
            this.cUSTOMERSBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cUSTOMERSBindingSource;
        private DataSet1TableAdapters.CUSTOMERSTableAdapter cUSTOMERSTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cUSTOMERSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cUSTOMERSBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox sURNAMETextBox;
        private System.Windows.Forms.TextBox nAMETextBox;
        private System.Windows.Forms.TextBox pATRONYMICTextBox;
        private System.Windows.Forms.DateTimePicker dATE_BIRTHDateTimePicker;
        private System.Windows.Forms.TextBox cONTACTTextBox;
        private System.Windows.Forms.ComboBox gENDERComboBox;
    }
}