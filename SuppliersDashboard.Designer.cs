namespace WindowsFormsApp15555
{
    partial class SuppliersDashboard
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
            this.customersbtn = new System.Windows.Forms.Button();
            this.productsbtn = new System.Windows.Forms.Button();
            this.signoutbtnsd1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customersbtn
            // 
            this.customersbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.customersbtn.Location = new System.Drawing.Point(70, 96);
            this.customersbtn.Name = "customersbtn";
            this.customersbtn.Size = new System.Drawing.Size(79, 36);
            this.customersbtn.TabIndex = 0;
            this.customersbtn.Text = "Customers";
            this.customersbtn.UseVisualStyleBackColor = false;
            this.customersbtn.Click += new System.EventHandler(this.customersbtn_Click);
            // 
            // productsbtn
            // 
            this.productsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.productsbtn.Location = new System.Drawing.Point(70, 197);
            this.productsbtn.Name = "productsbtn";
            this.productsbtn.Size = new System.Drawing.Size(79, 35);
            this.productsbtn.TabIndex = 1;
            this.productsbtn.Text = "Products";
            this.productsbtn.UseVisualStyleBackColor = false;
            this.productsbtn.Click += new System.EventHandler(this.productsbtn_Click);
            // 
            // signoutbtnsd1
            // 
            this.signoutbtnsd1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.signoutbtnsd1.Location = new System.Drawing.Point(70, 311);
            this.signoutbtnsd1.Name = "signoutbtnsd1";
            this.signoutbtnsd1.Size = new System.Drawing.Size(79, 34);
            this.signoutbtnsd1.TabIndex = 2;
            this.signoutbtnsd1.Text = "Sign Out";
            this.signoutbtnsd1.UseVisualStyleBackColor = false;
            this.signoutbtnsd1.Click += new System.EventHandler(this.signoutbtnsd1_Click);
            // 
            // SuppliersDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.signoutbtnsd1);
            this.Controls.Add(this.productsbtn);
            this.Controls.Add(this.customersbtn);
            this.Name = "SuppliersDashboard";
            this.Text = "SuppliersDashboard";
            this.Load += new System.EventHandler(this.SuppliersDashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button customersbtn;
        private System.Windows.Forms.Button productsbtn;
        private System.Windows.Forms.Button signoutbtnsd1;
    }
}