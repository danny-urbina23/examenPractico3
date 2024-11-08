using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Reflection.Emit;


namespace practice
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;
        private MySqlConnection sqlConnection;

        public Form1()
        {
            InitializeComponent();
            string connectionString = "Server=localhost;Database=Exapractico3;User ID=root;Password=#Mariachi23;SslMode=none;";
            sqlConnection = new MySqlConnection(connectionString);


            serialPort = new SerialPort("COM5", 9600);
            serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialDataReceived);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            // Validar que el nombre solo contenga letras
            if (!System.Text.RegularExpressions.Regex.IsMatch(tb_Name.Text, "^[a-zA-Z ]*$"))
            {
                MessageBox.Show("El nombre solo debe contener letras");
                tb_Name.Text = "";
            }
        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {
            DateTime fecha;
            if (!DateTime.TryParse(tb_Date.Text, out fecha))
            {
                MessageBox.Show("Formato de fecha inválido. Use dd/mm/yyyy");
                tb_Date.Text = "";
            }
        }


        private void SerialDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine();
            this.Invoke(new Action(() =>
            {
                string[] valores = data.Split(',');
                label5.Text = valores[0] + "°C";
                label6.Text = valores[1] + "°F";
                label7.Text = valores[2];

                GuardarTemperatura(float.Parse(valores[0]), float.Parse(valores[1]), int.Parse(valores[2]));
            }));
        }

        private void GuardarTemperatura(float celsius, float fahrenheit, int rawValue)
        {
            try
            {
                sqlConnection.Open();

                string query = "INSERT INTO Temperaturas (Celsius, Fahrenheit, RawValue) VALUES (@celsius, @fahrenheit, @rawValue)";
                MySqlCommand command = new MySqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@celsius", celsius);
                command.Parameters.AddWithValue("@fahrenheit", fahrenheit);
                command.Parameters.AddWithValue("@rawValue", rawValue);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la temperatura: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void GuardarEstadoDispositivo(string dispositivo, string estado)
        {
            try
            {
                sqlConnection.Open();  // Abrir la conexión

                string query = "INSERT INTO EstadosDispositivos (Dispositivo, Estado, Fecha) VALUES (@dispositivo, @estado, @fecha)";
                MySqlCommand command = new MySqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@dispositivo", dispositivo);
                command.Parameters.AddWithValue("@estado", estado);
                command.Parameters.AddWithValue("@fecha", DateTime.Now);

                command.ExecuteNonQuery();  // Ejecutar la consulta
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el estado del dispositivo: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();  // Cerrar la conexión
            }
        }

        // Consulta para insertar los datos en la tabla Usuarios
        private void GuardarUsuario(string nombre, DateTime fecha)
        {
            try
            {
                sqlConnection.Open();  // Abrir la conexión

                string query = "INSERT INTO Usuarios (Nombre, Fecha) VALUES (@nombre, @fecha)";
                MySqlCommand command = new MySqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@fecha", fecha);

                command.ExecuteNonQuery();  // Ejecutar la consulta
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el usuario: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();  // Cerrar la conexión
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Connect_Click_1(object sender, EventArgs e)
        {
            try
            {
                serialPort.Open();
                lbl_Status.Text = "Conectado";

                // Guardar nombre y fecha
                GuardarUsuario(tb_Name.Text, DateTime.Parse(tb_Date.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
            }
        }

        private void btn_Disconnect_Click_1(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                lbl_Status.Text = "Desconectado";
            }
        }

        private void btn_OnLed_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Enviar señal para encender el LED
                serialPort.WriteLine("encenderLed");

                // Guardar el estado del LED en la base de datos
                GuardarEstadoDispositivo("LED", "Encendido");
                MessageBox.Show("LED encendido.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al encender el LED: " + ex.Message);
            }
        }

        private void btn_OffLed_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Enviar señal para apagar el LED
                serialPort.WriteLine("apagarLed");

                // Guardar el estado del LED en la base de datos
                GuardarEstadoDispositivo("LED", "Apagado");
                MessageBox.Show("LED apagado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al apagar el LED: " + ex.Message);
            }
        }

        private void btn_OnServo_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Enviar señal para encender el servomotor
                serialPort.WriteLine("encenderServo");

                // Guardar el estado del servomotor en la base de datos
                GuardarEstadoDispositivo("Servomotor", "Encendido");
                MessageBox.Show("Servomotor encendido.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al encender el servomotor: " + ex.Message);
            }
        }

        private void btn_OffServo_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Enviar señal para apagar el servomotor
                serialPort.WriteLine("apagarServo");

                // Guardar el estado del servomotor en la base de datos
                GuardarEstadoDispositivo("Servomotor", "Apagado");
                MessageBox.Show("Servomotor apagado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al apagar el servomotor: " + ex.Message);
            }
        }

   
    }
}
