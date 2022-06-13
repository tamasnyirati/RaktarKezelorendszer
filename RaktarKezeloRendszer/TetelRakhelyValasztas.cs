using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaktarKezeloRendszer
{
    public partial class TetelRakhelyValasztas : Form
    {
        public TetelRakhelyValasztas()
        {
            InitializeComponent();
            

        }

        public string cikkszam;
        public string megnevezes;
        public int mennyiseg;
        public string raktarhelyNeve;
        public string mennyEgys;
        public TetelRakhelyValasztas(string cikkszam)
        {
            InitializeComponent();
            modCikkszam = cikkszam;
        }

        string connStr = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tamas\Documents\WhDB.mdf;Integrated Security=True;Connect Timeout=30");
        string modCikkszam;

        private void TetelRakhelyValasztas_Load(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Red;

            string sqlSelect = $"SELECT * FROM Tetelek WHERE Cikkszam = '{modCikkszam}'";
            SqlConnection sqlConn = new SqlConnection(connStr);
            sqlConn.Open();
            SqlCommand sqlCom = new SqlCommand(sqlSelect, sqlConn);
            sqlCom.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlSelect, connStr);
            da.Fill(dt);

            RaktTetel_dgw.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (RaktTetel_dgw.SelectedRows.Count>0)
            {
                int selectedrowindex = RaktTetel_dgw.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = RaktTetel_dgw.Rows[selectedrowindex];

                cikkszam = Convert.ToString(selectedRow.Cells["Cikkszam"].Value);
                megnevezes = Convert.ToString(selectedRow.Cells["Megnevezes"].Value);
                mennyiseg = Convert.ToInt32(selectedRow.Cells["Mennyiseg"].Value);
                mennyEgys = Convert.ToString(selectedRow.Cells["MennyisegiEgyseg"].Value);
                raktarhelyNeve = Convert.ToString(selectedRow.Cells["raktarhelyNeve"].Value);
                
                this.Close();
                
            }
            
        }
    }
}
