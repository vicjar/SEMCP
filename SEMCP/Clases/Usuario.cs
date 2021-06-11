using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace SEMCP.Clases
{
    public class Usuario
    {
        public int Id,Sexo,Edad,Tipo;
        public String Nombre, Apellido, User, Password,Fecha_Nac,Correo;
        public ConexionBD conexion;
 
        public Usuario(ConexionBD cnn) {
            conexion = cnn;
        }

        public bool Buscar(String U, String P) {
            bool validar = true;

            try {
                string sqlquery = "Select * from Usuarios where Usuario = '" + U + "' and Password = '"+P+"'";

                SqlCommand command = new SqlCommand(sqlquery, conexion.connetion);

                SqlDataReader sdr = command.ExecuteReader();

                if (sdr.Read())
                {
                    Id = Int32.Parse(sdr["Id_U"].ToString());
                    Sexo = Int32.Parse(sdr["Sexo"].ToString());
                    Edad = Int32.Parse(sdr["Edad"].ToString());
                    Tipo = Int32.Parse(sdr["Tipo_Usuario"].ToString());
                    Nombre = sdr["Nombre"].ToString();
                    Apellido = sdr["Apellido"].ToString();
                    User = sdr["Usuario"].ToString();
                    Fecha_Nac = sdr["Fecha_Nac"].ToString();
                    Correo = sdr["Correo"].ToString();
                    Password = sdr["Password"].ToString();
                }
                else {
                    validar = false;
                }


                
                command.Dispose();

            } catch (Exception e) {
                MessageBox.Show("Error: "+e.Message);
                validar = false;
            }

            return validar;
        }

        public bool Registar() {

            bool valido = true;
            try {
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();

                String sql = "insert into Usuarios (Usuario,Password,Nombre,Apellido,Sexo,Edad,Correo,Fecha_Nac,Tipo_Usuario)" +
                             " values ('" + User + "','" + Password + "','" + Nombre + "','" + Apellido + "'," + Sexo + "," + Edad + ",'" + Correo + "','" + Fecha_Nac + "'," + Tipo + ");";
               
                command = new SqlCommand(sql, conexion.connetion);

                adapter.InsertCommand = new SqlCommand(sql, conexion.connetion);
                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();
            } catch (Exception e) {
                valido = false;
                MessageBox.Show(e.Message);
            }
            return valido;
        }

        public void Eliminar() { }
        public bool Actulizar() {

            bool valido = true;
            try
            {
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();

                String sql = "update Usuarios set Usuario = '" + User
                    + "', Nombre ='" + Nombre
                    + "', Apellido = '" + Apellido
                    + "',Sexo = " + Sexo +
                    ",Edad = " + Edad +
                    ",Correo = '" + Correo +
                    "',Fecha_Nac = '" + Fecha_Nac +
                    "' where  Id_U = " + Id.ToString();


                command = new SqlCommand(sql, conexion.connetion);

                adapter.UpdateCommand = new SqlCommand(sql, conexion.connetion);
                adapter.UpdateCommand.ExecuteNonQuery();
                command.Dispose();
            }
            catch (Exception e)
            {
                valido = false;
                MessageBox.Show(e.Message);
            }
            return valido;
        }

        public bool Restablecer_Password(String U, String P) {

                bool valido = true;
                try
                {
                    SqlCommand command;
                    SqlDataAdapter adapter = new SqlDataAdapter();

                    String sql = "update Usuarios set Password = '"+P+"' where Usuario = '"+U+"' or Correo = '"+U+"'";
                    command = new SqlCommand(sql, conexion.connetion);

                    adapter.UpdateCommand = new SqlCommand(sql, conexion.connetion);
                    adapter.UpdateCommand.ExecuteNonQuery();
                    command.Dispose();
                }
                catch (Exception e)
                {
                    valido = false;
                    MessageBox.Show(e.Message);
                }
                return valido;
            
        }


    }
}
