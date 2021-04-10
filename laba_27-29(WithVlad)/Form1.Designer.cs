namespace laba_27_29_WithVlad_
{
    partial class LoginForm
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
            this.MenedgerBtn = new System.Windows.Forms.Button();
            this.AdminBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MenedgerBtn
            // 
            this.MenedgerBtn.Location = new System.Drawing.Point(12, 12);
            this.MenedgerBtn.Name = "MenedgerBtn";
            this.MenedgerBtn.Size = new System.Drawing.Size(402, 134);
            this.MenedgerBtn.TabIndex = 0;
            this.MenedgerBtn.Text = "Менеджер";
            this.MenedgerBtn.UseVisualStyleBackColor = true;
            this.MenedgerBtn.Click += new System.EventHandler(this.MenedgerBtn_Click);
            // 
            // AdminBtn
            // 
            this.AdminBtn.Location = new System.Drawing.Point(12, 152);
            this.AdminBtn.Name = "AdminBtn";
            this.AdminBtn.Size = new System.Drawing.Size(402, 139);
            this.AdminBtn.TabIndex = 1;
            this.AdminBtn.Text = "Админ";
            this.AdminBtn.UseVisualStyleBackColor = true;
            this.AdminBtn.Click += new System.EventHandler(this.AdminBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 299);
            this.Controls.Add(this.AdminBtn);
            this.Controls.Add(this.MenedgerBtn);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MenedgerBtn;
        private System.Windows.Forms.Button AdminBtn;
    }
}

