namespace WindowsFormsApp15555
{
    partial class ViewByCategoryForm
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
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.dgvProductsByCategory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsByCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(273, 92);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(121, 24);
            this.cmbCategories.TabIndex = 0;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
            // 
            // dgvProductsByCategory
            // 
            this.dgvProductsByCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsByCategory.Location = new System.Drawing.Point(242, 195);
            this.dgvProductsByCategory.Name = "dgvProductsByCategory";
            this.dgvProductsByCategory.RowHeadersWidth = 51;
            this.dgvProductsByCategory.RowTemplate.Height = 24;
            this.dgvProductsByCategory.Size = new System.Drawing.Size(240, 150);
            this.dgvProductsByCategory.TabIndex = 1;
            // 
            // ViewByCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvProductsByCategory);
            this.Controls.Add(this.cmbCategories);
            this.Name = "ViewByCategoryForm";
            this.Text = "ViewByCategoryForm";
            this.Load += new System.EventHandler(this.ViewByCategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsByCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.DataGridView dgvProductsByCategory;
    }
}