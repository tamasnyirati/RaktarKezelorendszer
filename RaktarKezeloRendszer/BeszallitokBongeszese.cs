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
    public partial class BeszallitokBongeszese : Form
    {
        private List<Beszallito> beszallitoLista = new List<Beszallito>();
        public BeszallitokBongeszese()
        {
            InitializeComponent();
        }
        string ConnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tamas\Documents\WhDB.mdf;Integrated Security=True;Connect Timeout=30";
        private void BeszallitokBongeszese_Load(object sender, EventArgs e)
        {
            string sqlSelect = "Select * FROM Beszallitok";
            SqlDataAdapter da = new SqlDataAdapter(sqlSelect, ConnStr);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                string beszallitoNeve = (string)item["BeszallitoNeve"];
                string beszallitottTermekTipus = (string)item["BeszallitottTermekekTipusa"];
                Beszallito beszallito = new Beszallito (beszallitoNeve, beszallitottTermekTipus);
                beszallitoLista.Add(beszallito);
            }
           
            Beszallito_dgw.DataSource = beszallitoLista;
        }

        private void Bezar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Keresd_btn_Click(object sender, EventArgs e)
        {
            string sqlKeres = "SELECT * FROM Beszallitok WHERE BeszallitoNeve LIKE '%" + Kereso_txtbx.Text + "%' ";
            
            SqlConnection sqlConn = new SqlConnection(ConnStr);
            sqlConn.Open();
            SqlCommand sqlCom = new SqlCommand(sqlKeres, sqlConn);
            sqlCom.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(sqlKeres, ConnStr);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Beszallito_dgw.DataSource = dt;
            sqlConn.Close();
        }
    }
}
