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
    public partial class Bevetelezes : Form
    {
        public Bevetelezes()
        {
            InitializeComponent();
            CikkszamokatBetolt();
        }
        string connStr = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tamas\Documents\WhDB.mdf;Integrated Security=True;Connect Timeout=30");



        private void button1_Click(object sender, EventArgs e)
        {
            Info_lbl.Visible = false;
            Adatokbetoltese();
        }

        private void Mentes_btn_Click(object sender, EventArgs e)
        {
            if (JelenlegiMenny_txtbx.Text == "")
            {
                JelenlegiMenny_txtbx.Text = "0";
            }
            int eredetiMennyiseg = Int32.Parse(JelenlegiMenny_txtbx.Text), menny;
            string Cikkszam;
            bool tryparse;
            BevittAdatEllenorzese(out eredetiMennyiseg, out Cikkszam, out menny, out tryparse);
            if (tryparse)
            {

                if (menny > 0)
                {
                    TetelBevetelezese(eredetiMennyiseg, Cikkszam);
                }
                else
                {
                    MegadottMennyiseg0Hibauzenet();
                }
            }
            else if(Cikkszam_cbx.Text == "")
            {
                Info_lbl.Text = "A cikkszám mező nincs kitöltve!";
                Info_lbl.Visible = true;
                Info_lbl.ForeColor = Color.Red;
            }
            else
            {
                MennyisegnelNemSzamotAdottMegHibauzenet();
            }

        }

        private void BevittAdatEllenorzese(out int eredetiMennyiseg, out string Cikkszam, out int menny, out bool tryparse)
        {
                JelenlegiMenny_txtbx.Text = "0";
               Cikkszam = Cikkszam_cbx.Text;
                eredetiMennyiseg = Int32.Parse(JelenlegiMenny_txtbx.Text);
            
                tryparse = int.TryParse(Mennyiseg_txtbx.Text, out menny);
                if(tryparse)
            {
                Info_lbl.Text = "ok!";
                Info_lbl.Visible = true;
            }
            else
            {
                Info_lbl.Text = "Nincs megadva bevételezendő mennyiség!";
                Info_lbl.Visible = true;
            }
                
            
           

        }

        private void Bezar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MennyisegnelNemSzamotAdottMegHibauzenet()
        {
            Info_lbl.Text = "A mennyiségnél számot adj meg! Próbáld újra!";
            Info_lbl.Visible = true;
            Info_lbl.ForeColor = Color.Red;
        }

        private void MegadottMennyiseg0Hibauzenet()
        {
            Info_lbl.Text = $"A bevételezendő mennyiség 0 {MennyEgys_txtbx.Text}! Adj meg nagyobb mennyiséget!";
            Info_lbl.Visible = true;
            Info_lbl.ForeColor = Color.Red;
        }

        private void TetelBevetelezese(int eredetiMennyiseg, string Cikkszam)
        {
            eredetiMennyiseg = Int32.Parse(JelenlegiMenny_txtbx.Text);
            int Mennyiseg = Int32.Parse(Mennyiseg_txtbx.Text) + eredetiMennyiseg;


            string sqlUpdate = $"Update Tetelek SET Mennyiseg = '{Mennyiseg}' WHERE Cikkszam = '{Cikkszam}' AND RaktarhelyNeve ='{Raktarhely_txtbx.Text}'";
            SqlConnection sqlConn = new SqlConnection(connStr);
            sqlConn.Open();
            SqlCommand sqlCom = new SqlCommand(sqlUpdate, sqlConn);
            sqlCom.ExecuteNonQuery();
            sqlConn.Close();

            JelenlegiMenny_txtbx.Text = Mennyiseg.ToString();

            Info_lbl.Text = "A bevételezés sikerült!";
            Info_lbl.Visible = true;
            Info_lbl.ForeColor = Color.Green;


            Megnevezes_txtbx.Text = null;
            MennyEgys_txtbx.Text = null;
            Ar_txtbx.Text = null;
            BeszNeve_txtbx.Text = null;
            JelenlegiMenny_txtbx.Text = null;
            Raktarhely_txtbx.Text = null;
            Mennyiseg_txtbx.Text = null;
        }

        
        public void Adatokbetoltese()
        {
            
                        string Cikkszam = Cikkszam_cbx.Text;
                        string sqlSelect = $"SELECT * FROM Tetelek WHERE Cikkszam = '{Cikkszam}'";
                        SqlConnection sqlConn = new SqlConnection(connStr);
                        sqlConn.Open();
                        SqlCommand sqlCom = new SqlCommand(sqlSelect, sqlConn);
                        sqlCom.ExecuteNonQuery();
                         DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(sqlSelect, connStr);
                        da.Fill(dt); 
                    
            if (dt.Rows.Count > 0)
            {

                foreach (DataRow item in dt.Rows)
                {
                    Cikkszam = (string)item["Cikkszam"];
                    string Megnevezes = (string)item["Megnevezes"];
                    string Mennyisegiegyseg = (string)item["MennyisegiEgyseg"];
                    int Ar = (int)item["Ar"];
                    string BeszallitoNeve = (string)item["BeszallitoNeve"];
                    int Mennyiseg = (int)item["Mennyiseg"];
                    string Raktarhely = (string)item["RaktarhelyNeve"];


                    Megnevezes_txtbx.Text = Megnevezes;
                    MennyEgys_txtbx.Text = Mennyisegiegyseg;
                    Ar_txtbx.Text = Ar.ToString();
                    BeszNeve_txtbx.Text = BeszallitoNeve;
                    JelenlegiMenny_txtbx.Text = Mennyiseg.ToString();
                    Raktarhely_txtbx.Text = Raktarhely;

                    Megnevezes_txtbx.Visible = true;
                    MennyEgys_txtbx.Visible = true;
                    Ar_txtbx.Visible = true;
                    BeszNeve_txtbx.Visible = true;
                    Mennyiseg_txtbx.Visible = true;
                    JelenlegiMenny_txtbx.Visible = true;
                    Raktarhely_txtbx.Visible = true;
                }


            }
            else
            {
                Info_lbl.Text = "Ilyen Cikkszám nem létezik! Adj meg egy másikat!";
                Info_lbl.Visible = true;
                Info_lbl.ForeColor = Color.Red;
            }
        }
        private void CikkszamokatBetolt()
        {
            SqlConnection cikkszamConn = new SqlConnection(connStr);
            SqlCommand sqlCikkszamComm = new SqlCommand("Select Cikkszam FROM Tetelek", cikkszamConn);
            cikkszamConn.Open();
            SqlDataReader cikkszamReader = sqlCikkszamComm.ExecuteReader();

            while (cikkszamReader.Read())
            {
                Cikkszam_cbx.Items.Add(cikkszamReader["Cikkszam"].ToString());
            }
            cikkszamReader.Close();
            cikkszamConn.Close();
        }
    }

}
