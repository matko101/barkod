using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Barcode
{
    internal class Global
    {
        public static string ConnectionString = "Data Source=FATOS-PC\\F50;Initial Catalog=Baza;Integrated Security=True";
       // public static string ConnectionString2 = $"Server=ip,porte;Database=bm15;User Id=SA;Password=ISDF5ADMIN;";
        public static int T_value;


        public static void TestLidhje(object sender, EventArgs e)
        {
            
            
            try
            {
                string filePath = Path.GetFullPath("cfg.txt"); /*"C:\\Users\\Fatos\\Downloads\\mato\\barcodevinal\\Barcode\\Barcode\\cfg.txt";*/
                
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] keyValue = line.Split(':');
                    if (line.StartsWith("timer:"))
                    {
                        //string[] keyValue = line.Split('=');
                        string valueStr = keyValue[1].Trim();
                        T_value = int.Parse(valueStr); ;              
                    }

                    else if (line.StartsWith("connection:"))
                    {
                        string valueStr = keyValue[1].Trim();
                        ConnectionString = valueStr;
                        
                      
                            using (SqlConnection connection = new SqlConnection(ConnectionString))
                            {
                               
                            }
                       
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem me Lidhjen!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Application.Exit();
                
                
            }
        }

    }
}
