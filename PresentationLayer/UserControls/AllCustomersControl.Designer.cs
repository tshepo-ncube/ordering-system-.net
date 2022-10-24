
namespace NavigationView.UserControls
{
    partial class AllCustomersControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.customer_search_txt = new System.Windows.Forms.TextBox();
            this.database1DataSet1 = new NavigationView.Database1DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "all customers ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(132, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 14);
            this.label8.TabIndex = 22;
            this.label8.Text = "Search : ";
            // 
            // customer_search_txt
            // 
            this.customer_search_txt.Location = new System.Drawing.Point(183, 73);
            this.customer_search_txt.Name = "customer_search_txt";
            this.customer_search_txt.Size = new System.Drawing.Size(298, 20);
            this.customer_search_txt.TabIndex = 21;
            this.customer_search_txt.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(558, 299);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(487, 71);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(95, 23);
            this.searchBtn.TabIndex = 24;
            this.searchBtn.Text = "search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // AllCustomersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.customer_search_txt);
            this.Controls.Add(this.label1);
            this.Name = "AllCustomersControl";
            this.Size = new System.Drawing.Size(846, 583);
            this.Load += new System.EventHandler(this.AllCustomersControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox customer_search_txt;
        private Database1DataSet database1DataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button searchBtn;
    }
}
