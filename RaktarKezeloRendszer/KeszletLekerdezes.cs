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
    public partial class KeszletLekerdezes : Form
    {
            private List<Tetel> tetelLista = new List<Tetel>();
        public KeszletLekerdezes()
        {
            InitializeComponent();
        }

            string ConnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tamas\Documents\WhDB.mdf;Integrated Security=True;Connect Timeout=30";
        

        private void KeszletLekerdezes_Load(object sender, EventArgs e)
        {
            

            string sql = "SELECT * FROM Tetelek";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnStr);
            DataTable dt = new DataTable();
            da.Fill(dt);
            

            foreach (DataRow item in dt.Rows)
            {
                string cikkszam = (string)item["Cikkszam"];
                string megnevezes = (string)item["Megnevezes"];
                int mennyiseg = (int)item["Mennyiseg"];
                string mennyisegiEgyseg = (string)item["MennyisegiEgyseg"];
                int ar = (int)item["Ar"];
                string beszallitoNeve = (string)item["BeszallitoNeve"];
                string raktarHelyNeve = (item["RaktarhelyNeve"]).ToString();
                
                Tetel tetel = new Tetel(cikkszam, megnevezes, mennyiseg, mennyisegiEgyseg, ar, beszallitoNeve, raktarHelyNeve);
                tetelLista.Add(tetel);
            }

            Keszlet_dgw.DataSource = tetelLista;
            Kereso_cbx.Text = "--Válassz--";
        }

        private void Keresd_btn_Click(object sender, EventArgs e)
        {   
            if(Kereso_cbx.Text == "--Válassz--" || Kereso_txtbx.Text == "") {
                MessageBox.Show("Válaszd ki, hogy milyen típust szeretnél keresni!");
            }

            else if(Kereso_cbx.Text == "--Válassz--" && Kereso_txtbx.Text == "")
            {
                MessageBox.Show("A keresősávot nem töltötted ki vagy nem választottál típust!");
            
            }

            else { 

            string sqlKeres = "";
            if (Kereso_cbx.SelectedIndex == 0)
            {
                 sqlKeres = "SELECT * FROM Tetelek WHERE Megnevezes LIKE '%" + Kereso_txtbx.Text + "%' ";
                
            }
            else if (Kereso_cbx.SelectedIndex == 1)
            {
                sqlKeres = "SELECT * FROM Tetelek WHERE Cikkszam LIKE '%" + Kereso_txtbx.Text + "%' ";
            }
           
            SqlConnection sqlConn = new SqlConnection(ConnStr);
            sqlConn.Open();
            SqlCommand sqlCom = new SqlCommand(sqlKeres, sqlConn);
            sqlCom.Connection = sqlConn;
            sqlCom.CommandType = CommandType.Text;
            sqlCom.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(sqlKeres, ConnStr);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Keszlet_dgw.DataSource = dt;
            sqlConn.Close();
        }
        }

        private void Bezar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
