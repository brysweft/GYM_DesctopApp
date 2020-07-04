namespace KP_Sportzal_DescApp
{
    partial class login
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataSet1 = new KP_Sportzal_DescApp.DataSet1();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sPORTUSERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPORTUSERSTableAdapter = new KP_Sportzal_DescApp.DataSet1TableAdapters.SPORTUSERSTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.sPORTSESSIONSFK1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPORTSESSIONSTableAdapter = new KP_Sportzal_DescApp.DataSet1TableAdapters.SPORTSESSIONSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPORTUSERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPORTSESSIONSFK1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пользователь:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(185, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sPORTUSERSBindingSource, "NAME", true));
            this.comboBox1.DataSource = this.sPORTUSERSBindingSource;
            this.comboBox1.DisplayMember = "NAME";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(185, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // sPORTUSERSBindingSource
            // 
            this.sPORTUSERSBindingSource.DataMember = "SPORTUSERS";
            this.sPORTUSERSBindingSource.DataSource = this.dataSet1;
            // 
            // sPORTUSERSTableAdapter
            // 
            this.sPORTUSERSTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = " ";
            // 
            // sPORTSESSIONSFK1BindingSource
            // 
            this.sPORTSESSIONSFK1BindingSource.DataMember = "SPORTSESSIONS_FK1";
            this.sPORTSESSIONSFK1BindingSource.DataSource = this.sPORTUSERSBindingSource;
            // 
            // sPORTSESSIONSTableAdapter
            // 
            this.sPORTSESSIONSTableAdapter.ClearBeforeFill = true;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 118);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.Text = "Вход";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.login_FormClosed);
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPORTUSERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPORTSESSIONSFK1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource sPORTUSERSBindingSource;
        private DataSet1TableAdapters.SPORTUSERSTableAdapter sPORTUSERSTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource sPORTSESSIONSFK1BindingSource;
        private DataSet1TableAdapters.SPORTSESSIONSTableAdapter sPORTSESSIONSTableAdapter;
    }
}