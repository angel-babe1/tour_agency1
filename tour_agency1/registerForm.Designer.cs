namespace tour_agency1
{
    partial class registerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registerForm));
            this.registerButton = new System.Windows.Forms.Button();
            this.enterPassportField = new System.Windows.Forms.TextBox();
            this.enterNameField = new System.Windows.Forms.TextBox();
            this.enterSurnameField = new System.Windows.Forms.TextBox();
            this.enterEmailField = new System.Windows.Forms.TextBox();
            this.enterPhoneField = new System.Windows.Forms.TextBox();
            this.enterBirthDateField = new System.Windows.Forms.TextBox();
            this.goBackToMainPage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.AutoSize = true;
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.Location = new System.Drawing.Point(574, 194);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(161, 51);
            this.registerButton.TabIndex = 0;
            this.registerButton.Text = "Зареєструватись";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // enterPassportField
            // 
            this.enterPassportField.Location = new System.Drawing.Point(284, 90);
            this.enterPassportField.Name = "enterPassportField";
            this.enterPassportField.Size = new System.Drawing.Size(232, 26);
            this.enterPassportField.TabIndex = 1;
            // 
            // enterNameField
            // 
            this.enterNameField.Location = new System.Drawing.Point(284, 139);
            this.enterNameField.Name = "enterNameField";
            this.enterNameField.Size = new System.Drawing.Size(232, 26);
            this.enterNameField.TabIndex = 2;
            // 
            // enterSurnameField
            // 
            this.enterSurnameField.Location = new System.Drawing.Point(284, 194);
            this.enterSurnameField.Name = "enterSurnameField";
            this.enterSurnameField.Size = new System.Drawing.Size(232, 26);
            this.enterSurnameField.TabIndex = 3;
            // 
            // enterEmailField
            // 
            this.enterEmailField.Location = new System.Drawing.Point(284, 244);
            this.enterEmailField.Name = "enterEmailField";
            this.enterEmailField.Size = new System.Drawing.Size(232, 26);
            this.enterEmailField.TabIndex = 4;
            // 
            // enterPhoneField
            // 
            this.enterPhoneField.Location = new System.Drawing.Point(284, 295);
            this.enterPhoneField.Name = "enterPhoneField";
            this.enterPhoneField.Size = new System.Drawing.Size(232, 26);
            this.enterPhoneField.TabIndex = 5;
            // 
            // enterBirthDateField
            // 
            this.enterBirthDateField.Location = new System.Drawing.Point(284, 351);
            this.enterBirthDateField.Name = "enterBirthDateField";
            this.enterBirthDateField.Size = new System.Drawing.Size(232, 26);
            this.enterBirthDateField.TabIndex = 6;
            // 
            // goBackToMainPage
            // 
            this.goBackToMainPage.AutoSize = true;
            this.goBackToMainPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goBackToMainPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackToMainPage.Location = new System.Drawing.Point(53, 411);
            this.goBackToMainPage.Name = "goBackToMainPage";
            this.goBackToMainPage.Size = new System.Drawing.Size(44, 37);
            this.goBackToMainPage.TabIndex = 7;
            this.goBackToMainPage.Text = "🡸";
            this.goBackToMainPage.Click += new System.EventHandler(this.goBackToMainPage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("News706 BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(791, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "x";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Введіть дані паспорту";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ім\'я";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Прізвище";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Введіть email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Номер телефону";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Дата народження";
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 469);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goBackToMainPage);
            this.Controls.Add(this.enterBirthDateField);
            this.Controls.Add(this.enterPhoneField);
            this.Controls.Add(this.enterEmailField);
            this.Controls.Add(this.enterSurnameField);
            this.Controls.Add(this.enterNameField);
            this.Controls.Add(this.enterPassportField);
            this.Controls.Add(this.registerButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register form";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.registerForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.registerForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox enterPassportField;
        private System.Windows.Forms.TextBox enterNameField;
        private System.Windows.Forms.TextBox enterSurnameField;
        private System.Windows.Forms.TextBox enterEmailField;
        private System.Windows.Forms.TextBox enterPhoneField;
        private System.Windows.Forms.TextBox enterBirthDateField;
        private System.Windows.Forms.Label goBackToMainPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}