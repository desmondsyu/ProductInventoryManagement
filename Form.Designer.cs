namespace ProductInventoryManagement
{
    partial class Form
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
            label1 = new Label();
            txtSearchName = new TextBox();
            listBoxProducts = new ListBox();
            btnSearch = new Button();
            btnClear = new Button();
            btnAdd = new Button();
            groupBox1 = new GroupBox();
            txtCheapest = new TextBox();
            label3 = new Label();
            txtAvgPrice = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btnClearAdd = new Button();
            btnSave = new Button();
            txtPrice = new TextBox();
            txtQty = new TextBox();
            txtName = new TextBox();
            txtID = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(50, 54);
            label1.Name = "label1";
            label1.Size = new Size(62, 24);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // txtSearchName
            // 
            txtSearchName.BorderStyle = BorderStyle.FixedSingle;
            txtSearchName.Location = new Point(173, 51);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(169, 30);
            txtSearchName.TabIndex = 1;
            txtSearchName.TextChanged += txtSearchName_TextChanged;
            // 
            // listBoxProducts
            // 
            listBoxProducts.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.ItemHeight = 24;
            listBoxProducts.Location = new Point(50, 112);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(665, 460);
            listBoxProducts.TabIndex = 2;
            listBoxProducts.SelectedIndexChanged += listBoxProducts_SelectedIndexChanged;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnSearch.Location = new Point(440, 49);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnClear.Location = new Point(564, 49);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(957, 891);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCheapest);
            groupBox1.Controls.Add(txtSearchName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(txtAvgPrice);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(listBoxProducts);
            groupBox1.Location = new Point(26, 328);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(771, 680);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Product";
            // 
            // txtCheapest
            // 
            txtCheapest.Location = new Point(211, 639);
            txtCheapest.Name = "txtCheapest";
            txtCheapest.ReadOnly = true;
            txtCheapest.Size = new Size(503, 30);
            txtCheapest.TabIndex = 9;
            txtCheapest.TextChanged += txtCheapest_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 639);
            label3.Name = "label3";
            label3.Size = new Size(99, 24);
            label3.TabIndex = 8;
            label3.Text = "Cheapest: ";
            label3.Click += label3_Click;
            // 
            // txtAvgPrice
            // 
            txtAvgPrice.Location = new Point(211, 594);
            txtAvgPrice.Name = "txtAvgPrice";
            txtAvgPrice.ReadOnly = true;
            txtAvgPrice.Size = new Size(203, 30);
            txtAvgPrice.TabIndex = 7;
            txtAvgPrice.TextChanged += txtAvgPrice_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 597);
            label2.Name = "label2";
            label2.Size = new Size(137, 24);
            label2.TabIndex = 6;
            label2.Text = "Average Price: ";
            label2.Click += label2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnClearAdd);
            groupBox2.Controls.Add(btnSave);
            groupBox2.Controls.Add(txtPrice);
            groupBox2.Controls.Add(txtQty);
            groupBox2.Controls.Add(txtName);
            groupBox2.Controls.Add(txtID);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(26, 68);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(771, 232);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add Product";
            // 
            // btnClearAdd
            // 
            btnClearAdd.Location = new Point(564, 174);
            btnClearAdd.Name = "btnClearAdd";
            btnClearAdd.Size = new Size(112, 34);
            btnClearAdd.TabIndex = 20;
            btnClearAdd.Text = "Clear";
            btnClearAdd.UseVisualStyleBackColor = true;
            btnClearAdd.Click += btnClearAdd_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(440, 174);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 19;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Location = new Point(564, 103);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 30);
            txtPrice.TabIndex = 18;
            // 
            // txtQty
            // 
            txtQty.BorderStyle = BorderStyle.FixedSingle;
            txtQty.Location = new Point(173, 103);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(150, 30);
            txtQty.TabIndex = 17;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(564, 55);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 30);
            txtName.TabIndex = 16;
            // 
            // txtID
            // 
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Location = new Point(173, 55);
            txtID.Name = "txtID";
            txtID.Size = new Size(150, 30);
            txtID.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(440, 106);
            label4.Name = "label4";
            label4.Size = new Size(52, 24);
            label4.TabIndex = 14;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 106);
            label5.Name = "label5";
            label5.Size = new Size(86, 24);
            label5.TabIndex = 13;
            label5.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(440, 58);
            label6.Name = "label6";
            label6.Size = new Size(62, 24);
            label6.TabIndex = 12;
            label6.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(50, 55);
            label7.Name = "label7";
            label7.Size = new Size(29, 24);
            label7.TabIndex = 11;
            label7.Text = "ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(212, 23);
            label8.Name = "label8";
            label8.Size = new Size(0, 24);
            label8.TabIndex = 7;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 1020);
            Controls.Add(label8);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnAdd);
            Name = "Form";
            Text = "Product Management System";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSearchName;
        private Label label1;
        private Button btnSearch;
        private ListBox listBoxProducts;
        private Button btnClear;
        private Button btnAdd;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtAvgPrice;
        private Label label3;
        private TextBox txtCheapest;
        private GroupBox groupBox2;
        private Button btnSave;
        private TextBox txtPrice;
        private TextBox txtQty;
        private TextBox txtName;
        private TextBox txtID;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnClearAdd;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label8;
    }
}