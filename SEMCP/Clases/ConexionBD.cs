using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SEMCP.Clases
{
    /// <summary>
    /// Clase conexión con la base de datos.
    /// </summary>
    public class ConexionBD
    {

        public String connetionString;
        public String Mensaje;
        public SqlConnection connetion;

        public ConexionBD() {
            connetionString = @"Data Source=sql5097.site4now.net;Initial Catalog=db_a74bb7_semcp;User ID=db_a74bb7_semcp_admin;Password=ISC2021RES;MultipleActiveResultSets=True";
            connetion = new SqlConnection(connetionString);
            connetion.InfoMessage += Connetion_InfoMessage;
            
        }

        private void Connetion_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            Mensaje = e.Message;
        }

        public void Open() {
            try { 
                connetion.Open();
                Mensaje = null;
            } catch (Exception e) {
                MessageBox.Show(e.Message);
            }
        }

        public void Close() {
            connetion.Close();
            Mensaje = null;
        }
    }
}
