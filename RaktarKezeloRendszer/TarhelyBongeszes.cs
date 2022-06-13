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
    public partial class TarhelyBongeszes : Form
    {
        private List<Raktarhely> tarhelyLista = new List<Raktarhely>();
        public TarhelyBongeszes()
        {
            InitializeComponent();
        }
        string ConnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tamas\Documents\WhDB.mdf;Integrated Security=True;Connect Timeout=30";

        private void TarhelyBongeszes_Load(object sender, EventArgs e)
        {
            string sqlSelect = "Select * FROM Raktarhelyek";
            SqlDataAdapter da = new SqlDataAdapter(sqlSelect, ConnStr);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                string tarhelyNeve = (string)item["RaktarhelyNeve"];
                string tarhelyTipusa = (string)item["RaktarHelyTipusa"];
                Raktarhely tarhely = new Raktarhely(tarhelyNeve, tarhelyTipusa);
                tarhelyLista.Add(tarhely);
            }

            TarhelyBong_dgw.DataSource = tarhelyLista;
        }

        private void Keres_btn_Click(object sender, EventArgs e)
        {
            string sqlKeres = "SELECT * FROM Raktarhelyek WHERE RaktarhelyNeve LIKE '%" + Kereso_txtbx.Text + "%' ";

            SqlConnection sqlConn = new SqlConnection(ConnStr);
            sqlConn.Open();
            SqlCommand sqlCom = new SqlCommand(sqlKeres, sqlConn);
            sqlCom.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(sqlKeres, ConnStr);
            DataTable dt = new DataTable();
            da.Fill(dt);
            TarhelyBong_dgw.DataSource = dt;
            sqlConn.Close();
        }

        private void Kilep_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

