using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAppRandomNumberGuessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int rastgele, sayac;
        private void btn_start_Click(object sender, EventArgs e)
        {
           
           
            // MessageBox.Show("Start");	
            lbl_durum.Visible = true;
            txt_sayi.Text = "";
            btn_control.Enabled = true;
            Random random = new Random();
            rastgele = random.Next(0, 100);
            sayac = 10;
           
            lbl_durum.Text = rastgele.ToString();
            lbl_durum.Text = "";
            lbl_sayac.Text = sayac.ToString() + " Hakkınız var";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_durum.BackColor = Color.Orange;
            lbl_durum.Visible = false;
            btn_control.Enabled = false;
            lbl_sayac.Text = "10 Hakkınız var";

        }

        private void btn_control_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Kontrol");
            if (txt_sayi.Text == "")
            {
                lbl_durum.Visible = true;
                lbl_durum.Text = "Sayı Giriniz!!";
                
            }
            else
            {
                int girilensayi = Convert.ToInt32(txt_sayi.Text);
                if (girilensayi < rastgele)
                {
                    lbl_durum.Text = "Arttır";
                    sayac--;
                    lbl_sayac.Text = sayac.ToString() + " Hakkınız kaldı";
                }
                else if (girilensayi > rastgele)
                {
                    lbl_durum.Text = "Azalt";
                    sayac--;
                    lbl_sayac.Text = sayac.ToString() + " Hakkınız kaldı";
                }
                else
                {
                    lbl_durum.BackColor = Color.Green;
                    lbl_durum.Text = "Kazandınız";
                    btn_control.Enabled = false;
                }
            }
            if (sayac == 0)
            {
                lbl_durum.BackColor = Color.Red;
                lbl_durum.Text = "Kazanamadın";
                btn_control.Enabled = false;



                if (MessageBox.Show("Kaybettiniz ", "Tekrar oynamak İstermisiniz", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                return;

            }


        }
    }



}


