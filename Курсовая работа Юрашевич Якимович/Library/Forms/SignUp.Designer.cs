
namespace Library.Forms
{
    partial class SignUp
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.seePass = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.signupButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.LinkLabel();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.loginbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Library.Properties.Resources.LabelName;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(331, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 169);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Регистрация";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.seePass);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.signupButton);
            this.panel1.Controls.Add(this.returnButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.passwordbox);
            this.panel1.Controls.Add(this.loginbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(329, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 328);
            this.panel1.TabIndex = 7;
            // 
            // seePass
            // 
            this.seePass.BackColor = System.Drawing.Color.PaleGreen;
            this.seePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.seePass.Location = new System.Drawing.Point(347, 180);
            this.seePass.Name = "seePass";
            this.seePass.Size = new System.Drawing.Size(32, 30);
            this.seePass.TabIndex = 9;
            this.seePass.UseVisualStyleBackColor = false;
            this.seePass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.seePass_MouseDown);
            this.seePass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.seePass_MouseUp);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.PaleGreen;
            this.clearButton.Location = new System.Drawing.Point(228, 268);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(108, 39);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // signupButton
            // 
            this.signupButton.BackColor = System.Drawing.Color.PaleGreen;
            this.signupButton.Location = new System.Drawing.Point(45, 268);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(162, 39);
            this.signupButton.TabIndex = 7;
            this.signupButton.Text = "Зарегистрироваться";
            this.signupButton.UseVisualStyleBackColor = false;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.ActiveLinkColor = System.Drawing.Color.Yellow;
            this.returnButton.AutoSize = true;
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.returnButton.Location = new System.Drawing.Point(125, 226);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(157, 25);
            this.returnButton.TabIndex = 6;
            this.returnButton.TabStop = true;
            this.returnButton.Text = "Вход в систему";
            this.returnButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.returnButton_LinkClicked);
            // 
            // passwordbox
            // 
            this.passwordbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordbox.Location = new System.Drawing.Point(45, 176);
            this.passwordbox.MaxLength = 45;
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.Size = new System.Drawing.Size(291, 38);
            this.passwordbox.TabIndex = 3;
            // 
            // loginbox
            // 
            this.loginbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbox.Location = new System.Drawing.Point(45, 95);
            this.loginbox.MaxLength = 45;
            this.loginbox.Name = "loginbox";
            this.loginbox.Size = new System.Drawing.Size(291, 38);
            this.loginbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources.BackLogin;
            this.ClientSize = new System.Drawing.Size(1052, 533);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.LinkLabel returnButton;
        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.TextBox loginbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button seePass;
    }
}