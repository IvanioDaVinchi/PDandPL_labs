namespace laba_Paint
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LineButton = new System.Windows.Forms.Button();
            this.BlackRactangleButton = new System.Windows.Forms.PictureBox();
            this.rectangleButton = new System.Windows.Forms.PictureBox();
            this.Circle2_button = new System.Windows.Forms.PictureBox();
            this.Circle_Button = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Color_Button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlackRactangleButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectangleButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Circle2_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Circle_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(915, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.saveAllToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // saveAllToolStripMenuItem
            // 
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.saveAllToolStripMenuItem.Text = "Save All";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // LineButton
            // 
            this.LineButton.Location = new System.Drawing.Point(12, 41);
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(25, 23);
            this.LineButton.TabIndex = 2;
            this.LineButton.Text = "/";
            this.LineButton.UseVisualStyleBackColor = true;
            this.LineButton.Click += new System.EventHandler(this.LineButton_Click);
            // 
            // BlackRactangleButton
            // 
            this.BlackRactangleButton.Image = global::laba_Paint.Properties.Resources._5b5f7aa1732d3164ecf706c0;
            this.BlackRactangleButton.Location = new System.Drawing.Point(153, 41);
            this.BlackRactangleButton.Name = "BlackRactangleButton";
            this.BlackRactangleButton.Size = new System.Drawing.Size(33, 22);
            this.BlackRactangleButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BlackRactangleButton.TabIndex = 6;
            this.BlackRactangleButton.TabStop = false;
            this.BlackRactangleButton.Click += new System.EventHandler(this.BlackRactangleButton_Click);
            // 
            // rectangleButton
            // 
            this.rectangleButton.Image = global::laba_Paint.Properties.Resources.software_shape_rectangle_98272;
            this.rectangleButton.Location = new System.Drawing.Point(110, 41);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(36, 23);
            this.rectangleButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rectangleButton.TabIndex = 5;
            this.rectangleButton.TabStop = false;
            this.rectangleButton.Click += new System.EventHandler(this.rectangleButton_Click);
            // 
            // Circle2_button
            // 
            this.Circle2_button.Image = global::laba_Paint.Properties.Resources.pngtree_pure_black_circle_png_image_2319167;
            this.Circle2_button.Location = new System.Drawing.Point(77, 41);
            this.Circle2_button.Name = "Circle2_button";
            this.Circle2_button.Size = new System.Drawing.Size(27, 23);
            this.Circle2_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Circle2_button.TabIndex = 4;
            this.Circle2_button.TabStop = false;
            this.Circle2_button.Click += new System.EventHandler(this.Circle2_button_Click);
            // 
            // Circle_Button
            // 
            this.Circle_Button.Image = global::laba_Paint.Properties.Resources.circled;
            this.Circle_Button.InitialImage = ((System.Drawing.Image)(resources.GetObject("Circle_Button.InitialImage")));
            this.Circle_Button.Location = new System.Drawing.Point(43, 41);
            this.Circle_Button.Name = "Circle_Button";
            this.Circle_Button.Size = new System.Drawing.Size(28, 23);
            this.Circle_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Circle_Button.TabIndex = 3;
            this.Circle_Button.TabStop = false;
            this.Circle_Button.Click += new System.EventHandler(this.Circle_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(891, 396);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // TextButton
            // 
            this.TextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextButton.Location = new System.Drawing.Point(192, 41);
            this.TextButton.Name = "TextButton";
            this.TextButton.Size = new System.Drawing.Size(32, 23);
            this.TextButton.TabIndex = 7;
            this.TextButton.Text = "T";
            this.TextButton.UseVisualStyleBackColor = true;
            this.TextButton.Click += new System.EventHandler(this.TextButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(230, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "T";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Color_Button
            // 
            this.Color_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Color_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Color_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Color_Button.Location = new System.Drawing.Point(268, 40);
            this.Color_Button.Name = "Color_Button";
            this.Color_Button.Size = new System.Drawing.Size(50, 23);
            this.Color_Button.TabIndex = 9;
            this.Color_Button.Text = "Color";
            this.Color_Button.UseVisualStyleBackColor = false;
            this.Color_Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Кисть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 489);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Color_Button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextButton);
            this.Controls.Add(this.BlackRactangleButton);
            this.Controls.Add(this.rectangleButton);
            this.Controls.Add(this.Circle2_button);
            this.Controls.Add(this.Circle_Button);
            this.Controls.Add(this.LineButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlackRactangleButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectangleButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Circle2_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Circle_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LineButton;
        private System.Windows.Forms.PictureBox Circle_Button;
        private System.Windows.Forms.PictureBox Circle2_button;
        private System.Windows.Forms.PictureBox rectangleButton;
        private System.Windows.Forms.PictureBox BlackRactangleButton;
        private System.Windows.Forms.Button TextButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button Color_Button;
        private System.Windows.Forms.Button button2;
    }
}

