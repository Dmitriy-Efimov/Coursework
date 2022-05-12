
namespace ClothingStore_CSA
{
    partial class ProductTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductTable));
            this.AddProductButton = new System.Windows.Forms.Button();
            this.UpdateProductButton = new System.Windows.Forms.Button();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.ProductGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProductButton
            // 
            this.AddProductButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.AddProductButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddProductButton.ForeColor = System.Drawing.Color.White;
            this.AddProductButton.Location = new System.Drawing.Point(12, 392);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(257, 46);
            this.AddProductButton.TabIndex = 24;
            this.AddProductButton.Text = "Добавить Товар";
            this.AddProductButton.UseVisualStyleBackColor = false;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // UpdateProductButton
            // 
            this.UpdateProductButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.UpdateProductButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateProductButton.ForeColor = System.Drawing.Color.White;
            this.UpdateProductButton.Location = new System.Drawing.Point(275, 392);
            this.UpdateProductButton.Name = "UpdateProductButton";
            this.UpdateProductButton.Size = new System.Drawing.Size(257, 46);
            this.UpdateProductButton.TabIndex = 25;
            this.UpdateProductButton.Text = "Обновить Товар";
            this.UpdateProductButton.UseVisualStyleBackColor = false;
            this.UpdateProductButton.Click += new System.EventHandler(this.UpdateProductButton_Click);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.DeleteProductButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteProductButton.ForeColor = System.Drawing.Color.White;
            this.DeleteProductButton.Location = new System.Drawing.Point(538, 392);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(254, 46);
            this.DeleteProductButton.TabIndex = 26;
            this.DeleteProductButton.Text = "Удалить Товар";
            this.DeleteProductButton.UseVisualStyleBackColor = false;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // ProductGridView
            // 
            this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridView.Location = new System.Drawing.Point(13, 13);
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.Size = new System.Drawing.Size(779, 373);
            this.ProductGridView.TabIndex = 27;
            // 
            // ProductTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProductGridView);
            this.Controls.Add(this.DeleteProductButton);
            this.Controls.Add(this.UpdateProductButton);
            this.Controls.Add(this.AddProductButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductTable";
            this.Text = "ITKKIT";
            this.Load += new System.EventHandler(this.ProductTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button UpdateProductButton;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.DataGridView ProductGridView;
    }
}