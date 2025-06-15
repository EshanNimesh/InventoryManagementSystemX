namespace WindowsFormsApp15555
{
    partial class ProductModel
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
            this.customersbtn2 = new System.Windows.Forms.Button();
            this.productsbtn2 = new System.Windows.Forms.Button();
            this.signoutbtnsd3 = new System.Windows.Forms.Button();
            this.supproductsgrid = new System.Windows.Forms.DataGridView();
            this.idlabel = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.namebox = new System.Windows.Forms.TextBox();
            this.namelabel = new System.Windows.Forms.Label();
            this.descriptionlabel = new System.Windows.Forms.Label();
            this.quantitylabel = new System.Windows.Forms.Label();
            this.pricelabel = new System.Windows.Forms.Label();
            this.idbox = new System.Windows.Forms.TextBox();
            this.descriptionbox = new System.Windows.Forms.TextBox();
            this.quantitybox = new System.Windows.Forms.TextBox();
            this.pricebox = new System.Windows.Forms.TextBox();
            this.updatebtn = new System.Windows.Forms.Button();
            this.removebtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.supproductsgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // customersbtn2
            // 
            this.customersbtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.customersbtn2.Location = new System.Drawing.Point(49, 71);
            this.customersbtn2.Name = "customersbtn2";
            this.customersbtn2.Size = new System.Drawing.Size(89, 31);
            this.customersbtn2.TabIndex = 0;
            this.customersbtn2.Text = "Customers";
            this.customersbtn2.UseVisualStyleBackColor = false;
            this.customersbtn2.Click += new System.EventHandler(this.customersbtn2_Click);
            // 
            // productsbtn2
            // 
            this.productsbtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.productsbtn2.Location = new System.Drawing.Point(49, 217);
            this.productsbtn2.Name = "productsbtn2";
            this.productsbtn2.Size = new System.Drawing.Size(89, 32);
            this.productsbtn2.TabIndex = 1;
            this.productsbtn2.Text = "Products";
            this.productsbtn2.UseVisualStyleBackColor = false;
            this.productsbtn2.Click += new System.EventHandler(this.productsbtn2_Click);
            // 
            // signoutbtnsd3
            // 
            this.signoutbtnsd3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.signoutbtnsd3.Location = new System.Drawing.Point(49, 357);
            this.signoutbtnsd3.Name = "signoutbtnsd3";
            this.signoutbtnsd3.Size = new System.Drawing.Size(89, 34);
            this.signoutbtnsd3.TabIndex = 2;
            this.signoutbtnsd3.Text = "Sign Out";
            this.signoutbtnsd3.UseVisualStyleBackColor = false;
            this.signoutbtnsd3.Click += new System.EventHandler(this.signoutbtnsd3_Click);
            // 
            // supproductsgrid
            // 
            this.supproductsgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supproductsgrid.Location = new System.Drawing.Point(312, 31);
            this.supproductsgrid.Name = "supproductsgrid";
            this.supproductsgrid.RowHeadersWidth = 51;
            this.supproductsgrid.RowTemplate.Height = 24;
            this.supproductsgrid.Size = new System.Drawing.Size(389, 209);
            this.supproductsgrid.TabIndex = 3;
            this.supproductsgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supproductsgrid_CellContentClick);
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Location = new System.Drawing.Point(309, 271);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(20, 16);
            this.idlabel.TabIndex = 4;
            this.idlabel.Text = "ID";
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addbtn.Location = new System.Drawing.Point(693, 264);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(84, 32);
            this.addbtn.TabIndex = 5;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(404, 293);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(238, 22);
            this.namebox.TabIndex = 6;
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(309, 302);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(44, 16);
            this.namelabel.TabIndex = 7;
            this.namelabel.Text = "Name";
            // 
            // descriptionlabel
            // 
            this.descriptionlabel.AutoSize = true;
            this.descriptionlabel.Location = new System.Drawing.Point(309, 336);
            this.descriptionlabel.Name = "descriptionlabel";
            this.descriptionlabel.Size = new System.Drawing.Size(75, 16);
            this.descriptionlabel.TabIndex = 8;
            this.descriptionlabel.Text = "Description";
            // 
            // quantitylabel
            // 
            this.quantitylabel.AutoSize = true;
            this.quantitylabel.Location = new System.Drawing.Point(309, 369);
            this.quantitylabel.Name = "quantitylabel";
            this.quantitylabel.Size = new System.Drawing.Size(55, 16);
            this.quantitylabel.TabIndex = 9;
            this.quantitylabel.Text = "Quantity";
            // 
            // pricelabel
            // 
            this.pricelabel.AutoSize = true;
            this.pricelabel.Location = new System.Drawing.Point(309, 416);
            this.pricelabel.Name = "pricelabel";
            this.pricelabel.Size = new System.Drawing.Size(38, 16);
            this.pricelabel.TabIndex = 10;
            this.pricelabel.Text = "Price";
            // 
            // idbox
            // 
            this.idbox.Location = new System.Drawing.Point(404, 265);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(238, 22);
            this.idbox.TabIndex = 11;
            // 
            // descriptionbox
            // 
            this.descriptionbox.Location = new System.Drawing.Point(404, 330);
            this.descriptionbox.Name = "descriptionbox";
            this.descriptionbox.Size = new System.Drawing.Size(238, 22);
            this.descriptionbox.TabIndex = 12;
            // 
            // quantitybox
            // 
            this.quantitybox.Location = new System.Drawing.Point(404, 363);
            this.quantitybox.Name = "quantitybox";
            this.quantitybox.Size = new System.Drawing.Size(238, 22);
            this.quantitybox.TabIndex = 13;
            // 
            // pricebox
            // 
            this.pricebox.Location = new System.Drawing.Point(404, 410);
            this.pricebox.Name = "pricebox";
            this.pricebox.Size = new System.Drawing.Size(238, 22);
            this.pricebox.TabIndex = 14;
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.updatebtn.Location = new System.Drawing.Point(693, 302);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(84, 33);
            this.updatebtn.TabIndex = 15;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // removebtn
            // 
            this.removebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.removebtn.Location = new System.Drawing.Point(693, 352);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(84, 33);
            this.removebtn.TabIndex = 16;
            this.removebtn.Text = "Remove";
            this.removebtn.UseVisualStyleBackColor = false;
            this.removebtn.Click += new System.EventHandler(this.removebtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.clearbtn.Location = new System.Drawing.Point(693, 399);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(84, 33);
            this.clearbtn.TabIndex = 17;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = false;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // ProductModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.removebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.pricebox);
            this.Controls.Add(this.quantitybox);
            this.Controls.Add(this.descriptionbox);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.pricelabel);
            this.Controls.Add(this.quantitylabel);
            this.Controls.Add(this.descriptionlabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.idlabel);
            this.Controls.Add(this.supproductsgrid);
            this.Controls.Add(this.signoutbtnsd3);
            this.Controls.Add(this.productsbtn2);
            this.Controls.Add(this.customersbtn2);
            this.Name = "ProductModel";
            this.Text = "ProductModel";
            this.Load += new System.EventHandler(this.ProductModel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supproductsgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button customersbtn2;
        private System.Windows.Forms.Button productsbtn2;
        private System.Windows.Forms.Button signoutbtnsd3;
        private System.Windows.Forms.DataGridView supproductsgrid;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label descriptionlabel;
        private System.Windows.Forms.Label quantitylabel;
        private System.Windows.Forms.Label pricelabel;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.TextBox descriptionbox;
        private System.Windows.Forms.TextBox quantitybox;
        private System.Windows.Forms.TextBox pricebox;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button removebtn;
        private System.Windows.Forms.Button clearbtn;
    }
}