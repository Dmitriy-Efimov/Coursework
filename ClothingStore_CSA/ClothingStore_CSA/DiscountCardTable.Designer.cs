
namespace ClothingStore_CSA
{
    partial class DiscountCardTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscountCardTable));
            this.AddDicsCardButton = new System.Windows.Forms.Button();
            this.UpdateDiscCardButton = new System.Windows.Forms.Button();
            this.DeleteDicsCardButton = new System.Windows.Forms.Button();
            this.DiscCardGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DiscCardGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddDicsCardButton
            // 
            this.AddDicsCardButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.AddDicsCardButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDicsCardButton.ForeColor = System.Drawing.Color.White;
            this.AddDicsCardButton.Location = new System.Drawing.Point(12, 392);
            this.AddDicsCardButton.Name = "AddDicsCardButton";
            this.AddDicsCardButton.Size = new System.Drawing.Size(257, 46);
            this.AddDicsCardButton.TabIndex = 25;
            this.AddDicsCardButton.Text = "Добавить Скид. Карту";
            this.AddDicsCardButton.UseVisualStyleBackColor = false;
            this.AddDicsCardButton.Click += new System.EventHandler(this.AddDicsCardButton_Click);
            // 
            // UpdateDiscCardButton
            // 
            this.UpdateDiscCardButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.UpdateDiscCardButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateDiscCardButton.ForeColor = System.Drawing.Color.White;
            this.UpdateDiscCardButton.Location = new System.Drawing.Point(275, 392);
            this.UpdateDiscCardButton.Name = "UpdateDiscCardButton";
            this.UpdateDiscCardButton.Size = new System.Drawing.Size(257, 46);
            this.UpdateDiscCardButton.TabIndex = 26;
            this.UpdateDiscCardButton.Text = "Обновить Скид. Карту";
            this.UpdateDiscCardButton.UseVisualStyleBackColor = false;
            this.UpdateDiscCardButton.Click += new System.EventHandler(this.UpdateDiscCardButton_Click);
            // 
            // DeleteDicsCardButton
            // 
            this.DeleteDicsCardButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.DeleteDicsCardButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteDicsCardButton.ForeColor = System.Drawing.Color.White;
            this.DeleteDicsCardButton.Location = new System.Drawing.Point(538, 392);
            this.DeleteDicsCardButton.Name = "DeleteDicsCardButton";
            this.DeleteDicsCardButton.Size = new System.Drawing.Size(257, 46);
            this.DeleteDicsCardButton.TabIndex = 27;
            this.DeleteDicsCardButton.Text = "Удалить Скид. Карту";
            this.DeleteDicsCardButton.UseVisualStyleBackColor = false;
            this.DeleteDicsCardButton.Click += new System.EventHandler(this.DeleteDicsCardButton_Click);
            // 
            // DiscCardGridView
            // 
            this.DiscCardGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiscCardGridView.Location = new System.Drawing.Point(13, 13);
            this.DiscCardGridView.Name = "DiscCardGridView";
            this.DiscCardGridView.Size = new System.Drawing.Size(782, 373);
            this.DiscCardGridView.TabIndex = 28;
            // 
            // DiscountCardTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DiscCardGridView);
            this.Controls.Add(this.DeleteDicsCardButton);
            this.Controls.Add(this.UpdateDiscCardButton);
            this.Controls.Add(this.AddDicsCardButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DiscountCardTable";
            this.Text = "ITKKIT";
            this.Load += new System.EventHandler(this.DiscountCardTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DiscCardGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddDicsCardButton;
        private System.Windows.Forms.Button UpdateDiscCardButton;
        private System.Windows.Forms.Button DeleteDicsCardButton;
        private System.Windows.Forms.DataGridView DiscCardGridView;
    }
}