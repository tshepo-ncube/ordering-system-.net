
namespace NavigationView.UserControls
{
    partial class CreateInventory
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
            this.label5 = new System.Windows.Forms.Label();
            this.quantity_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.unit_price_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.product_name_txt = new System.Windows.Forms.TextBox();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.expiry_dateview = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(210, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 14);
            this.label5.TabIndex = 35;
            this.label5.Text = "Quantity : ";
            // 
            // quantity_txt
            // 
            this.quantity_txt.Location = new System.Drawing.Point(277, 240);
            this.quantity_txt.Name = "quantity_txt";
            this.quantity_txt.Size = new System.Drawing.Size(100, 20);
            this.quantity_txt.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(210, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 14);
            this.label4.TabIndex = 33;
            this.label4.Text = "Unit price : ";
            // 
            // unit_price_txt
            // 
            this.unit_price_txt.Location = new System.Drawing.Point(277, 214);
            this.unit_price_txt.Name = "unit_price_txt";
            this.unit_price_txt.Size = new System.Drawing.Size(100, 20);
            this.unit_price_txt.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 14);
            this.label3.TabIndex = 31;
            this.label3.Text = "Product Name :";
            // 
            // product_name_txt
            // 
            this.product_name_txt.Location = new System.Drawing.Point(301, 188);
            this.product_name_txt.Name = "product_name_txt";
            this.product_name_txt.Size = new System.Drawing.Size(100, 20);
            this.product_name_txt.TabIndex = 30;
            // 
            // addProductBtn
            // 
            this.addProductBtn.Location = new System.Drawing.Point(216, 338);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(193, 23);
            this.addProductBtn.TabIndex = 28;
            this.addProductBtn.Text = "Add Product";
            this.addProductBtn.UseVisualStyleBackColor = true;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Add To Inventory";
            // 
            // expiry_dateview
            // 
            this.expiry_dateview.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expiry_dateview.Location = new System.Drawing.Point(216, 299);
            this.expiry_dateview.Name = "expiry_dateview";
            this.expiry_dateview.Size = new System.Drawing.Size(197, 20);
            this.expiry_dateview.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 14);
            this.label2.TabIndex = 37;
            this.label2.Text = "Expiry date : ";
            // 
            // CreateInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.expiry_dateview);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.quantity_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.unit_price_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.product_name_txt);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.label1);
            this.Name = "CreateInventory";
            this.Size = new System.Drawing.Size(846, 583);
            this.Load += new System.EventHandler(this.CreateInventory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox quantity_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox unit_price_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox product_name_txt;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker expiry_dateview;
        private System.Windows.Forms.Label label2;
    }
}
