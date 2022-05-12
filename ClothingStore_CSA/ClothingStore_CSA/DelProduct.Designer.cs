
namespace ClothingStore_CSA
{
    partial class DelProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DelProduct));
            this.DeleteProductButtonn = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ParametrOne = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DeleteProductButtonn
            // 
            this.DeleteProductButtonn.BackColor = System.Drawing.Color.LightSlateGray;
            this.DeleteProductButtonn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteProductButtonn.ForeColor = System.Drawing.Color.White;
            this.DeleteProductButtonn.Location = new System.Drawing.Point(12, 81);
            this.DeleteProductButtonn.Name = "DeleteProductButtonn";
            this.DeleteProductButtonn.Size = new System.Drawing.Size(260, 46);
            this.DeleteProductButtonn.TabIndex = 24;
            this.DeleteProductButtonn.Text = "Удалить Товар";
            this.DeleteProductButtonn.UseVisualStyleBackColor = false;
            this.DeleteProductButtonn.Click += new System.EventHandler(this.DeleteProductButtonn_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(12, 133);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(260, 46);
            this.BackButton.TabIndex = 26;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Введите Id Товара:";
            // 
            // ParametrOne
            // 
            this.ParametrOne.Location = new System.Drawing.Point(12, 31);
            this.ParametrOne.Name = "ParametrOne";
            this.ParametrOne.Size = new System.Drawing.Size(147, 20);
            this.ParametrOne.TabIndex = 28;
            // 
            // DelProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 191);
            this.Controls.Add(this.ParametrOne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.DeleteProductButtonn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DelProduct";
            this.Text = "ITKKIT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteProductButtonn;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ParametrOne;
    }
}