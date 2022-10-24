
namespace NavigationView.UserControls
{
    partial class InventoryControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.inventoryDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Inventory";
            // 
            // inventoryDataGridView
            // 
            this.inventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryDataGridView.Location = new System.Drawing.Point(31, 79);
            this.inventoryDataGridView.Name = "inventoryDataGridView";
            this.inventoryDataGridView.Size = new System.Drawing.Size(694, 288);
            this.inventoryDataGridView.TabIndex = 19;
            this.inventoryDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryDataGridView_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "print expired products";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 442);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(694, 109);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // InventoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inventoryDataGridView);
            this.Controls.Add(this.label2);
            this.Name = "InventoryControl";
            this.Size = new System.Drawing.Size(846, 583);
            this.Load += new System.EventHandler(this.InventoryControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView inventoryDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
