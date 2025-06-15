namespace WindowsFormsApp15555
{
    partial class TotalInventoryForm
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
            this.lblTotalValue = new System.Windows.Forms.DataGridView();
            this.lblTotalValue1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotalValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lblTotalValue.Location = new System.Drawing.Point(44, 116);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.RowHeadersWidth = 51;
            this.lblTotalValue.RowTemplate.Height = 24;
            this.lblTotalValue.Size = new System.Drawing.Size(706, 322);
            this.lblTotalValue.TabIndex = 0;
            // 
            // lblTotalValue1
            // 
            this.lblTotalValue1.AutoSize = true;
            this.lblTotalValue1.Location = new System.Drawing.Point(368, 73);
            this.lblTotalValue1.Name = "lblTotalValue1";
            this.lblTotalValue1.Size = new System.Drawing.Size(44, 16);
            this.lblTotalValue1.TabIndex = 1;
            this.lblTotalValue1.Text = "label1";
            this.lblTotalValue1.Click += new System.EventHandler(this.lblTotalValue1_Click);
            // 
            // TotalInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalValue1);
            this.Controls.Add(this.lblTotalValue);
            this.Name = "TotalInventoryForm";
            this.Text = "TotalInventoryForm";
            this.Load += new System.EventHandler(this.TotalInventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lblTotalValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lblTotalValue;
        private System.Windows.Forms.Label lblTotalValue1;
    }
}