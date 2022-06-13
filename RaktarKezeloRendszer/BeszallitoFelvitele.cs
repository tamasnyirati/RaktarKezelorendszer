using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RaktarKezeloRendszer
{
    public partial class BeszallitoFelvitele : Form
    {
        public BeszallitoFelvitele()
        {
            InitializeComponent();
            BeszTermTip_cbx.Items.Insert(0, "Válassz!");
            BeszTermTip_cbx.SelectedIndex = 0;
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tamas\Documents\WhDB.mdf;Integrated Security=True;Connect Timeout=30");
        string ConnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tamas\Documents\WhDB.mdf;Integrated Security=True;Connect Timeout=30";


        private void Rogzit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string ujBeszallitoNeve = BeszallitoNev_txtbx.Text;
                string ujBeszallitoTermTip = BeszTermTip_cbx.SelectedItem.ToString();


                con.Open();
                SqlCommand ellenorzes = new SqlCommand($"SELECT BeszallitoNeve FROM Beszallitok WHERE BeszallitoNeve = '{ujBeszallitoNeve}'", con);
                string sqlEredmeny = (string)ellenorzes.ExecuteScalar();
                if (sqlEredmeny != null)
                {
                    Info_lbl.Text = "A beszállító már létezik a törzsadatokban";
                    Info_lbl.ForeColor = Color.Red;
                    Info_lbl.Visible = true;
                }
               else if(BeszTermTip_cbx.SelectedIndex == 0)
                {
                    Info_lbl.Text = "Válassz Termék típust!";
                    Info_lbl.ForeColor = Color.Red;
                    Info_lbl.Visible = true;
                }
                else

                {

                    string sqlInsertQuery = $"INSERT INTO [dbo].[Beszallitok] (BeszallitoNeve, BeszallitottTermekekTipusa) VALUES (@ujBeszallitoNeve, @ujBeszallitoTermTip)";

                    SqlConnection sqlConn = new SqlConnection(ConnStr);
                    sqlConn.Open();
                    SqlCommand sqlCom = new SqlCommand(sqlInsertQuery, sqlConn);
                    sqlCom.Parameters.Add("@ujBeszallitoNeve", SqlDbType.NChar).Value = ujBeszallitoNeve;
                    sqlCom.Parameters.Add("@ujBeszallitoTermTip", SqlDbType.NVarChar).Value = ujBeszallitoTermTip;

                    sqlCom.ExecuteNonQuery();
                    sqlConn.Close();

                    Info_lbl.Text = "A beszállító létehozása sikerült!";
                    Info_lbl.ForeColor = Color.Green;
                    Info_lbl.Visible = true;


                }
                con.Close();
            }
            catch (Exception)
            {

                Info_lbl.Text = "Nincs kitöltve minden adat!";
                Info_lbl.ForeColor = Color.Red;
                Info_lbl.Visible = true;
            }
        }
        private void Kilep_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
