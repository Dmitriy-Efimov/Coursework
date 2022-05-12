
namespace ClothingStore_CSA
{
    partial class EmployeeTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeTable));
            this.EmployeeGridView = new System.Windows.Forms.DataGridView();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.DeleteEmployeeButton = new System.Windows.Forms.Button();
            this.UpdateEmployeeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeGridView
            // 
            this.EmployeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeGridView.Location = new System.Drawing.Point(13, 13);
            this.EmployeeGridView.Name = "EmployeeGridView";
            this.EmployeeGridView.Size = new System.Drawing.Size(775, 358);
            this.EmployeeGridView.TabIndex = 0;
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.AddEmployeeButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddEmployeeButton.ForeColor = System.Drawing.Color.White;
            this.AddEmployeeButton.Location = new System.Drawing.Point(13, 392);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(257, 46);
            this.AddEmployeeButton.TabIndex = 23;
            this.AddEmployeeButton.Text = "Добавить Сотрудника";
            this.AddEmployeeButton.UseVisualStyleBackColor = false;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // DeleteEmployeeButton
            // 
            this.DeleteEmployeeButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.DeleteEmployeeButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteEmployeeButton.ForeColor = System.Drawing.Color.White;
            this.DeleteEmployeeButton.Location = new System.Drawing.Point(539, 392);
            this.DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            this.DeleteEmployeeButton.Size = new System.Drawing.Size(249, 46);
            this.DeleteEmployeeButton.TabIndex = 24;
            this.DeleteEmployeeButton.Text = "Удалить Сотрудника";
            this.DeleteEmployeeButton.UseVisualStyleBackColor = false;
            this.DeleteEmployeeButton.Click += new System.EventHandler(this.DeleteEmployeeButton_Click);
            // 
            // UpdateEmployeeButton
            // 
            this.UpdateEmployeeButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.UpdateEmployeeButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateEmployeeButton.ForeColor = System.Drawing.Color.White;
            this.UpdateEmployeeButton.Location = new System.Drawing.Point(276, 392);
            this.UpdateEmployeeButton.Name = "UpdateEmployeeButton";
            this.UpdateEmployeeButton.Size = new System.Drawing.Size(257, 46);
            this.UpdateEmployeeButton.TabIndex = 25;
            this.UpdateEmployeeButton.Text = "Обновить Сотрудника";
            this.UpdateEmployeeButton.UseVisualStyleBackColor = false;
            this.UpdateEmployeeButton.Click += new System.EventHandler(this.UpdateEmployeeButton_Click);
            // 
            // EmployeeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateEmployeeButton);
            this.Controls.Add(this.DeleteEmployeeButton);
            this.Controls.Add(this.AddEmployeeButton);
            this.Controls.Add(this.EmployeeGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeTable";
            this.Text = "ITKKIT";
            this.Load += new System.EventHandler(this.EmployeeTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeeGridView;
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.Button DeleteEmployeeButton;
        private System.Windows.Forms.Button UpdateEmployeeButton;
    }
}