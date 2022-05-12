
namespace ClothingStore_CSA
{
    partial class EmployeeInfoTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeInfoTable));
            this.EmployeeInfoGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeInfoGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeInfoGridView
            // 
            this.EmployeeInfoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeInfoGridView.Location = new System.Drawing.Point(13, 13);
            this.EmployeeInfoGridView.Name = "EmployeeInfoGridView";
            this.EmployeeInfoGridView.Size = new System.Drawing.Size(630, 345);
            this.EmployeeInfoGridView.TabIndex = 0;
            this.EmployeeInfoGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeInfoGridView_CellContentClick);
            // 
            // EmployeeInfoTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(655, 370);
            this.Controls.Add(this.EmployeeInfoGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeInfoTable";
            this.Text = "ITKKIT";
            this.Load += new System.EventHandler(this.EmployeeInfoTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeInfoGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeeInfoGridView;
    }
}