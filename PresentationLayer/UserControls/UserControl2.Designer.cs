namespace NavigationView.UserControls
{
    partial class UserControl2
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
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 14);
            this.label8.TabIndex = 34;
            this.label8.Text = "Search order : ";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(111, 63);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(298, 20);
            this.textBox5.TabIndex = 33;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(27, 94);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(579, 306);
            this.listView1.TabIndex = 31;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "All Orders";
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(614, 450);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
    }
}
