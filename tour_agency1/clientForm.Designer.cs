namespace tour_agency1
{
    partial class clientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clientForm));
            this.signUpButton = new System.Windows.Forms.Button();
            this.passportField = new System.Windows.Forms.TextBox();
            this.nameField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.goBackToMainPage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signUpButton
            // 
            this.signUpButton.AutoSize = true;
            this.signUpButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.signUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpButton.FlatAppearance.BorderSize = 0;
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpButton.Location = new System.Drawing.Point(321, 294);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(130, 39);
            this.signUpButton.TabIndex = 0;
            this.signUpButton.Text = "Увійти";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // passportField
            // 
            this.passportField.Location = new System.Drawing.Point(409, 126);
            this.passportField.Name = "passportField";
            this.passportField.Size = new System.Drawing.Size(187, 26);
            this.passportField.TabIndex = 1;
            this.passportField.UseSystemPasswordChar = true;
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(409, 210);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(187, 26);
            this.nameField.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(183, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "passport";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(183, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "name";
            // 
            // goBackToMainPage
            // 
            this.goBackToMainPage.AutoSize = true;
            this.goBackToMainPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.goBackToMainPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goBackToMainPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackToMainPage.Location = new System.Drawing.Point(180, 296);
            this.goBackToMainPage.Name = "goBackToMainPage";
            this.goBackToMainPage.Size = new System.Drawing.Size(44, 37);
            this.goBackToMainPage.TabIndex = 5;
            this.goBackToMainPage.Text = "🡸";
            this.goBackToMainPage.Click += new System.EventHandler(this.goBackToMainPage_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("News706 BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(791, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "x";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // clientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 469);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.goBackToMainPage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.passportField);
            this.Controls.Add(this.signUpButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "clientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "clientForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clientForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.clientForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.TextBox passportField;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label goBackToMainPage;
        private System.Windows.Forms.Label label3;
    }
}