
namespace NavigationView.UserControls
{
    partial class AllOrdersControl
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
            this.label8 = new System.Windows.Forms.Label();
            this.order_search_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.order_datagridview = new System.Windows.Forms.DataGridView();
            this.database1DataSet3 = new NavigationView.Database1DataSet3();
            this.database1DataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clearOrders = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchBtn_txt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.order_datagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 14);
            this.label8.TabIndex = 38;
            this.label8.Text = "Search orderID : ";
            // 
            // order_search_txt
            // 
            this.order_search_txt.Location = new System.Drawing.Point(115, 78);
            this.order_search_txt.Name = "order_search_txt";
            this.order_search_txt.Size = new System.Drawing.Size(298, 20);
            this.order_search_txt.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 35;
            this.label2.Text = "All Orders";
            // 
            // order_datagridview
            // 
            this.order_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.order_datagridview.Location = new System.Drawing.Point(42, 140);
            this.order_datagridview.Name = "order_datagridview";
            this.order_datagridview.Size = new System.Drawing.Size(536, 157);
            this.order_datagridview.TabIndex = 41;
            this.order_datagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.order_datagridview_CellContentClick);
            // 
            // database1DataSet3
            // 
            this.database1DataSet3.DataSetName = "Database1DataSet3";
            this.database1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSet3BindingSource
            // 
            this.database1DataSet3BindingSource.DataSource = this.database1DataSet3;
            this.database1DataSet3BindingSource.Position = 0;
            // 
            // clearOrders
            // 
            this.clearOrders.Location = new System.Drawing.Point(545, 78);
            this.clearOrders.Name = "clearOrders";
            this.clearOrders.Size = new System.Drawing.Size(120, 23);
            this.clearOrders.TabIndex = 42;
            this.clearOrders.Text = "Clear all orders";
            this.clearOrders.UseVisualStyleBackColor = true;
            this.clearOrders.Click += new System.EventHandler(this.clearOrders_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 367);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(334, 201);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "All Orders";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "All Order Items";
            // 
            // searchBtn_txt
            // 
            this.searchBtn_txt.Location = new System.Drawing.Point(419, 78);
            this.searchBtn_txt.Name = "searchBtn_txt";
            this.searchBtn_txt.Size = new System.Drawing.Size(120, 23);
            this.searchBtn_txt.TabIndex = 46;
            this.searchBtn_txt.Text = "search";
            this.searchBtn_txt.UseVisualStyleBackColor = true;
            this.searchBtn_txt.Click += new System.EventHandler(this.searchBtn_txt_Click);
            // 
            // AllOrdersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchBtn_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.clearOrders);
            this.Controls.Add(this.order_datagridview);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.order_search_txt);
            this.Controls.Add(this.label2);
            this.Name = "AllOrdersControl";
            this.Size = new System.Drawing.Size(846, 583);
            this.Load += new System.EventHandler(this.AllOrdersControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.order_datagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox order_search_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView order_datagridview;
        private System.Windows.Forms.BindingSource database1DataSet3BindingSource;
        private Database1DataSet3 database1DataSet3;
        private System.Windows.Forms.Button clearOrders;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button searchBtn_txt;
    }
}
