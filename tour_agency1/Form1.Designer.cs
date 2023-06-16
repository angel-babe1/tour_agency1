namespace tour_agency1
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
            this.goToRegister = new System.Windows.Forms.Label();
            this.adminButton = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // goToRegister
            // 
            this.goToRegister.AutoSize = true;
            this.goToRegister.BackColor = System.Drawing.Color.PaleGreen;
            this.goToRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToRegister.Location = new System.Drawing.Point(411, 221);
            this.goToRegister.Name = "goToRegister";
            this.goToRegister.Size = new System.Drawing.Size(183, 20);
            this.goToRegister.TabIndex = 7;
            this.goToRegister.Text = "*Ще не маєте акаунта?";
            this.goToRegister.Click += new System.EventHandler(this.goToRegister_Click);
            // 
            // adminButton
            // 
            this.adminButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.adminButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminButton.FlatAppearance.BorderSize = 0;
            this.adminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminButton.Location = new System.Drawing.Point(300, 302);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(217, 59);
            this.adminButton.TabIndex = 6;
            this.adminButton.Text = "Увійти як адміністратор";
            this.adminButton.UseVisualStyleBackColor = false;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // userButton
            // 
            this.userButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.userButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userButton.FlatAppearance.BorderSize = 0;
            this.userButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userButton.Location = new System.Drawing.Point(300, 154);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(217, 53);
            this.userButton.TabIndex = 5;
            this.userButton.Text = "Увійти як користувач";
            this.userButton.UseVisualStyleBackColor = false;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Головне меню турагенства \"Світ мрій\"";
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.BackColor = System.Drawing.Color.PaleGreen;
            this.x.Cursor = System.Windows.Forms.Cursors.Hand;
            this.x.Dock = System.Windows.Forms.DockStyle.Right;
            this.x.Font = new System.Drawing.Font("News706 BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x.Location = new System.Drawing.Point(791, 0);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(21, 24);
            this.x.TabIndex = 8;
            this.x.Text = "x";
            this.x.Click += new System.EventHandler(this.x_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 469);
            this.Controls.Add(this.x);
            this.Controls.Add(this.goToRegister);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.userButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Головне меню";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label goToRegister;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label x;
    }
}

