
namespace Library.Forms
{
    partial class AddBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bk_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bk_id = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pb_id = new System.Windows.Forms.MaskedTextBox();
            this.cv_id = new System.Windows.Forms.MaskedTextBox();
            this.au_id = new System.Windows.Forms.MaskedTextBox();
            this.bk_pages = new System.Windows.Forms.MaskedTextBox();
            this.bk_publishyear = new System.Windows.Forms.MaskedTextBox();
            this.bk_avail = new System.Windows.Forms.CheckBox();
            this.gn_id = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Library.Properties.Resources.patient;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(25, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 58);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Создание книги";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "ID обложки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "ID";
            // 
            // bk_name
            // 
            this.bk_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bk_name.Location = new System.Drawing.Point(166, 172);
            this.bk_name.Name = "bk_name";
            this.bk_name.Size = new System.Drawing.Size(255, 28);
            this.bk_name.TabIndex = 19;
           
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Location = new System.Drawing.Point(314, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 39);
            this.button1.TabIndex = 26;
            this.button1.Text = "Записать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bk_id
            // 
            this.bk_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bk_id.Location = new System.Drawing.Point(166, 126);
            this.bk_id.Mask = "00000000";
            this.bk_id.Name = "bk_id";
            this.bk_id.Size = new System.Drawing.Size(95, 27);
            this.bk_id.TabIndex = 27;
            this.bk_id.ValidatingType = typeof(int);
      
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 24);
            this.label6.TabIndex = 28;
            this.label6.Text = "Название";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(444, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 24);
            this.label9.TabIndex = 31;
            this.label9.Text = "В доступе";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "ID автора";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 24);
            this.label7.TabIndex = 32;
            this.label7.Text = "ID издательства";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(444, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 24);
            this.label5.TabIndex = 33;
            this.label5.Text = "Кол-во страниц";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(444, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 24);
            this.label8.TabIndex = 34;
            this.label8.Text = "Год издания";
            // 
            // pb_id
            // 
            this.pb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pb_id.Location = new System.Drawing.Point(166, 299);
            this.pb_id.Mask = "00000000";
            this.pb_id.Name = "pb_id";
            this.pb_id.Size = new System.Drawing.Size(95, 27);
            this.pb_id.TabIndex = 35;
            this.pb_id.ValidatingType = typeof(int);
            // 
            // cv_id
            // 
            this.cv_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cv_id.Location = new System.Drawing.Point(166, 258);
            this.cv_id.Mask = "00000000";
            this.cv_id.Name = "cv_id";
            this.cv_id.Size = new System.Drawing.Size(95, 27);
            this.cv_id.TabIndex = 36;
            this.cv_id.ValidatingType = typeof(int);
            // 
            // au_id
            // 
            this.au_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.au_id.Location = new System.Drawing.Point(166, 216);
            this.au_id.Mask = "00000000";
            this.au_id.Name = "au_id";
            this.au_id.Size = new System.Drawing.Size(95, 27);
            this.au_id.TabIndex = 37;
            this.au_id.ValidatingType = typeof(int);
            // 
            // bk_pages
            // 
            this.bk_pages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bk_pages.Location = new System.Drawing.Point(600, 170);
            this.bk_pages.Mask = "00000000";
            this.bk_pages.Name = "bk_pages";
            this.bk_pages.Size = new System.Drawing.Size(95, 27);
            this.bk_pages.TabIndex = 38;
            this.bk_pages.ValidatingType = typeof(int);
            // 
            // bk_publishyear
            // 
            this.bk_publishyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bk_publishyear.Location = new System.Drawing.Point(600, 214);
            this.bk_publishyear.Mask = "0000-00-00";
            this.bk_publishyear.Name = "bk_publishyear";
            this.bk_publishyear.Size = new System.Drawing.Size(95, 27);
            this.bk_publishyear.TabIndex = 39;
            // 
            // bk_avail
            // 
            this.bk_avail.AutoSize = true;
            this.bk_avail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bk_avail.Location = new System.Drawing.Point(600, 268);
            this.bk_avail.Name = "bk_avail";
            this.bk_avail.Size = new System.Drawing.Size(18, 17);
            this.bk_avail.TabIndex = 40;
            this.bk_avail.Tag = "0";
            this.bk_avail.UseVisualStyleBackColor = true;
            this.bk_avail.CheckedChanged += new System.EventHandler(this.bk_avail_CheckedChanged);
            // 
            // gn_id
            // 
            this.gn_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gn_id.Location = new System.Drawing.Point(600, 125);
            this.gn_id.Mask = "00000000";
            this.gn_id.Name = "gn_id";
            this.gn_id.Size = new System.Drawing.Size(95, 27);
            this.gn_id.TabIndex = 42;
            this.gn_id.ValidatingType = typeof(int);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(483, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 24);
            this.label10.TabIndex = 41;
            this.label10.Text = "ID жанра";
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources.BackLogin;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gn_id);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bk_avail);
            this.Controls.Add(this.bk_publishyear);
            this.Controls.Add(this.bk_pages);
            this.Controls.Add(this.au_id);
            this.Controls.Add(this.cv_id);
            this.Controls.Add(this.pb_id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bk_id);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bk_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddBook";
            this.Text = "AddUserForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bk_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox bk_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox pb_id;
        private System.Windows.Forms.MaskedTextBox cv_id;
        private System.Windows.Forms.MaskedTextBox au_id;
        private System.Windows.Forms.MaskedTextBox bk_pages;
        private System.Windows.Forms.MaskedTextBox bk_publishyear;
        private System.Windows.Forms.CheckBox bk_avail;
        private System.Windows.Forms.MaskedTextBox gn_id;
        private System.Windows.Forms.Label label10;
    }
}