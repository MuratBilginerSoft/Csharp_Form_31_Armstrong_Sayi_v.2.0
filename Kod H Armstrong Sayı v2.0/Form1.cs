using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kod_H_Armstrong_Sayı_v2._0
{
    public partial class Form1 : Form
    {
        #region Değişkenler

        int Durum = 0;


        int Sayi;
        double A, Toplam = 0;
        string S1, S2;

        #endregion

        #region Metodlar

        public void ArmstrongSayi(int i)
        {
            Toplam = 0;
            S1 = i.ToString();
            Sayi = i;

            foreach (char C in S1)
            {
                S2 = C.ToString();
                A = Convert.ToDouble(S2);
                Toplam += (Math.Pow(A, 3));
            }
        
        }

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LblASM_Click(object sender, EventArgs e)
        {
            Durum = 0;

            LblASM.BackColor = Color.White;
            LblASM.ForeColor = Color.Navy;

            LblASL.BackColor = Color.DeepSkyBlue;
            LblASL.ForeColor = Color.White;

            tabControl1.SelectedIndex = 0;
        }

        private void LblASL_Click(object sender, EventArgs e)
        {
            Durum = 1;

            LblASL.BackColor = Color.White;
            LblASL.ForeColor = Color.Navy;

            LblASM.BackColor = Color.DeepSkyBlue;
            LblASM.ForeColor = Color.White;

            tabControl1.SelectedIndex = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblASM.BackColor = Color.White;
            LblASM.ForeColor = Color.Navy;

            LblASL.BackColor = Color.DeepSkyBlue;
            LblASL.ForeColor = Color.White;

            tabControl1.SelectedIndex = 0;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex==0)
            {
                Durum = 0;

                LblASM.BackColor = Color.White;
                LblASM.ForeColor = Color.Navy;

                LblASL.BackColor = Color.DeepSkyBlue;
                LblASL.ForeColor = Color.White;
            }

            else
            {
                Durum = 1;

                LblASL.BackColor = Color.White;
                LblASL.ForeColor = Color.Navy;

                LblASM.BackColor = Color.DeepSkyBlue;
                LblASM.ForeColor = Color.White;
            }
        }

        private void BtnKntrl_Click(object sender, EventArgs e)
        {
            Sayi = Convert.ToInt32(MTBSayi.Text);

            ArmstrongSayi(Sayi);
           

            if (Sayi == Toplam)
            {
                LblSonuc.Text = Sayi + " Armstrong Sayıdır";
            }

            else
            {
                LblSonuc.Text = Sayi + " Armstrong Sayı Değildir";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Toplam = 0;

            for (int i = 100; i < 1000; i++)
            {
                ArmstrongSayi(i);

                if (Sayi == Toplam)
                {

                    listBox1.Items.Add(Sayi);
                }
            }
        }
        
    }
}
