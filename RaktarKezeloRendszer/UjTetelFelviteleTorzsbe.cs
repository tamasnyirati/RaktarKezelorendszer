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
    public partial class UjTetelFelviteleTorzsbe : Form
    {
        public UjTetelFelviteleTorzsbe()
        {
            InitializeComponent();
            MennyisegiEgyseg_cbx.Items.Insert(0, "Válassz!");
            MennyisegiEgyseg_cbx.SelectedIndex = 0;
        }
        
        private string Cikkszam = "";
        private string Megnevezes = "";
        private string MennyisegiEgyseg = "";
        private int mennyiseg = 0;
        private int Ar = 0;
        private string Beszallito;
        private string RaktarhelyNeve;
        
        
        private string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tamas\Documents\WhDB.mdf;Integrated Security=True;Connect Timeout=30";
        private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tamas\Documents\WhDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void Rogzit_btn_Click(object sender, EventArgs e)
        {
            Info_lbl.Visible = false;
            



            if (Cikkszam_txtbx.Text == "")
            {
                Info_lbl.Text = "A cikkszám mezőt üresen hagytad! Kérlek töltsd ki!";
                Info_lbl.ForeColor = Color.Red;
                Info_lbl.Visible = true;
            }

            else if (Megnevezes_txtbx.Text == "")
            {
                Info_lbl.Text = "A megnevezés mezőt üresen hagytad! Kérlek töltsd ki!";
                Info_lbl.ForeColor = Color.Red;
                Info_lbl.Visible = true;
            }
            else if (Ar_txtbx.Text == "")
            {
                Info_lbl.Text = "Az ár mezőt üresen hagytad! Kérlek töltsd ki!";
                Info_lbl.ForeColor = Color.Red;
                Info_lbl.Visible = true;
            }

            else if (Beszallito_cbx.Text == "")
            {
                Info_lbl.Text = "Nem választottál ki beszállítót Kérlek válassz egyet!";
                Info_lbl.ForeColor = Color.Red;
                Info_lbl.Visible = true;
            }
            else if (Raktarhely_txtbx.Text == "")
            {
                Info_lbl.Text = "A raktárhely mezőt üresen hagytad! Kérlek töltsd ki!";
                Info_lbl.ForeColor = Color.Red;
                Info_lbl.Visible = true;
            }
            else if (MennyisegiEgyseg_cbx.SelectedIndex == 0)
            {
                Info_lbl.Text = "Nem választottál Mennyiségi egységet!";
                Info_lbl.ForeColor = Color.Red;
                Info_lbl.Visible = true;
            }
            else
            {
                Cikkszam = Cikkszam_txtbx.Text;
                Megnevezes = Megnevezes_txtbx.Text;
                MennyisegiEgyseg = MennyisegiEgyseg_cbx.SelectedItem.ToString();
                Ar = Convert.ToInt32(Ar_txtbx.Text);
                Beszallito = Beszallito_cbx.SelectedItem.ToString();
                RaktarhelyNeve = Raktarhely_txtbx.Text;

                con.Open();
                SqlCommand raktarhelyEllenorzes = new SqlCommand($"SELECT RaktarhelyNeve FROM Raktarhelyek WHERE RaktarhelyNeve = '{RaktarhelyNeve}'", con);
                string sqlRaktarhelyEredmeny = (string)raktarhelyEllenorzes.ExecuteScalar();

                SqlCommand cikkszamEllenorzes = new SqlCommand($"SELECT Cikkszam FROM Tetelek WHERE Cikkszam = '{Cikkszam}'", con);
                string sqlCikkszamEredmeny = (string)cikkszamEllenorzes.ExecuteScalar();

                if (sqlRaktarhelyEredmeny != null && sqlCikkszamEredmeny == null)
                {
                    string sqlInsertQuery = $"INSERT INTO [dbo].[Tetelek] (Cikkszam, Megnevezes, Mennyiseg, MennyisegiEgyseg, Ar, BeszallitoNeve, RaktarhelyNeve)" +
                         "VALUES (@Cikkszam, @Megnevezes, @Mennyiseg, @MennyisegiEgyseg, @Ar, @BeszallitoNeve, @RaktarhelyNeve)";

                    SqlConnection sqlConn = new SqlConnection(connStr);
                    sqlConn.Open();
                    SqlCommand sqlCom = new SqlCommand(sqlInsertQuery, sqlConn);
                    sqlCom.Parameters.Add("@Cikkszam", SqlDbType.NVarChar).Value = Cikkszam;
                    sqlCom.Parameters.Add("@Megnevezes", SqlDbType.NVarChar).Value = Megnevezes;
                    sqlCom.Parameters.Add("@Mennyiseg", SqlDbType.Int).Value = mennyiseg;
                    sqlCom.Parameters.Add("@MennyisegiEgyseg", SqlDbType.NVarChar).Value = MennyisegiEgyseg;
                    sqlCom.Parameters.Add("@Ar", SqlDbType.Int).Value = Ar;
                    sqlCom.Parameters.Add("@BeszallitoNeve", SqlDbType.NVarChar).Value = Beszallito;
                    sqlCom.Parameters.Add("@RaktarhelyNeve", SqlDbType.NVarChar).Value = RaktarhelyNeve;

                    sqlCom.ExecuteNonQuery();
                    sqlConn.Close();
                    Info_lbl.Visible = true;
                    Info_lbl.ForeColor = Color.Green;

                    Cikkszam_txtbx.Text = null;
                    Megnevezes_txtbx.Text = null;
                    MennyisegiEgyseg_cbx = null;
                    Ar_txtbx.Text = null;
                    Beszallito_cbx = null;
                    Raktarhely_txtbx.Text = null;
                }
                else if (sqlCikkszamEredmeny != null)
                {
                    Info_lbl.Text = "Ezen a cikkszámon már van rögzítve termék az adatbázisban!";
                    Info_lbl.ForeColor = Color.Red;
                    Info_lbl.Visible = true;
                }
                else
                {
                    Info_lbl.Text = "A raktárhely nem létezik, adj meg másikat!";
                    Info_lbl.ForeColor = Color.Red;
                    Info_lbl.Visible = true;
                }
                con.Close();




            }
        }
        private void Bezar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
