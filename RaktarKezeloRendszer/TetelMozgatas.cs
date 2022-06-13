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
    public partial class TetelMozgatas : Form
    {

        public TetelMozgatas()
        {
            InitializeComponent();
            TarhelyeketBetolt();
            CikkszamokatBetolt();
        }
        string connStr = (@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tamas\Documents\WhDB.mdf;Integrated Security = True; Connect Timeout = 30");
        string Cikkszam;
        string Megnevezes;
        int Mennyiseg;
        string MennyisegiEgyseg;
        int Ar;
        string BeszallitoNeve;
        string RaktarhelyNeve;
        string ujRaktarhely;
        Tetel modTetel;
        Tetel ujTetel;
        List<Tetel> tetelLista = new List<Tetel>();



        private void Bezar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Kereso_btn_Click(object sender, EventArgs e)
        {
            DataTable dt = dbbolAdatokatBetolt();

            if (dt.Rows.Count == 1)
            {
                AdatokatBetolt(dt);

            }

            else if (dt.Rows.Count > 1)
            {
                TetelTarhelyValasztasBetolt(dt);

            }

            else
            {
                Info_lbl.Text = "Hibás cikkszám! Próbáld újra!";
                Info_lbl.Visible = true;
            }
        }

        private DataTable dbbolAdatokatBetolt()
        {
            
            Info_lbl.Visible = false;

            Cikkszam = Cikkszam_cbx.Text.ToUpper();
            string sqlSelect = $"SELECT * FROM Tetelek WHERE Cikkszam = '{Cikkszam}'";
            SqlConnection sqlConn = new SqlConnection(connStr);
            sqlConn.Open();
            SqlCommand sqlCom = new SqlCommand(sqlSelect, sqlConn);
            sqlCom.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlSelect, connStr);
            da.Fill(dt);
            return dt;
        }

        private void Mozgatas_btn_Click(object sender, EventArgs e)
        {
           
                Info_lbl.Visible = false;
                int athelyezesreVaroMenny = Int32.Parse(AthelyezMenny.Text);
                ujRaktarhely = ujTarhelyCbx.SelectedItem.ToString();
                modTetel.Mennyiseg = Convert.ToInt32(Mennyiseg_txtbx.Text);
                if (modTetel.Mennyiseg == athelyezesreVaroMenny)
                {
                    TarhelyetModosit();
                }
                else if (modTetel.Mennyiseg > athelyezesreVaroMenny)
                {
                    ModositandobolKivonEsUjRekordotHozLetre(athelyezesreVaroMenny);
                }
                else
                {
                    Info_lbl.Text = "Az átmozgatásra váró mennyiség nagyobb, mint a raktárhelyen lévő!";
                    Info_lbl.ForeColor = Color.Red;
                    Info_lbl.Visible = true;
                }
    
            duplazodasEllenorzese();
        }

        private void TetelTarhelyValasztasBetolt(DataTable dt)
        {
            foreach (DataRow item in dt.Rows)
            {
                Cikkszam = (string)item["Cikkszam"];
                Megnevezes = (string)item["Megnevezes"];
                Mennyiseg = (int)item["Mennyiseg"];
                MennyisegiEgyseg = (string)item["MennyisegiEgyseg"];
                Ar = (int)item["Ar"];
                BeszallitoNeve = (string)item["BeszallitoNeve"];
                RaktarhelyNeve = (string)item["RaktarhelyNeve"];

                modTetel = new Tetel(Cikkszam, Megnevezes, Mennyiseg, MennyisegiEgyseg, Ar, BeszallitoNeve, RaktarhelyNeve);
                tetelLista.Add(modTetel);

            }
            TetelRakhelyValasztas rakhelyValasztas = new TetelRakhelyValasztas(tetelLista[0].Cikkszam.ToString());
            if (rakhelyValasztas.ShowDialog(this) == DialogResult.OK)
            {
                Cikkszam_cbx.Text = rakhelyValasztas.cikkszam;
                Megnevezes_txtbx.Text = rakhelyValasztas.megnevezes;
                JelenlegiTarhely_txtbx.Text = rakhelyValasztas.raktarhelyNeve;
                int menny = Convert.ToInt32(rakhelyValasztas.mennyiseg);
                Mennyiseg_txtbx.Text = menny.ToString();
                MennyEgys_lbl.Text = rakhelyValasztas.mennyEgys;

                Megnevezes_txtbx.Visible = true;
                JelenlegiTarhely_txtbx.Visible = true;
                Mennyiseg_txtbx.Visible = true;
                MennyEgys_lbl.Visible = true;

            }
        }

        private void AdatokatBetolt(DataTable dt)
        {
            foreach (DataRow item in dt.Rows)
            {
                Cikkszam = (string)item["Cikkszam"];
                Megnevezes = (string)item["Megnevezes"];
                Mennyiseg = (int)item["Mennyiseg"];
                MennyisegiEgyseg = (string)item["MennyisegiEgyseg"];
                Ar = (int)item["Ar"];
                BeszallitoNeve = (string)item["BeszallitoNeve"];
                RaktarhelyNeve = (string)item["RaktarhelyNeve"];

                modTetel = new Tetel(Cikkszam, Megnevezes, Mennyiseg, MennyisegiEgyseg, Ar, BeszallitoNeve, RaktarhelyNeve);

                Megnevezes_txtbx.Text = Megnevezes;
                JelenlegiTarhely_txtbx.Text = RaktarhelyNeve;
                Mennyiseg_txtbx.Text = Mennyiseg.ToString();
                MennyEgys_lbl.Text = MennyisegiEgyseg;

                Megnevezes_txtbx.Visible = true;
                JelenlegiTarhely_txtbx.Visible = true;
                Mennyiseg_txtbx.Visible = true;
                MennyEgys_lbl.Visible = true;

            }
        }

        private void TarhelyeketBetolt()
        {
            SqlConnection tarhelyConn = new SqlConnection(connStr);
            SqlCommand sqlTarhelyComm = new SqlCommand("SELECT RaktarhelyNeve FROM Raktarhelyek", tarhelyConn);
            tarhelyConn.Open();
            SqlDataReader sqlReader = sqlTarhelyComm.ExecuteReader();

            while (sqlReader.Read())
            {
                ujTarhelyCbx.Items.Add(sqlReader["RaktarhelyNeve"].ToString());
            }
            sqlReader.Close();
            tarhelyConn.Close();
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

    

        private void ModositandobolKivonEsUjRekordotHozLetre(int athelyezesreVaroMenny)
        {
            string sqlInsert = "INSERT INTO Tetelek (Cikkszam, Megnevezes, Mennyiseg, MennyisegiEgyseg, Ar, BeszallitoNeve, RaktarhelyNeve) VALUES (@Cikkszam, @Megnevezes, @athelyezesreVaroMenny, @MennyisegiEgyseg, @Ar, @BeszallitoNeve, @UjRaktarhely)";
            SqlConnection sqlConn = new SqlConnection(connStr);
            sqlConn.Open();
            SqlCommand sqlCom = new SqlCommand(sqlInsert, sqlConn);
            sqlCom.Parameters.Add("@Cikkszam", SqlDbType.NChar).Value = Cikkszam;
            sqlCom.Parameters.Add("@Megnevezes", SqlDbType.NVarChar).Value = Megnevezes;
            sqlCom.Parameters.Add("@athelyezesreVaroMenny", SqlDbType.Int).Value = athelyezesreVaroMenny;
            sqlCom.Parameters.Add("@MennyisegiEgyseg", SqlDbType.NVarChar).Value = MennyisegiEgyseg;
            sqlCom.Parameters.Add("@Ar", SqlDbType.Int).Value = Ar;
            sqlCom.Parameters.Add("@BeszallitoNeve", SqlDbType.NVarChar).Value = BeszallitoNeve;
            sqlCom.Parameters.Add("@UjRaktarhely", SqlDbType.NVarChar).Value = ujRaktarhely;
            sqlCom.ExecuteNonQuery();



            int maradtMennyiseg = modTetel.Mennyiseg - athelyezesreVaroMenny;
            string sqlUpdate = $"UPDATE Tetelek SET Mennyiseg = @Mennyiseg WHERE Cikkszam = @Cikkszam AND RaktarhelyNeve = @RaktarhelyNeve ";

            SqlCommand sqlCom2 = new SqlCommand(sqlUpdate, sqlConn);
            sqlCom2.Parameters.Add("@Cikkszam", SqlDbType.NChar).Value = Cikkszam;
            sqlCom2.Parameters.Add("@Mennyiseg", SqlDbType.Int).Value = maradtMennyiseg;
            sqlCom2.Parameters.Add("@RaktarhelyNeve", SqlDbType.NVarChar).Value = JelenlegiTarhely_txtbx.Text;
            sqlCom2.ExecuteNonQuery();
            sqlConn.Close();

            Info_lbl.Text = "Az átmozgatás sikerült!";
            Info_lbl.ForeColor = Color.Green;
            Info_lbl.Visible = true;
        }

        private void TarhelyetModosit()
        {
            string sqlUpdate = $"UPDATE Tetelek SET RaktarhelyNeve = '{ujRaktarhely}' WHERE Cikkszam ='{modTetel.Cikkszam}' ";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand sqlCom = new SqlCommand(sqlUpdate, conn);
            sqlCom.ExecuteNonQuery();
            conn.Close();
            Info_lbl.Visible = true;
            Info_lbl.ForeColor = Color.Green;
        }

        private void duplazodasEllenorzese()
        {
            string sqlRaktarhelySelect = $"SELECT * From Tetelek WHERE RaktarhelyNeve = '{ujRaktarhely}' AND Cikkszam = '{Cikkszam}'";
            SqlConnection connect = new SqlConnection(connStr);
            connect.Open();
            SqlCommand comm = new SqlCommand(sqlRaktarhelySelect, connect);
            comm.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlRaktarhelySelect, connect);
            dataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 1)
            {
                string slqQuery = $"SELECT * FROM Tetelek WHERE Cikkszam = '{Cikkszam}' AND RaktarhelyNeve = '{ujRaktarhely}'";
                SqlConnection con = new SqlConnection(connStr);
                con.Open();
                SqlCommand sqlCommand = new SqlCommand(slqQuery, con);
                sqlCommand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(slqQuery, connStr);
                da.Fill(dt);

                int ujMennyiseg = 0;
                foreach (DataRow item in dt.Rows)
                {
                    Cikkszam = (string)item["Cikkszam"];
                    Megnevezes = (string)item["Megnevezes"];
                    Mennyiseg = (int)item["Mennyiseg"];
                    MennyisegiEgyseg = (string)item["MennyisegiEgyseg"];
                    Ar = (int)item["Ar"];
                    BeszallitoNeve = (string)item["BeszallitoNeve"];
                    RaktarhelyNeve = (string)item["RaktarhelyNeve"];

                    ujTetel = new Tetel(Cikkszam, Megnevezes, Mennyiseg, MennyisegiEgyseg, Ar, BeszallitoNeve, RaktarhelyNeve);
                    ujMennyiseg += ujTetel.Mennyiseg;
                }
                string sqlDel = $"DELETE FROM Tetelek WHERE Cikkszam = '{Cikkszam}' AND RaktarhelyNeve = '{ujRaktarhely}'";
                SqlCommand sqlCommand2 = new SqlCommand(sqlDel, con);
                sqlCommand2.ExecuteNonQuery();

                string sqlInsertInto = $"INSERT INTO [dbo].[Tetelek] (Cikkszam, Megnevezes, Mennyiseg, MennyisegiEgyseg, Ar, BeszallitoNeve, RaktarhelyNeve)" +
                         "VALUES (@Cikkszam, @Megnevezes, @Mennyiseg, @MennyisegiEgyseg, @Ar, @BeszallitoNeve, @RaktarhelyNeve)";

                SqlCommand sqlCommand3 = new SqlCommand(sqlInsertInto, con);
                sqlCommand3.Parameters.Add("@Cikkszam", SqlDbType.NVarChar).Value = ujTetel.Cikkszam;
                sqlCommand3.Parameters.Add("@Megnevezes", SqlDbType.NVarChar).Value = ujTetel.Megnevezes;
                sqlCommand3.Parameters.Add("@Mennyiseg", SqlDbType.Int).Value = ujMennyiseg;
                sqlCommand3.Parameters.Add("@MennyisegiEgyseg", SqlDbType.NVarChar).Value = ujTetel.MennyisegiEgyseg;
                sqlCommand3.Parameters.Add("@Ar", SqlDbType.Int).Value = ujTetel.Ar;
                sqlCommand3.Parameters.Add("@BeszallitoNeve", SqlDbType.NVarChar).Value = ujTetel.BeszallitoNeve;
                sqlCommand3.Parameters.Add("@RaktarhelyNeve", SqlDbType.NVarChar).Value = ujTetel.RaktarhelyNeve;

                sqlCommand3.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
