using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SEMCP.Clases
{
    public class ConexionBD
    {
        public string connetionString;
        public SqlConnection connetion;

        public ConexionBD() {
            connetionString = @"Data Source=sql5097.site4now.net;Initial Catalog=db_a74bb7_semcp;User ID=db_a74bb7_semcp_admin;Password=ISC2021RES;MultipleActiveResultSets=True";
            connetion = new SqlConnection(connetionString);
            
        }

        public void Open() {
            try { 
                connetion.Open();
            } catch (Exception e) {
                MessageBox.Show(e.Message);
            }
        }

        public void Close() {
            connetion.Close();
        }
    }
}
