namespace AdminBanHang.GUI
{
    partial class LapDonHang
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
            this.listViewData = new System.Windows.Forms.ListView();
            this.listViewSelect = new System.Windows.Forms.ListView();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnGiamSl = new System.Windows.Forms.Button();
            this.groupBoxProduct = new System.Windows.Forms.GroupBox();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.radioCombo = new System.Windows.Forms.RadioButton();
            this.radioProduct = new System.Windows.Forms.RadioButton();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.btnResetProduct = new System.Windows.Forms.Button();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.panelCombo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.btnResetCombo = new System.Windows.Forms.Button();
            this.btnSearchCombo = new System.Windows.Forms.Button();
            this.txtSeachCombo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtThanhtien = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnKhach = new System.Windows.Forms.Button();
            this.groupBoxProduct.SuspendLayout();
            this.panelProduct.SuspendLayout();
            this.panelCombo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewData
            // 
            this.listViewData.HideSelection = false;
            this.listViewData.Location = new System.Drawing.Point(12, 135);
            this.listViewData.Name = "listViewData";
            this.listViewData.Size = new System.Drawing.Size(515, 297);
            this.listViewData.TabIndex = 0;
            this.listViewData.UseCompatibleStateImageBehavior = false;
            this.listViewData.Click += new System.EventHandler(this.Listview_click);
            // 
            // listViewSelect
            // 
            this.listViewSelect.HideSelection = false;
            this.listViewSelect.Location = new System.Drawing.Point(590, 135);
            this.listViewSelect.Name = "listViewSelect";
            this.listViewSelect.Size = new System.Drawing.Size(374, 297);
            this.listViewSelect.TabIndex = 0;
            this.listViewSelect.UseCompatibleStateImageBehavior = false;
            this.listViewSelect.Click += new System.EventHandler(this.listView_select_click);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(533, 215);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(51, 36);
            this.btnMove.TabIndex = 1;
            this.btnMove.Text = "Add";
            this.btnMove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnGiamSl
            // 
            this.btnGiamSl.Location = new System.Drawing.Point(533, 257);
            this.btnGiamSl.Name = "btnGiamSl";
            this.btnGiamSl.Size = new System.Drawing.Size(51, 36);
            this.btnGiamSl.TabIndex = 1;
            this.btnGiamSl.Text = "Delete";
            this.btnGiamSl.UseVisualStyleBackColor = true;
            this.btnGiamSl.Click += new System.EventHandler(this.btnGiamSl_Click);
            // 
            // groupBoxProduct
            // 
            this.groupBoxProduct.Controls.Add(this.panelSearch);
            this.groupBoxProduct.Location = new System.Drawing.Point(12, 12);
            this.groupBoxProduct.Name = "groupBoxProduct";
            this.groupBoxProduct.Size = new System.Drawing.Size(515, 94);
            this.groupBoxProduct.TabIndex = 6;
            this.groupBoxProduct.TabStop = false;
            this.groupBoxProduct.Tag = "";
            this.groupBoxProduct.Text = "Product research";
            // 
            // panelSearch
            // 
            this.panelSearch.Location = new System.Drawing.Point(6, 16);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(503, 71);
            this.panelSearch.TabIndex = 20;
            // 
            // radioCombo
            // 
            this.radioCombo.AutoSize = true;
            this.radioCombo.Location = new System.Drawing.Point(80, 112);
            this.radioCombo.Name = "radioCombo";
            this.radioCombo.Size = new System.Drawing.Size(58, 17);
            this.radioCombo.TabIndex = 7;
            this.radioCombo.Text = "Combo";
            this.radioCombo.UseVisualStyleBackColor = true;
            // 
            // radioProduct
            // 
            this.radioProduct.AutoSize = true;
            this.radioProduct.Checked = true;
            this.radioProduct.Location = new System.Drawing.Point(12, 112);
            this.radioProduct.Name = "radioProduct";
            this.radioProduct.Size = new System.Drawing.Size(62, 17);
            this.radioProduct.TabIndex = 8;
            this.radioProduct.TabStop = true;
            this.radioProduct.Text = "Product";
            this.radioProduct.UseVisualStyleBackColor = true;
            this.radioProduct.CheckedChanged += new System.EventHandler(this.radioProduct_CheckedChanged);
            // 
            // panelProduct
            // 
            this.panelProduct.Controls.Add(this.label5);
            this.panelProduct.Controls.Add(this.label4);
            this.panelProduct.Controls.Add(this.label3);
            this.panelProduct.Controls.Add(this.comboBoxType);
            this.panelProduct.Controls.Add(this.btnResetProduct);
            this.panelProduct.Controls.Add(this.btnSearchProduct);
            this.panelProduct.Controls.Add(this.comboBoxBrand);
            this.panelProduct.Controls.Add(this.txtSearchProduct);
            this.panelProduct.Location = new System.Drawing.Point(550, 479);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(503, 71);
            this.panelProduct.TabIndex = 0;
            this.panelProduct.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Company";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Input";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(76, 44);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(111, 21);
            this.comboBoxType.TabIndex = 12;
            // 
            // btnResetProduct
            // 
            this.btnResetProduct.Location = new System.Drawing.Point(419, 42);
            this.btnResetProduct.Name = "btnResetProduct";
            this.btnResetProduct.Size = new System.Drawing.Size(75, 23);
            this.btnResetProduct.TabIndex = 15;
            this.btnResetProduct.Text = "Reset";
            this.btnResetProduct.UseVisualStyleBackColor = true;
            this.btnResetProduct.Click += new System.EventHandler(this.btnResetProduct_Click_1);
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Location = new System.Drawing.Point(419, 6);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(75, 23);
            this.btnSearchProduct.TabIndex = 16;
            this.btnSearchProduct.Text = "Search";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click_1);
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new System.Drawing.Point(268, 44);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBrand.TabIndex = 13;
            this.comboBoxBrand.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrand_SelectedIndexChanged);
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Location = new System.Drawing.Point(76, 8);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(313, 20);
            this.txtSearchProduct.TabIndex = 14;
            // 
            // panelCombo
            // 
            this.panelCombo.Controls.Add(this.label2);
            this.panelCombo.Controls.Add(this.label1);
            this.panelCombo.Controls.Add(this.dateEnd);
            this.panelCombo.Controls.Add(this.dateStart);
            this.panelCombo.Controls.Add(this.btnResetCombo);
            this.panelCombo.Controls.Add(this.btnSearchCombo);
            this.panelCombo.Controls.Add(this.txtSeachCombo);
            this.panelCombo.Location = new System.Drawing.Point(24, 479);
            this.panelCombo.Name = "panelCombo";
            this.panelCombo.Size = new System.Drawing.Size(503, 71);
            this.panelCombo.TabIndex = 9;
            this.panelCombo.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Date end";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Date begin";
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(76, 44);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 20);
            this.dateEnd.TabIndex = 12;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(76, 7);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 20);
            this.dateStart.TabIndex = 13;
            // 
            // btnResetCombo
            // 
            this.btnResetCombo.Location = new System.Drawing.Point(402, 40);
            this.btnResetCombo.Name = "btnResetCombo";
            this.btnResetCombo.Size = new System.Drawing.Size(92, 23);
            this.btnResetCombo.TabIndex = 10;
            this.btnResetCombo.Text = "Reset";
            this.btnResetCombo.UseVisualStyleBackColor = true;
            this.btnResetCombo.Click += new System.EventHandler(this.btnResetCombo_Click_1);
            // 
            // btnSearchCombo
            // 
            this.btnSearchCombo.Location = new System.Drawing.Point(298, 40);
            this.btnSearchCombo.Name = "btnSearchCombo";
            this.btnSearchCombo.Size = new System.Drawing.Size(92, 23);
            this.btnSearchCombo.TabIndex = 11;
            this.btnSearchCombo.Text = "Search";
            this.btnSearchCombo.UseVisualStyleBackColor = true;
            this.btnSearchCombo.Click += new System.EventHandler(this.btnSearchCombo_Click_1);
            // 
            // txtSeachCombo
            // 
            this.txtSeachCombo.Location = new System.Drawing.Point(298, 7);
            this.txtSeachCombo.Name = "txtSeachCombo";
            this.txtSeachCombo.Size = new System.Drawing.Size(196, 20);
            this.txtSeachCombo.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtThanhtien);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnKhach);
            this.groupBox1.Location = new System.Drawing.Point(590, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 94);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "";
            this.groupBox1.Text = "Function";
            // 
            // txtThanhtien
            // 
            this.txtThanhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhtien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtThanhtien.Location = new System.Drawing.Point(181, 15);
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.ReadOnly = true;
            this.txtThanhtien.Size = new System.Drawing.Size(183, 29);
            this.txtThanhtien.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(181, 50);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(183, 29);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Create Invoice";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnKhach
            // 
            this.btnKhach.Location = new System.Drawing.Point(12, 15);
            this.btnKhach.Name = "btnKhach";
            this.btnKhach.Size = new System.Drawing.Size(163, 64);
            this.btnKhach.TabIndex = 4;
            this.btnKhach.Text = "Customer Detail";
            this.btnKhach.UseVisualStyleBackColor = true;
            this.btnKhach.Click += new System.EventHandler(this.btnKhach_Click_1);
            // 
            // LapDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 541);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelProduct);
            this.Controls.Add(this.panelCombo);
            this.Controls.Add(this.radioProduct);
            this.Controls.Add(this.radioCombo);
            this.Controls.Add(this.groupBoxProduct);
            this.Controls.Add(this.btnGiamSl);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.listViewSelect);
            this.Controls.Add(this.listViewData);
            this.Name = "LapDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Order";
            this.groupBoxProduct.ResumeLayout(false);
            this.panelProduct.ResumeLayout(false);
            this.panelProduct.PerformLayout();
            this.panelCombo.ResumeLayout(false);
            this.panelCombo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewData;
        private System.Windows.Forms.ListView listViewSelect;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnGiamSl;
        private System.Windows.Forms.GroupBox groupBoxProduct;
        private System.Windows.Forms.RadioButton radioCombo;
        private System.Windows.Forms.RadioButton radioProduct;
        private System.Windows.Forms.Panel panelProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button btnResetProduct;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Panel panelCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Button btnResetCombo;
        private System.Windows.Forms.Button btnSearchCombo;
        private System.Windows.Forms.TextBox txtSeachCombo;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtThanhtien;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnKhach;
    }
}