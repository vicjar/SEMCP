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

        public Usuario() { }
        public Usuario(ConexionBD cnn) {
            conexion = cnn;
        }

        public bool login(String U, String P) {
            bool validar = true;
          
                try
                {
                    conexion.Open();
                    SqlCommand command;
                    SqlDataAdapter adapter = new SqlDataAdapter();

                    command = new SqlCommand($"UsuarioLogin '{U}', '{P}' ", conexion.connetion);
                    SqlDataReader sdr = command.ExecuteReader();

                if (conexion.Mensaje == null)
                {
                    while (sdr.Read()) {
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
                }
                else validar = false;

                command.Dispose();
                conexion.Close();
                }
                catch (Exception e)
                {
                    validar = false;
                    MessageBox.Show(e.Message);
                conexion.Close();
            }

            return validar;
        }




        public bool Buscar(String id) {
            bool validar = true;

            try
            {
                conexion.Open();

                SqlCommand command = new SqlCommand($"Select * from Usuarios where Id_U = {id} ", conexion.connetion);

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
                else
                {
                    validar = false;
                }



                command.Dispose();
                conexion.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
                validar = false;
                conexion.Close();
            }

            return validar;

        }
        public bool Registar() {

            bool valido = true;
            try {

                conexion.Open();
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();

                command = new SqlCommand($"Nuevo_Usuario  '{User}','{Password}','{Nombre}','{Apellido}',{Sexo},{Edad},'{Correo}','{Fecha_Nac}',{Tipo}", conexion.connetion);
                SqlDataReader sdr = command.ExecuteReader();

                command.Dispose();
                conexion.Close();

            } catch (Exception e) {
                valido = false;
                MessageBox.Show(e.Message);
                conexion.Close();
            }
            return valido;
        }
        public bool Eliminar(String Id) {

            bool valido = true;
            try
            {
                conexion.Open();
                SqlCommand command;

                String sql = "delete from Usuarios where Id_U = "+Id;
                command = new SqlCommand(sql, conexion.connetion);
                
                SqlDataReader sdr = command.ExecuteReader();
               command.Dispose();
                conexion.Close();
            }
            catch (Exception e)
            {
                conexion.Close();
                valido = false;
                MessageBox.Show(e.Message);
            }
            return valido;
        }
        public bool Actulizar() {

            bool valido = true;
            try
            {

                conexion.Open();
                SqlCommand command;

                command = new SqlCommand($"Update_Usuario  {Id},'{User}','{Nombre}','{Apellido}',{Sexo},{Edad},'{Correo}','{Fecha_Nac}'", conexion.connetion);
                SqlDataReader sdr = command.ExecuteReader();

                command.Dispose();
                conexion.Close();

            }
            catch (Exception e)
            {
                valido = false;
                MessageBox.Show(e.Message);
                conexion.Close();
            }
            return valido;
        }
        public bool Restablecer_Password(String U, String P) {

                bool valido = true;
                try
                {
                   conexion.Open();
                    SqlCommand command;
                    SqlDataAdapter adapter = new SqlDataAdapter();

                    command = new SqlCommand($"CambiarPasssword  '{P}','{U}'", conexion.connetion);
                    SqlDataReader sdr = command.ExecuteReader();

                    command.Dispose();
                    conexion.Close();
                    Password = P;
                }
                catch (Exception e)
                {
                    valido = false;
                    MessageBox.Show(e.Message);
                conexion.Close();
            }
                return valido;
            
        }

        public bool Registrar_Resultados(int puntaje, int juego) {

                bool valido = true;
                try
                {
                    if (Id != 0) {
                        conexion.Open();
                        SqlCommand command;
                        SqlDataAdapter adapter = new SqlDataAdapter();

                        command = new SqlCommand($"Registrar_Resultados  {juego},{Id},{puntaje}", conexion.connetion);
                        SqlDataReader sdr = command.ExecuteReader();

                        command.Dispose();
                        conexion.Close();
                    }
                }
                catch (Exception e)
                {
                    valido = false;
                    MessageBox.Show(e.Message);
                    conexion.Close();
            }
                return valido;
            
        }


    }
}
