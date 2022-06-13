using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaktarKezeloRendszer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bevet_btn_Click(object sender, EventArgs e)
        {
            Bevetelezes bevetelezes = new Bevetelezes();
            bevetelezes.Show();
        }

        private void Keszlet_btn_Click(object sender, EventArgs e)
        {
            KeszletLekerdezes keszletLekerdezes = new KeszletLekerdezes();
            keszletLekerdezes.Show();
        }

        private void TetelMozg_btn_Click(object sender, EventArgs e)
        {
            TetelMozgatas tetelMozgatas = new TetelMozgatas();
            tetelMozgatas.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BeszallitokBongeszese beszallitokBongeszese = new BeszallitokBongeszese();
            beszallitokBongeszese.Show();
        }

        private void Kilep_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UjTetelFelviteleTorzsbe ujTetelFelv = new UjTetelFelviteleTorzsbe();
            ujTetelFelv.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BeszallitoFelvitele ujBeszFelv = new BeszallitoFelvitele();
            ujBeszFelv.Show();
        }

        private void Tarhely_Letre_btn_Click(object sender, EventArgs e)
        {
            RaktarhelyLetrehoz raktLetrehoz = new RaktarhelyLetrehoz();
            raktLetrehoz.Show();
        }

        private void TarhelyBongeszes_btn_Click(object sender, EventArgs e)
        {
            TarhelyBongeszes TarhelyBongeszes = new TarhelyBongeszes();
            TarhelyBongeszes.Show();
        }
    }
}
