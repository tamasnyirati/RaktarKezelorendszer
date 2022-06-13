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
    public partial class RaktarhelyLetrehoz : Form
    {
        public RaktarhelyLetrehoz()
        {
            InitializeComponent();
            TarhelyTip_cbx.Items.Insert(0, "Válassz!");
            TarhelyTip_cbx.SelectedIndex = 0;
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tamas\Documents\WhDB.mdf;Integrated Security=True;Connect Timeout=30");
       
        
        private void Letrehoz_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Info_lbl.Visible = false;
                string tarhelyNeve = TarhelyNeve_txtbx.Text;
                string tarhelyTipusa = TarhelyTip_cbx.SelectedItem.ToString();


                con.Open();
                SqlCommand ellenorzes = new SqlCommand($"SELECT RaktarhelyNeve FROM Raktarhelyek WHERE RaktarhelyNeve = '{tarhelyNeve}'", con);

                string sqlEredmeny = (string)ellenorzes.ExecuteScalar();
                if (sqlEredmeny != null)
                {
                    Info_lbl.Text = "A táhely már létezik az adatbázisban";
                    Info_lbl.ForeColor = Color.Red;
                    Info_lbl.Visible = true;
                }
               
                else if(TarhelyTip_cbx.SelectedIndex == 0)
                {
                    Info_lbl.Text = "Válassz tárhely típust!";
                    Info_lbl.ForeColor = Color.Red;
                    Info_lbl.Visible = true;
                }
                else
                {
                    string sqlInsertQuery = $"INSERT INTO [dbo].[RaktarHelyek] (RaktarhelyNeve, RaktarHelyTipusa) VALUES (@ujTarhely, @ujTarhelyTipus)";


                    SqlCommand sqlCom = new SqlCommand(sqlInsertQuery, con);
                    sqlCom.Parameters.Add("@ujTarhely", SqlDbType.NChar).Value = tarhelyNeve;
                    sqlCom.Parameters.Add("@ujTarhelyTipus", SqlDbType.NVarChar).Value = tarhelyTipusa;

                    sqlCom.ExecuteNonQuery();

                    Info_lbl.Text = "A táhely létrehozása sikerült!";
                    Info_lbl.ForeColor = Color.Green;
                    Info_lbl.Visible = true;
                }
                con.Close();
                TarhelyNeve_txtbx.Text = null;
                TarhelyTip_cbx.Text = null;
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
