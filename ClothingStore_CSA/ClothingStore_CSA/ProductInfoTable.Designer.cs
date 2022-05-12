
namespace ClothingStore_CSA
{
    partial class ProductInfoTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInfoTable));
            this.ProductInfoGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ProductInfoGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductInfoGridView
            // 
            this.ProductInfoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductInfoGridView.Location = new System.Drawing.Point(13, 13);
            this.ProductInfoGridView.Name = "ProductInfoGridView";
            this.ProductInfoGridView.Size = new System.Drawing.Size(630, 345);
            this.ProductInfoGridView.TabIndex = 0;
            // 
            // ProductInfoTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(655, 370);
            this.Controls.Add(this.ProductInfoGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductInfoTable";
            this.Text = "ITKKIT";
            this.Load += new System.EventHandler(this.ProductInfoTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductInfoGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductInfoGridView;
    }
}