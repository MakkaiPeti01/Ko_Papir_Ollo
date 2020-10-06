using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ko_Papir_Ollo
{
    public partial class FrmFo : Form
    {
        public int Jatekos { get; private set; }
        public int Szgep { get; private set; }
        public FrmFo()
        {

            InitializeComponent();
            KezdetiBeallitas();
        }
        private void FrmFo_Load(object sender, EventArgs e)
        {

        }   
        private void btn_kilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ujjatek_Click(object sender, EventArgs e)
        {
            KezdetiBeallitas();
        }

        private void KezdetiBeallitas()
        {
            lbl_gyoztes.Text = "";
            lbl_jatekos.Text = "0";
            lbl_Szamitogep.Text = "0";
        }
        private void btn_ko_Click(object sender, EventArgs e)
        {
            pb_jatekos.Image = Image.FromFile("ko.jpg");
            Fordulo(1);
        }
        private void btn_papir_Click(object sender, EventArgs e)
        {
            pb_jatekos.Image = Image.FromFile("papir.jpg");
            Fordulo(2);
        }

        private void btn_ollo_Click(object sender, EventArgs e)
        {
            pb_jatekos.Image = Image.FromFile("ollo.jpg");
            Fordulo(3);
        }
        private void EredmenyBeallitas()
        {
            lbl_jatekos.Text = Jatekos.ToString();
            lbl_Szamitogep.Text = Szgep.ToString();
        }
        private void Fordulo(int jatekos)
        {
            Random r = new Random();
            int gep = r.Next(1, 4);
            switch (gep)
            {
                case 1:
                    pb_szamitogep.Image = Image.FromFile("ko.jpg");
                    break;
                case 2:
                    pb_szamitogep.Image = Image.FromFile("papir.jpg");
                    break;
                case 3:
                    pb_szamitogep.Image = Image.FromFile("ollo.jpg");
                    break;
            }
            if (gep==jatekos)
            {
                Jatekos++;
                Szgep++;
                lbl_gyoztes.Text=("Döntetlen");
            }
            else
            {
                if (jatekos == 1 && gep == 3 || jatekos == 2 && gep == 1 || jatekos == 3 && gep == 2)
                {
                    Jatekos++;
                    lbl_gyoztes.Text = ("Játékos nyert");
                }
                else
                { 
                    Szgep++;
                    lbl_gyoztes.Text = ("Gép nyert");
                }
            }
            EredmenyBeallitas();
        }
    }
}
