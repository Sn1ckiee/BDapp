namespace BDapp.Views
{
    partial class WellView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageWellList = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPageWellDetail = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAdditionalInfo = new System.Windows.Forms.TextBox();
            this.txtFilesLocation = new System.Windows.Forms.TextBox();
            this.txtBatchOperator = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtContractor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLicenseHolder = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInstrumentType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCluster = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWellId = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageWellList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageWellDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 42);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Скважины";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageWellList);
            this.tabControl1.Controls.Add(this.tabPageWellDetail);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 408);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageWellList
            // 
            this.tabPageWellList.Controls.Add(this.label14);
            this.tabPageWellList.Controls.Add(this.txtSearch);
            this.tabPageWellList.Controls.Add(this.btnDelete);
            this.tabPageWellList.Controls.Add(this.btnEdit);
            this.tabPageWellList.Controls.Add(this.btnAddNew);
            this.tabPageWellList.Controls.Add(this.btnSearch);
            this.tabPageWellList.Controls.Add(this.dataGridView1);
            this.tabPageWellList.Location = new System.Drawing.Point(4, 22);
            this.tabPageWellList.Name = "tabPageWellList";
            this.tabPageWellList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWellList.Size = new System.Drawing.Size(792, 382);
            this.tabPageWellList.TabIndex = 0;
            this.tabPageWellList.Text = "Список скважин";
            this.tabPageWellList.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Искать скважину";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(11, 34);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(578, 20);
            this.txtSearch.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(700, 127);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(700, 98);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.Location = new System.Drawing.Point(700, 69);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "Добавить";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(606, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(670, 303);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPageWellDetail
            // 
            this.tabPageWellDetail.Controls.Add(this.btnCancel);
            this.tabPageWellDetail.Controls.Add(this.btnSave);
            this.tabPageWellDetail.Controls.Add(this.label13);
            this.tabPageWellDetail.Controls.Add(this.label12);
            this.tabPageWellDetail.Controls.Add(this.label11);
            this.tabPageWellDetail.Controls.Add(this.txtAdditionalInfo);
            this.tabPageWellDetail.Controls.Add(this.txtFilesLocation);
            this.tabPageWellDetail.Controls.Add(this.txtBatchOperator);
            this.tabPageWellDetail.Controls.Add(this.label10);
            this.tabPageWellDetail.Controls.Add(this.txtContractor);
            this.tabPageWellDetail.Controls.Add(this.label9);
            this.tabPageWellDetail.Controls.Add(this.txtCustomer);
            this.tabPageWellDetail.Controls.Add(this.txtUser);
            this.tabPageWellDetail.Controls.Add(this.label8);
            this.tabPageWellDetail.Controls.Add(this.label7);
            this.tabPageWellDetail.Controls.Add(this.txtLicenseHolder);
            this.tabPageWellDetail.Controls.Add(this.label6);
            this.tabPageWellDetail.Controls.Add(this.txtInstrumentType);
            this.tabPageWellDetail.Controls.Add(this.label5);
            this.tabPageWellDetail.Controls.Add(this.txtCluster);
            this.tabPageWellDetail.Controls.Add(this.txtArea);
            this.tabPageWellDetail.Controls.Add(this.label4);
            this.tabPageWellDetail.Controls.Add(this.txtNumber);
            this.tabPageWellDetail.Controls.Add(this.label3);
            this.tabPageWellDetail.Controls.Add(this.label2);
            this.tabPageWellDetail.Controls.Add(this.txtWellId);
            this.tabPageWellDetail.Location = new System.Drawing.Point(4, 22);
            this.tabPageWellDetail.Name = "tabPageWellDetail";
            this.tabPageWellDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWellDetail.Size = new System.Drawing.Size(792, 360);
            this.tabPageWellDetail.TabIndex = 1;
            this.tabPageWellDetail.Text = "Детали списка";
            this.tabPageWellDetail.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(709, 345);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 347);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(702, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "txtAdditionalInfo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(328, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "txtFilesLocation";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "txtBatchOperator";
            // 
            // txtAdditionalInfo
            // 
            this.txtAdditionalInfo.Location = new System.Drawing.Point(684, 160);
            this.txtAdditionalInfo.Name = "txtAdditionalInfo";
            this.txtAdditionalInfo.Size = new System.Drawing.Size(100, 20);
            this.txtAdditionalInfo.TabIndex = 20;
            // 
            // txtFilesLocation
            // 
            this.txtFilesLocation.Location = new System.Drawing.Point(319, 160);
            this.txtFilesLocation.Name = "txtFilesLocation";
            this.txtFilesLocation.Size = new System.Drawing.Size(100, 20);
            this.txtFilesLocation.TabIndex = 19;
            // 
            // txtBatchOperator
            // 
            this.txtBatchOperator.Location = new System.Drawing.Point(3, 160);
            this.txtBatchOperator.Name = "txtBatchOperator";
            this.txtBatchOperator.Size = new System.Drawing.Size(100, 20);
            this.txtBatchOperator.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(717, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "txtContractor";
            // 
            // txtContractor
            // 
            this.txtContractor.Location = new System.Drawing.Point(684, 121);
            this.txtContractor.Name = "txtContractor";
            this.txtContractor.Size = new System.Drawing.Size(100, 20);
            this.txtContractor.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(340, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "txtCustomer";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(319, 121);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtCustomer.TabIndex = 14;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(3, 121);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 13;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "txtUser";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(698, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "txtLicenseHolder";
            // 
            // txtLicenseHolder
            // 
            this.txtLicenseHolder.Location = new System.Drawing.Point(684, 82);
            this.txtLicenseHolder.Name = "txtLicenseHolder";
            this.txtLicenseHolder.Size = new System.Drawing.Size(100, 20);
            this.txtLicenseHolder.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "txtInstrumentType";
            // 
            // txtInstrumentType
            // 
            this.txtInstrumentType.Location = new System.Drawing.Point(319, 82);
            this.txtInstrumentType.Name = "txtInstrumentType";
            this.txtInstrumentType.Size = new System.Drawing.Size(100, 20);
            this.txtInstrumentType.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cluster";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtCluster
            // 
            this.txtCluster.Location = new System.Drawing.Point(3, 82);
            this.txtCluster.Name = "txtCluster";
            this.txtCluster.Size = new System.Drawing.Size(100, 20);
            this.txtCluster.TabIndex = 6;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(684, 43);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(755, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Area";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(319, 43);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Well Id";
            // 
            // txtWellId
            // 
            this.txtWellId.Location = new System.Drawing.Point(3, 43);
            this.txtWellId.Name = "txtWellId";
            this.txtWellId.Size = new System.Drawing.Size(100, 20);
            this.txtWellId.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(770, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // WellView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "WellView";
            this.Text = "Скважины";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageWellList.ResumeLayout(false);
            this.tabPageWellList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageWellDetail.ResumeLayout(false);
            this.tabPageWellDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageWellList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPageWellDetail;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtWellId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCluster;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInstrumentType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLicenseHolder;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtContractor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAdditionalInfo;
        private System.Windows.Forms.TextBox txtFilesLocation;
        private System.Windows.Forms.TextBox txtBatchOperator;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnClose;
    }
}