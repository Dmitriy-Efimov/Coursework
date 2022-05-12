
namespace ClothingStore_CSA
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.EmployeeButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ViewsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.оСотрудникахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оТоварахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оРасписанииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductButton = new System.Windows.Forms.Button();
            this.DiscountCardButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeButton
            // 
            this.EmployeeButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.EmployeeButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmployeeButton.ForeColor = System.Drawing.Color.White;
            this.EmployeeButton.Location = new System.Drawing.Point(12, 409);
            this.EmployeeButton.Name = "EmployeeButton";
            this.EmployeeButton.Size = new System.Drawing.Size(152, 47);
            this.EmployeeButton.TabIndex = 0;
            this.EmployeeButton.Text = "Сотрудники";
            this.EmployeeButton.UseVisualStyleBackColor = false;
            this.EmployeeButton.Click += new System.EventHandler(this.EmployeeButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewsButton,
            this.InfoButton,
            this.ExitButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ViewsButton
            // 
            this.ViewsButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оСотрудникахToolStripMenuItem,
            this.оТоварахToolStripMenuItem,
            this.оРасписанииToolStripMenuItem});
            this.ViewsButton.Name = "ViewsButton";
            this.ViewsButton.Size = new System.Drawing.Size(93, 20);
            this.ViewsButton.Text = "&Информация";
            // 
            // оСотрудникахToolStripMenuItem
            // 
            this.оСотрудникахToolStripMenuItem.Name = "оСотрудникахToolStripMenuItem";
            this.оСотрудникахToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оСотрудникахToolStripMenuItem.Text = "&О сотрудниках";
            this.оСотрудникахToolStripMenuItem.Click += new System.EventHandler(this.оСотрудникахToolStripMenuItem_Click);
            // 
            // оТоварахToolStripMenuItem
            // 
            this.оТоварахToolStripMenuItem.Name = "оТоварахToolStripMenuItem";
            this.оТоварахToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оТоварахToolStripMenuItem.Text = "&О товарах";
            this.оТоварахToolStripMenuItem.Click += new System.EventHandler(this.оТоварахToolStripMenuItem_Click);
            // 
            // оРасписанииToolStripMenuItem
            // 
            this.оРасписанииToolStripMenuItem.Name = "оРасписанииToolStripMenuItem";
            this.оРасписанииToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оРасписанииToolStripMenuItem.Text = "&О расписании";
            this.оРасписанииToolStripMenuItem.Click += new System.EventHandler(this.оРасписанииToolStripMenuItem_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(102, 20);
            this.InfoButton.Text = "&О приложении";
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(54, 20);
            this.ExitButton.Text = "&Выход";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ProductButton
            // 
            this.ProductButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.ProductButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductButton.ForeColor = System.Drawing.Color.White;
            this.ProductButton.Location = new System.Drawing.Point(166, 409);
            this.ProductButton.Name = "ProductButton";
            this.ProductButton.Size = new System.Drawing.Size(152, 47);
            this.ProductButton.TabIndex = 2;
            this.ProductButton.Text = "Товары";
            this.ProductButton.UseVisualStyleBackColor = false;
            this.ProductButton.Click += new System.EventHandler(this.ProductButton_Click);
            // 
            // DiscountCardButton
            // 
            this.DiscountCardButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.DiscountCardButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountCardButton.ForeColor = System.Drawing.Color.White;
            this.DiscountCardButton.Location = new System.Drawing.Point(320, 409);
            this.DiscountCardButton.Name = "DiscountCardButton";
            this.DiscountCardButton.Size = new System.Drawing.Size(152, 47);
            this.DiscountCardButton.TabIndex = 3;
            this.DiscountCardButton.Text = "Скид. Карта";
            this.DiscountCardButton.UseVisualStyleBackColor = false;
            this.DiscountCardButton.Click += new System.EventHandler(this.DiscountCardButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClothingStore_CSA.Properties.Resources.imgonline_com_ua_Resize_CrTZ4majcf;
            this.ClientSize = new System.Drawing.Size(484, 468);
            this.Controls.Add(this.DiscountCardButton);
            this.Controls.Add(this.ProductButton);
            this.Controls.Add(this.EmployeeButton);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "ITKKIT";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EmployeeButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ViewsButton;
        private System.Windows.Forms.ToolStripMenuItem InfoButton;
        private System.Windows.Forms.Button ProductButton;
        private System.Windows.Forms.Button DiscountCardButton;
        private System.Windows.Forms.ToolStripMenuItem оСотрудникахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitButton;
        private System.Windows.Forms.ToolStripMenuItem оТоварахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оРасписанииToolStripMenuItem;
    }
}

