
namespace ClothingStore_CSA
{
    partial class DelDiscCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DelDiscCard));
            this.label1 = new System.Windows.Forms.Label();
            this.ParametrOne = new System.Windows.Forms.TextBox();
            this.DeleteDiscCardButtonn = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите Номер Скидочной Карты:";
            // 
            // ParametrOne
            // 
            this.ParametrOne.Location = new System.Drawing.Point(17, 35);
            this.ParametrOne.Name = "ParametrOne";
            this.ParametrOne.Size = new System.Drawing.Size(259, 20);
            this.ParametrOne.TabIndex = 1;
            // 
            // DeleteDiscCardButtonn
            // 
            this.DeleteDiscCardButtonn.BackColor = System.Drawing.Color.LightSlateGray;
            this.DeleteDiscCardButtonn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteDiscCardButtonn.ForeColor = System.Drawing.Color.White;
            this.DeleteDiscCardButtonn.Location = new System.Drawing.Point(12, 70);
            this.DeleteDiscCardButtonn.Name = "DeleteDiscCardButtonn";
            this.DeleteDiscCardButtonn.Size = new System.Drawing.Size(302, 46);
            this.DeleteDiscCardButtonn.TabIndex = 37;
            this.DeleteDiscCardButtonn.Text = "Удалить Скид. Карту";
            this.DeleteDiscCardButtonn.UseVisualStyleBackColor = false;
            this.DeleteDiscCardButtonn.Click += new System.EventHandler(this.DeleteDiscCardButtonn_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(12, 122);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(302, 46);
            this.BackButton.TabIndex = 38;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DelDiscCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(326, 174);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.DeleteDiscCardButtonn);
            this.Controls.Add(this.ParametrOne);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DelDiscCard";
            this.Text = "ITKKIT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ParametrOne;
        private System.Windows.Forms.Button DeleteDiscCardButtonn;
        private System.Windows.Forms.Button BackButton;
    }
}