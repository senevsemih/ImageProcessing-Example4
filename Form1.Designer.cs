﻿namespace görüntüIslemeO4
{
    partial class Form1
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
            this.bnt_gray = new System.Windows.Forms.Button();
            this.btn_bitmap = new System.Windows.Forms.Button();
            this.btn_erosion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.setpix1 = new System.Windows.Forms.Button();
            this.setpix2 = new System.Windows.Forms.Button();
            this.tersSim = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bnt_gray
            // 
            this.bnt_gray.Location = new System.Drawing.Point(45, 464);
            this.bnt_gray.Name = "bnt_gray";
            this.bnt_gray.Size = new System.Drawing.Size(120, 46);
            this.bnt_gray.TabIndex = 0;
            this.bnt_gray.Text = "GrayScale";
            this.bnt_gray.UseVisualStyleBackColor = true;
            this.bnt_gray.Click += new System.EventHandler(this.bnt_gray_Click);
            // 
            // btn_bitmap
            // 
            this.btn_bitmap.Location = new System.Drawing.Point(199, 464);
            this.btn_bitmap.Name = "btn_bitmap";
            this.btn_bitmap.Size = new System.Drawing.Size(121, 46);
            this.btn_bitmap.TabIndex = 1;
            this.btn_bitmap.Text = "Bitmap";
            this.btn_bitmap.UseVisualStyleBackColor = true;
            this.btn_bitmap.Click += new System.EventHandler(this.btn_bitmap_Click);
            // 
            // btn_erosion
            // 
            this.btn_erosion.Location = new System.Drawing.Point(354, 464);
            this.btn_erosion.Name = "btn_erosion";
            this.btn_erosion.Size = new System.Drawing.Size(118, 46);
            this.btn_erosion.TabIndex = 2;
            this.btn_erosion.Text = "Erosion";
            this.btn_erosion.UseVisualStyleBackColor = true;
            this.btn_erosion.Click += new System.EventHandler(this.btn_erosion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(45, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // setpix1
            // 
            this.setpix1.Location = new System.Drawing.Point(773, 45);
            this.setpix1.Name = "setpix1";
            this.setpix1.Size = new System.Drawing.Size(126, 42);
            this.setpix1.TabIndex = 4;
            this.setpix1.Text = "Set Piksel + ";
            this.setpix1.UseVisualStyleBackColor = true;
            this.setpix1.Click += new System.EventHandler(this.setpix1_Click);
            // 
            // setpix2
            // 
            this.setpix2.Location = new System.Drawing.Point(773, 93);
            this.setpix2.Name = "setpix2";
            this.setpix2.Size = new System.Drawing.Size(126, 42);
            this.setpix2.TabIndex = 5;
            this.setpix2.Text = "Set Piksel -";
            this.setpix2.UseVisualStyleBackColor = true;
            this.setpix2.Click += new System.EventHandler(this.setpix2_Click);
            // 
            // tersSim
            // 
            this.tersSim.Location = new System.Drawing.Point(773, 141);
            this.tersSim.Name = "tersSim";
            this.tersSim.Size = new System.Drawing.Size(126, 38);
            this.tersSim.TabIndex = 6;
            this.tersSim.Text = "Ters Simetri";
            this.tersSim.UseVisualStyleBackColor = true;
            this.tersSim.Click += new System.EventHandler(this.tersSim_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(596, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Değer : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(548, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Resim Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 544);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tersSim);
            this.Controls.Add(this.setpix2);
            this.Controls.Add(this.setpix1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_erosion);
            this.Controls.Add(this.btn_bitmap);
            this.Controls.Add(this.bnt_gray);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnt_gray;
        private System.Windows.Forms.Button btn_bitmap;
        private System.Windows.Forms.Button btn_erosion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button setpix1;
        private System.Windows.Forms.Button setpix2;
        private System.Windows.Forms.Button tersSim;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

