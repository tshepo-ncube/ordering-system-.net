
namespace NavigationView.UserControls
{
    partial class CreateOrderControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.quantity_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customerID = new System.Windows.Forms.TextBox();
            this.add_order_item_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet3 = new NavigationView.Database1DataSet3();
            this.label7 = new System.Windows.Forms.Label();
            this.total_price_txt = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.completeOrderBtn = new System.Windows.Forms.Button();
            this.productsCombo = new System.Windows.Forms.ComboBox();
            this.inventoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter = new NavigationView.Database1DataSet3TableAdapters.InventoryTableAdapter();
            this.selectedProduct_txt = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.removeOrderItem_btn = new System.Windows.Forms.Button();
            this.customersTableAdapter = new NavigationView.Database1DataSet3TableAdapters.CustomersTableAdapter();
            this.orderItem_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Create order";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 14);
            this.label5.TabIndex = 34;
            this.label5.Text = "Quantity";
            // 
            // quantity_txt
            // 
            this.quantity_txt.Location = new System.Drawing.Point(105, 185);
            this.quantity_txt.Name = "quantity_txt";
            this.quantity_txt.Size = new System.Drawing.Size(100, 20);
            this.quantity_txt.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 14);
            this.label4.TabIndex = 32;
            this.label4.Text = "Product : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 30;
            this.label3.Text = "Customer ID";
            // 
            // customerID
            // 
            this.customerID.Location = new System.Drawing.Point(114, 77);
            this.customerID.Name = "customerID";
            this.customerID.Size = new System.Drawing.Size(100, 20);
            this.customerID.TabIndex = 29;
            // 
            // add_order_item_btn
            // 
            this.add_order_item_btn.Location = new System.Drawing.Point(41, 212);
            this.add_order_item_btn.Name = "add_order_item_btn";
            this.add_order_item_btn.Size = new System.Drawing.Size(193, 23);
            this.add_order_item_btn.TabIndex = 27;
            this.add_order_item_btn.Text = "Add Order Item";
            this.add_order_item_btn.UseVisualStyleBackColor = true;
            this.add_order_item_btn.Click += new System.EventHandler(this.add_order_item_btn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Add Order Item";
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.database1DataSet3;
            // 
            // database1DataSet3
            // 
            this.database1DataSet3.DataSetName = "Database1DataSet3";
            this.database1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 14);
            this.label7.TabIndex = 38;
            this.label7.Text = "Total Price :";
            // 
            // total_price_txt
            // 
            this.total_price_txt.AutoSize = true;
            this.total_price_txt.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_price_txt.Location = new System.Drawing.Point(114, 259);
            this.total_price_txt.Name = "total_price_txt";
            this.total_price_txt.Size = new System.Drawing.Size(35, 14);
            this.total_price_txt.TabIndex = 39;
            this.total_price_txt.Text = "R0.00";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(41, 292);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(755, 232);
            this.listView1.TabIndex = 40;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "OrderItem ID";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Product Name";
            this.columnHeader2.Width = 102;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity";
            this.columnHeader3.Width = 124;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price";
            this.columnHeader4.Width = 109;
            // 
            // completeOrderBtn
            // 
            this.completeOrderBtn.Location = new System.Drawing.Point(41, 530);
            this.completeOrderBtn.Name = "completeOrderBtn";
            this.completeOrderBtn.Size = new System.Drawing.Size(193, 23);
            this.completeOrderBtn.TabIndex = 41;
            this.completeOrderBtn.Text = "Complete Order";
            this.completeOrderBtn.UseVisualStyleBackColor = true;
            this.completeOrderBtn.Click += new System.EventHandler(this.completeOrderBtn_Click);
            // 
            // productsCombo
            // 
            this.productsCombo.DataSource = this.inventoryBindingSource1;
            this.productsCombo.DisplayMember = "ProductName";
            this.productsCombo.FormattingEnabled = true;
            this.productsCombo.Location = new System.Drawing.Point(100, 159);
            this.productsCombo.Name = "productsCombo";
            this.productsCombo.Size = new System.Drawing.Size(121, 21);
            this.productsCombo.TabIndex = 42;
            this.productsCombo.ValueMember = "ProductID";
            this.productsCombo.SelectedIndexChanged += new System.EventHandler(this.productsCombo_SelectedIndexChanged);
            // 
            // inventoryBindingSource1
            // 
            this.inventoryBindingSource1.DataMember = "Inventory";
            this.inventoryBindingSource1.DataSource = this.database1DataSet3;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.database1DataSet3;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // selectedProduct_txt
            // 
            this.selectedProduct_txt.AutoSize = true;
            this.selectedProduct_txt.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedProduct_txt.Location = new System.Drawing.Point(345, 259);
            this.selectedProduct_txt.Name = "selectedProduct_txt";
            this.selectedProduct_txt.Size = new System.Drawing.Size(59, 14);
            this.selectedProduct_txt.TabIndex = 46;
            this.selectedProduct_txt.Text = "selected p";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(236, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 14);
            this.label10.TabIndex = 45;
            this.label10.Text = "Selected product : ";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(508, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 20);
            this.label9.TabIndex = 66;
            this.label9.Text = "Remove Order Item";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(509, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 14);
            this.label11.TabIndex = 65;
            this.label11.Text = "OrderItem ID : ";
            // 
            // removeOrderItem_btn
            // 
            this.removeOrderItem_btn.Location = new System.Drawing.Point(512, 212);
            this.removeOrderItem_btn.Name = "removeOrderItem_btn";
            this.removeOrderItem_btn.Size = new System.Drawing.Size(193, 23);
            this.removeOrderItem_btn.TabIndex = 64;
            this.removeOrderItem_btn.Text = "Remove Item";
            this.removeOrderItem_btn.UseVisualStyleBackColor = true;
            this.removeOrderItem_btn.Click += new System.EventHandler(this.removeOrderItem_btn_Click);
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // orderItem_txt
            // 
            this.orderItem_txt.Location = new System.Drawing.Point(597, 170);
            this.orderItem_txt.Name = "orderItem_txt";
            this.orderItem_txt.Size = new System.Drawing.Size(100, 20);
            this.orderItem_txt.TabIndex = 67;
            // 
            // CreateOrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.orderItem_txt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.removeOrderItem_btn);
            this.Controls.Add(this.selectedProduct_txt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.productsCombo);
            this.Controls.Add(this.completeOrderBtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.total_price_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.quantity_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customerID);
            this.Controls.Add(this.add_order_item_btn);
            this.Controls.Add(this.label1);
            this.Name = "CreateOrderControl";
            this.Size = new System.Drawing.Size(846, 583);
            this.Load += new System.EventHandler(this.CreateOrderControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox quantity_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customerID;
        private System.Windows.Forms.Button add_order_item_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label total_price_txt;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button completeOrderBtn;
        private System.Windows.Forms.ComboBox productsCombo;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private Database1DataSet3 database1DataSet3;
        private Database1DataSet3TableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.BindingSource inventoryBindingSource1;
        private System.Windows.Forms.Label selectedProduct_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button removeOrderItem_btn;
        private Database1DataSet3TableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox orderItem_txt;
    }
}
