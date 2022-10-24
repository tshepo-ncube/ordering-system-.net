
namespace NavigationView.UserControls
{
    partial class CreateCustomer
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
            this.label6 = new System.Windows.Forms.Label();
            this.address_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.surname_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.blacklisted_checkbox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create customer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(188, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 14);
            this.label6.TabIndex = 26;
            this.label6.Text = "Address  : ";
            // 
            // address_txt
            // 
            this.address_txt.Location = new System.Drawing.Point(255, 239);
            this.address_txt.Name = "address_txt";
            this.address_txt.Size = new System.Drawing.Size(100, 20);
            this.address_txt.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(188, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 14);
            this.label5.TabIndex = 24;
            this.label5.Text = "Phone  : ";
            // 
            // phone_txt
            // 
            this.phone_txt.Location = new System.Drawing.Point(255, 187);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(100, 20);
            this.phone_txt.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(188, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 14);
            this.label4.TabIndex = 22;
            this.label4.Text = "Surname : ";
            // 
            // surname_txt
            // 
            this.surname_txt.Location = new System.Drawing.Point(255, 161);
            this.surname_txt.Name = "surname_txt";
            this.surname_txt.Size = new System.Drawing.Size(100, 20);
            this.surname_txt.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 14);
            this.label3.TabIndex = 20;
            this.label3.Text = "Name : ";
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(239, 135);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(100, 20);
            this.name_txt.TabIndex = 19;
            this.name_txt.TextChanged += new System.EventHandler(this.name_txt_TextChanged);
            // 
            // blacklisted_checkbox
            // 
            this.blacklisted_checkbox.AutoSize = true;
            this.blacklisted_checkbox.Location = new System.Drawing.Point(191, 213);
            this.blacklisted_checkbox.Name = "blacklisted_checkbox";
            this.blacklisted_checkbox.Size = new System.Drawing.Size(76, 17);
            this.blacklisted_checkbox.TabIndex = 17;
            this.blacklisted_checkbox.Text = "blacklisted";
            this.blacklisted_checkbox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.address_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phone_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.surname_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.blacklisted_checkbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "CreateCustomer";
            this.Size = new System.Drawing.Size(846, 583);
            this.Load += new System.EventHandler(this.CreateCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox address_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox surname_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.CheckBox blacklisted_checkbox;
        private System.Windows.Forms.Button button1;
    }
}
