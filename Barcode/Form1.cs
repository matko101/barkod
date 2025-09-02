using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;
using System.Security.AccessControl;
using System.Data;
using System.Timers;
using System;


namespace Barcode
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            object mySender = new object();
            EventArgs myEventArgs = new EventArgs();
            Global.TestLidhje(mySender, myEventArgs);
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            this.ActiveControl = bc_tb;
            bc_tb.Focus();
        }
        public static int count = 0;
        public async Task UpdateElement(double c, string k, string p, double cmsh, string n)
        {

            l_kod.Text = k;
            l_pers.Text = p;
            l_cmim.Text = c.ToString() + " Leke" + "  ";
            l_kod.Visible = true;
            l_pers.Visible = true;
            l_cmim.Visible = true;
            njesi.Text = n;
            if (cmsh > c)
            {
                Oferte.Visible = true;
            }
            else { Oferte.Visible = false; }
            if (Global.T_value <= 8000)
            {
                await Task.Delay(Global.T_value);
                count--;
            }

            else
            {
                await Task.Delay(Global.T_value);
                count++;

            }



            if (count == 0)
            {
                l_cmim.Visible = false;
                l_kod.Visible = false;
                l_pers.Visible = false;
                Oferte.Visible = false;
            }

        }

        public void Mbyll()
        {
            new System.Threading.Thread(CloseIt).Start();

            l_cmim.Visible = false;
            l_kod.Visible = false;
            l_pers.Visible = false;
            Oferte.Visible = false;
            MessageBox.Show("ARTIKULLI NUK EKZISTON");

        }

        public void CloseIt()
        {
            System.Threading.Thread.Sleep(2000);
            Microsoft.VisualBasic.Interaction.AppActivate(
                 System.Diagnostics.Process.GetCurrentProcess().Id);
            System.Windows.Forms.SendKeys.SendWait(" ");
        }

        private void bc_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string bc = bc_tb.Text;
                bc_tb.Text = "";
                using (SqlConnection con = new SqlConnection(Global.ConnectionString))
                {
                    con.Open();

                    using (SqlCommand getproduct = new SqlCommand("checkprice", con))
                    {
                        getproduct.CommandType = CommandType.StoredProcedure;

                        getproduct.Parameters.AddWithValue("@kodart0", bc);
                        getproduct.Parameters.AddWithValue("@kmag0", "M01");
                        getproduct.Parameters.AddWithValue("@kkli0", "");
                        getproduct.Parameters.AddWithValue("@getgjendje0", 0);
                        getproduct.Parameters.AddWithValue("@kthim0", 0);
                        getproduct.Parameters.AddWithValue("@koeficpeshore0", 1000);
                        getproduct.Parameters.AddWithValue("@sasipershitje0", 1);
                        getproduct.Parameters.AddWithValue("@KERKOMEKOD0", 0);

                        using (SqlDataReader reader = getproduct.ExecuteReader())
                        {



                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    double cmsh = (double)reader["CMSH"];
                                    string pershkrim = (string)reader["pershkrimartikull"];
                                    double cmimshitje = (double)reader["totali"];
                                    string njesi = (string)reader["njesiartikull"];
                                    count++;
                                    _ = UpdateElement(cmimshitje, bc, pershkrim, cmsh, njesi);
                                }

                            }
                            else
                            {

                                Mbyll();
                                bc_tb.Text = "";
                                bc_tb.Focus();
                            }
                        }
                    }


                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bc_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void l_cmim_Click(object sender, EventArgs e)
        {

        }

        private void Oferte_Click(object sender, EventArgs e)
        {

        }

        private void l_kod_Click(object sender, EventArgs e)
        {

        }

        private void l_pers_Click(object sender, EventArgs e)
        {

        }

        private void SkanoBc_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}