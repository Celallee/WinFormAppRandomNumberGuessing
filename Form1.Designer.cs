﻿namespace WinFormAppRandomNumberGuessing
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_sayac = new System.Windows.Forms.Label();
            this.lbl_durum = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_control = new System.Windows.Forms.Button();
            this.txt_sayi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(38, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOĞRU SAYIYI BUL";
            // 
            // lbl_sayac
            // 
            this.lbl_sayac.AutoSize = true;
            this.lbl_sayac.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sayac.Location = new System.Drawing.Point(151, 102);
            this.lbl_sayac.Name = "lbl_sayac";
            this.lbl_sayac.Size = new System.Drawing.Size(78, 29);
            this.lbl_sayac.TabIndex = 1;
            this.lbl_sayac.Text = "Sayac";
            // 
            // lbl_durum
            // 
            this.lbl_durum.AutoSize = true;
            this.lbl_durum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_durum.Location = new System.Drawing.Point(151, 182);
            this.lbl_durum.Name = "lbl_durum";
            this.lbl_durum.Size = new System.Drawing.Size(84, 29);
            this.lbl_durum.TabIndex = 2;
            this.lbl_durum.Text = "Durum";
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_start.Location = new System.Drawing.Point(12, 320);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(112, 69);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "Başlat";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_control
            // 
            this.btn_control.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_control.Location = new System.Drawing.Point(156, 320);
            this.btn_control.Name = "btn_control";
            this.btn_control.Size = new System.Drawing.Size(107, 69);
            this.btn_control.TabIndex = 4;
            this.btn_control.Text = "Kontrol";
            this.btn_control.UseVisualStyleBackColor = true;
            this.btn_control.Click += new System.EventHandler(this.btn_control_Click);
            // 
            // txt_sayi
            // 
            this.txt_sayi.Location = new System.Drawing.Point(102, 242);
            this.txt_sayi.Name = "txt_sayi";
            this.txt_sayi.Size = new System.Drawing.Size(202, 20);
            this.txt_sayi.TabIndex = 5;
            this.txt_sayi.Text = "Sayı Giriniz!!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 450);
            this.Controls.Add(this.txt_sayi);
            this.Controls.Add(this.btn_control);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_durum);
            this.Controls.Add(this.lbl_sayac);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "RandomNumberGuessing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_sayac;
        private System.Windows.Forms.Label lbl_durum;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_control;
        private System.Windows.Forms.TextBox txt_sayi;
    }
}

