
namespace ClothingStore_CSA
{
    partial class ScheduleInfoTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleInfoTable));
            this.ScheduleInfoGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleInfoGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ScheduleInfoGridView
            // 
            this.ScheduleInfoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduleInfoGridView.Location = new System.Drawing.Point(13, 13);
            this.ScheduleInfoGridView.Name = "ScheduleInfoGridView";
            this.ScheduleInfoGridView.Size = new System.Drawing.Size(630, 345);
            this.ScheduleInfoGridView.TabIndex = 0;
            // 
            // ScheduleInfoTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(655, 370);
            this.Controls.Add(this.ScheduleInfoGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScheduleInfoTable";
            this.Text = "ITKKIT";
            this.Load += new System.EventHandler(this.ScheduleInfoTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleInfoGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ScheduleInfoGridView;
    }
}