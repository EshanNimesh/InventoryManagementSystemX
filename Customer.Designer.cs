﻿namespace WindowsFormsApp15555
{
    partial class Customer
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
            this.customersbtn1 = new System.Windows.Forms.Button();
            this.productsbtn1 = new System.Windows.Forms.Button();
            this.signoutbtnsd2 = new System.Windows.Forms.Button();
            this.supcustomersgrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.supcustomersgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // customersbtn1
            // 
            this.customersbtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.customersbtn1.Location = new System.Drawing.Point(21, 27);
            this.customersbtn1.Name = "customersbtn1";
            this.customersbtn1.Size = new System.Drawing.Size(87, 30);
            this.customersbtn1.TabIndex = 0;
            this.customersbtn1.Text = "Customers";
            this.customersbtn1.UseVisualStyleBackColor = false;
            this.customersbtn1.Click += new System.EventHandler(this.customersbtn1_Click);
            // 
            // productsbtn1
            // 
            this.productsbtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.productsbtn1.Location = new System.Drawing.Point(21, 141);
            this.productsbtn1.Name = "productsbtn1";
            this.productsbtn1.Size = new System.Drawing.Size(98, 33);
            this.productsbtn1.TabIndex = 1;
            this.productsbtn1.Text = "Products";
            this.productsbtn1.UseVisualStyleBackColor = false;
            this.productsbtn1.Click += new System.EventHandler(this.productsbtn1_Click);
            // 
            // signoutbtnsd2
            // 
            this.signoutbtnsd2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.signoutbtnsd2.Location = new System.Drawing.Point(32, 295);
            this.signoutbtnsd2.Name = "signoutbtnsd2";
            this.signoutbtnsd2.Size = new System.Drawing.Size(87, 32);
            this.signoutbtnsd2.TabIndex = 2;
            this.signoutbtnsd2.Text = "Sign Out";
            this.signoutbtnsd2.UseVisualStyleBackColor = false;
            this.signoutbtnsd2.Click += new System.EventHandler(this.signoutbtnsd2_Click);
            // 
            // supcustomersgrid
            // 
            this.supcustomersgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supcustomersgrid.Location = new System.Drawing.Point(180, 27);
            this.supcustomersgrid.Name = "supcustomersgrid";
            this.supcustomersgrid.RowHeadersWidth = 51;
            this.supcustomersgrid.RowTemplate.Height = 24;
            this.supcustomersgrid.Size = new System.Drawing.Size(450, 313);
            this.supcustomersgrid.TabIndex = 3;
            this.supcustomersgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supcustomersgrid_CellContentClick);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(678, 382);
            this.Controls.Add(this.supcustomersgrid);
            this.Controls.Add(this.signoutbtnsd2);
            this.Controls.Add(this.productsbtn1);
            this.Controls.Add(this.customersbtn1);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supcustomersgrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button customersbtn1;
        private System.Windows.Forms.Button productsbtn1;
        private System.Windows.Forms.Button signoutbtnsd2;
        private System.Windows.Forms.DataGridView supcustomersgrid;
    }
}