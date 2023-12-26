using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace ResgistroDeAsistenciaSADECV
{
    public partial class RegistroDeAsistenciaSADECVForm : Form
    {
        OleDbConnection connection = new OleDbConnection();
        String nombreCompletoAux,rFC, departamento, asistencia = "Presente", justificante, verificarCodigoEntrada = "", verificarCodigoSalida ="";
        string rutaImagen; DateTime fechaEntrada; Boolean yaquedo = false; Image imagencache; bool adminmode = false;
        byte[] imagenMostrar;
        bool codigoNormal = false;

        public string RFC { get => rFC; set => rFC = value; }
        public string NombreCompletoAux { get => nombreCompletoAux; set => nombreCompletoAux = value; }
        public string Asistencia { get => asistencia; set => asistencia = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public string Justificante { get => justificante; set => justificante = value; }

        public RegistroDeAsistenciaSADECVForm()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|BD\BDCHAMBA.mdb;User Id=admin;Password=;";

        }
        private void RegistroDeAsistenciaSADECVForm_Load(object sender, EventArgs e)
        {
            departamento_Cbx.SelectedIndex = -1;
            timer.Enabled = true;
            try
            {
                connection.Open();
                MessageBox.Show("Conección a la base de datos establecida exitosamente");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
        private void timer_Lbl_Tick(object sender, EventArgs e)
        {
            hora_Lbl.Text = DateTime.Now.ToString("hh:mm:ss");
            fecha_Lbl.Text = DateTime.Now.ToLongDateString();
        }

        private void administrador_Btn_Click(object sender, EventArgs e)
        {
           
            if (adminmode == true)
            {
                MessageBox.Show("Saliendo del modo administrador");
                nombreApellidoRegistro_Lbl.Visible = false;
                nombreCompleto_Tbx.Visible = false;
                rFC_Lbl.Visible = false;
                rFC_Tbx.Visible = false;
                departamento_Lbl.Visible = false;
                departamento_Cbx.Visible = false;
                ingresarUsuario_Btn.Visible = false;
                generarReporte_Btn.Visible = false;
                nombreApellido_Lbl.Visible = false;
                bienvenida_Lbl.Visible = false;
                seleccionarImagen_Btn.Visible = false;
                fotoPersonal_Picbox.Visible = false;
                codigoAdministrador_Tbx.Text = "";
                adminmode = false;
            }
            else
            {
                
                if (codigoAdministrador_Tbx.Text == "")
                {
                    MessageBox.Show("No ah ingresado ningun codigo");
                }
                else
                {

                    if (adminmode == true)
                    {
                        MessageBox.Show("Saliendo del modo administrador");
                        nombreApellidoRegistro_Lbl.Visible = false;
                        nombreCompleto_Tbx.Visible = false;
                        rFC_Lbl.Visible = false;
                        rFC_Tbx.Visible = false;
                        departamento_Lbl.Visible = false;
                        departamento_Cbx.Visible = false;
                        ingresarUsuario_Btn.Visible = false;
                        generarReporte_Btn.Visible = false;
                        nombreApellido_Lbl.Visible = false;
                        bienvenida_Lbl.Visible = false;
                        seleccionarImagen_Btn.Visible = false;
                        fotoPersonal_Picbox.Visible = false;
                        codigoAdministrador_Tbx.Text = "";
                        adminmode = false;
                    }
                    else
                    {
                        connection.Open();
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = connection;
                        command.CommandText = "Select * from PERSONAL where Codigo='" + codigoAdministrador_Tbx.Text + "' and Departamento='RH'";

                        OleDbDataReader reader = command.ExecuteReader();
                        int contador = 0;

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                contador++;
                                imagenMostrar = (byte[])reader["Foto"];
                                nombreApellido_Lbl.Text = reader["NombreCompleto"].ToString();
                            }

                            if (contador == 1)
                            {
                                MessageBox.Show("Codigo Correcto, Ingresando a modo administrador");
                                nombreApellidoRegistro_Lbl.Visible = true;
                                nombreCompleto_Tbx.Visible = true;
                                rFC_Lbl.Visible = true;
                                rFC_Tbx.Visible = true;
                                departamento_Lbl.Visible = true;
                                departamento_Cbx.Visible = true;
                                ingresarUsuario_Btn.Visible = true;
                                generarReporte_Btn.Visible = true;
                                nombreApellido_Lbl.Visible = true;
                                bienvenida_Lbl.Visible = true;
                                seleccionarImagen_Btn.Visible = true;
                                using (MemoryStream ms = new MemoryStream(imagenMostrar))
                                {
                                    fotoPersonal_Picbox.Image = Image.FromStream(ms);
                                }
                                fotoPersonal_Picbox.Visible = true;
                                codigoAdministrador_Tbx.Text = "";
                                adminmode = true;
                            }
                            else
                            {
                                if (contador > 1)
                                {
                                    MessageBox.Show("Codigo Duplicado");
                                }
                                else
                                {
                                    MessageBox.Show("Codigo incorrecto, solo puede ingresar al modo administrador si pertenece al departamento de recursos humanos");

                                }
                            }
                            connection.Close();
                        }
                        else
                        {
                            MessageBox.Show("Usted no esta Registrado");
                            connection.Close();
                        }

                    }

                }
            }

           
        }

        private void siete_Btn_Click(object sender, EventArgs e)
        {
            if (codigoNormal == true)
            {
                usuario_Tbx.Text = usuario_Tbx.Text + "7";

            }
            else
            {
                codigoAdministrador_Tbx.Text = codigoAdministrador_Tbx.Text + "7";
            }
            
        }

        private void ocho_Btn_Click(object sender, EventArgs e)
        {
            if (codigoNormal == true)
            {
                usuario_Tbx.Text = usuario_Tbx.Text + "8";

            }
            else
            {
                codigoAdministrador_Tbx.Text = codigoAdministrador_Tbx.Text + "8";
            }
            

        }

        private void nueve_Btn_Click(object sender, EventArgs e)
        {
            if (codigoNormal == true)
            {
                usuario_Tbx.Text = usuario_Tbx.Text + "9";

            }
            else
            {
                codigoAdministrador_Tbx.Text = codigoAdministrador_Tbx.Text + "9";
            }
            

        }

        private void cuatro_Btn_Click(object sender, EventArgs e)
        {
            if (codigoNormal == true)
            {
                usuario_Tbx.Text = usuario_Tbx.Text + "4";

            }
            else
            {
                codigoAdministrador_Tbx.Text = codigoAdministrador_Tbx.Text + "4";
            }
            

        }

        private void cinco_Btn_Click(object sender, EventArgs e)
        {
            if (codigoNormal == true)
            {
                usuario_Tbx.Text = usuario_Tbx.Text + "5";

            }
            else
            {
                codigoAdministrador_Tbx.Text = codigoAdministrador_Tbx.Text + "5";
            }
           

        }

        private void seis_Btn_Click(object sender, EventArgs e)
        {
            if (codigoNormal == true)
            {
                usuario_Tbx.Text = usuario_Tbx.Text + "6";

            }
            else
            {
                codigoAdministrador_Tbx.Text = codigoAdministrador_Tbx.Text + "6";
            }
            

        }

        private void uno_Btn_Click(object sender, EventArgs e)
        {
            if (codigoNormal == true)
            {
                usuario_Tbx.Text = usuario_Tbx.Text + "1";

            }
            else
            {
                codigoAdministrador_Tbx.Text = codigoAdministrador_Tbx.Text + "1";
            }
            

        }

        private void dos_Btn_Click(object sender, EventArgs e)
        {
            if (codigoNormal == true)
            {
                usuario_Tbx.Text = usuario_Tbx.Text + "2";

            }
            else
            {
              codigoAdministrador_Tbx.Text = codigoAdministrador_Tbx.Text + "2";
            }
           

        }

        private void tres_Btn_Click(object sender, EventArgs e)
        {
            if (codigoNormal == true)
            {
                usuario_Tbx.Text = usuario_Tbx.Text + "3";

            }
            else
            {
                codigoAdministrador_Tbx.Text = codigoAdministrador_Tbx.Text + "3";
            }
            

        }

        private void cero_Btn_Click(object sender, EventArgs e)
        {
            if (codigoNormal == true)
            {
                usuario_Tbx.Text = usuario_Tbx.Text + "0";

            }
            else
            {
                codigoAdministrador_Tbx.Text = codigoAdministrador_Tbx.Text + "0";
            }
            

        }

        private void dobleCero_Btn_Click(object sender, EventArgs e)
        {
            if(codigoNormal == true)
            {
                usuario_Tbx.Text = usuario_Tbx.Text + "00";

            }
            else
            {
                codigoAdministrador_Tbx.Text = codigoAdministrador_Tbx.Text + "00";
            }

        }

        private void borrar_Btn_Click(object sender, EventArgs e)
        {
            if(codigoNormal == true)
            {
                if (usuario_Tbx.Text.Length > 0)
                {
                    // Elimina el último carácter del contenido del TextBox.
                    usuario_Tbx.Text = usuario_Tbx.Text.Remove(usuario_Tbx.Text.Length - 1);
                }
               
            }
            else
            {
                if (codigoAdministrador_Tbx.Text.Length > 0)
                {
                    codigoAdministrador_Tbx.Text = codigoAdministrador_Tbx.Text.Remove(codigoAdministrador_Tbx.Text.Length - 1);
                }
            }
        }

        private void usuario_Tbx_Click(object sender, EventArgs e)
        {
            codigoNormal = true;
        }

        private void seleccionarImagen_Btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.png;*.jpg;*.jpeg;*.gif;*.bmp|Todos los archivos|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtén la ruta de la imagen seleccionada
                     rutaImagen = openFileDialog.FileName;

                    // Muestra la imagen en un PictureBox si lo deseas
                    fotoPersonal_Picbox.Image = Image.FromFile(rutaImagen);

                   
                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AyudaForm AF = new AyudaForm();
            AF.Show();
        }

        private void codigoAdministrador_Tbx_Click(object sender, EventArgs e)
        {
            codigoNormal = false;

        }

        private void registrarEntrada_Btn_Click(object sender, EventArgs e)
        {
            fechaEntrada = DateTime.Now;
            if (usuario_Tbx.Text == "")
            {
                MessageBox.Show("No ha ingresado ningun codigo");
            }
            else
            {
                if(verificarCodigoEntrada.Equals(usuario_Tbx.Text))
                {
                    MessageBox.Show("Ya se ha registrado su entrada");
                }
                else
                {
                    try
                    {
                        connection.Open();
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = connection;
                        String query = "select * from PERSONAL where Codigo='" + usuario_Tbx.Text + "'";
                        command.CommandText = query;

                        OleDbDataReader reader = command.ExecuteReader();

                        if(reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                nombreApellido_Lbl.Text = reader["NombreCompleto"].ToString();
                                NombreCompletoAux = reader["NombreCompleto"].ToString();
                                RFC = reader["RFC"].ToString();
                                Departamento = reader["Departamento"].ToString();
                                Asistencia = "Presente";
                                Justificante = "";
                               imagenMostrar = (byte[])reader["Foto"];
                            }
                                nombreApellido_Lbl.Visible = true; bienvenida_Lbl.Visible = true;
                            try
                            {

                                OleDbCommand commandAsistencia = new OleDbCommand();
                                commandAsistencia.Connection = connection;
                                commandAsistencia.CommandText = "insert into ASISTENCIAS ([Codigo],[NombreCompleto],[RFC],[Departamento],[FechaEntrada],[Asistencia]) values(@Codigo,@NombreCompleto,@RFC,@Departamento,@FechaEntrada,@Asistencia)";

                                commandAsistencia.Parameters.AddWithValue("@Codigo", usuario_Tbx.Text);
                                commandAsistencia.Parameters.AddWithValue("@NombreCompleto", NombreCompletoAux);
                                commandAsistencia.Parameters.AddWithValue("@RFC", RFC);
                                commandAsistencia.Parameters.AddWithValue("@Departamento", Departamento);
                                commandAsistencia.Parameters.AddWithValue("@FechaEntrada", fechaEntrada);
                                commandAsistencia.Parameters.AddWithValue("@Asistencia", Asistencia);

                                commandAsistencia.ExecuteNonQuery();
                                fotoPersonal_Picbox.Visible = true;
                                using (MemoryStream ms = new MemoryStream(imagenMostrar))
                                {
                                    fotoPersonal_Picbox.Image = Image.FromStream(ms);
                                    
                                }
                                MessageBox.Show("Asistencia Registrada");
                                connection.Close();
                                verificarCodigoEntrada = usuario_Tbx.Text;

                                usuario_Tbx.Text = "";
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Hubo un error " + ex);
                                connection.Close();
                            }


                        }
                        else
                        {
                            MessageBox.Show("Usted no está registrado");
                            connection.Close();
                        }
                       

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hubo un error " + ex);
                        connection.Close();
                    }
                }

            }

        }

        private void registrarSalida_Btn_Click(object sender, EventArgs e)
        {
            DateTime fechaSalida; fechaSalida = DateTime.Now;
            bool PersonalExistente = false;
            bool PersonalEntro = false;
            if (usuario_Tbx.Text != "")
            {
                try
                {   connection.Open();
                    OleDbCommand commandVerificarPersonal = new OleDbCommand();
                    commandVerificarPersonal.Connection = connection;
                    commandVerificarPersonal.CommandText = "SELECT * FROM PERSONAL WHERE Codigo='" + usuario_Tbx.Text + "'";

                    OleDbDataReader LectorVerificarPersonal = commandVerificarPersonal.ExecuteReader();

                    if(LectorVerificarPersonal.HasRows)
                    {
                        while(LectorVerificarPersonal.Read())
                        {
                            nombreCompletoAux = LectorVerificarPersonal["NombreCompleto"].ToString();
                            imagenMostrar = (byte[])LectorVerificarPersonal["Foto"];
                            PersonalExistente = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usted no esta registrado");

                    }
                    connection.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("error " + ex);

                    connection.Close();
                }
                if(PersonalExistente == true)
                {
                    try { 
                        connection.Open();
                        OleDbCommand commandVerificarSiRegistroEntrada = new OleDbCommand();
                        commandVerificarSiRegistroEntrada.Connection = connection;
                        commandVerificarSiRegistroEntrada.CommandText = "SELECT * FROM ASISTENCIAS WHERE Codigo='" + usuario_Tbx.Text + "' AND FechaSalida IS NULL AND FechaJustificante IS NULL";
                        OleDbDataReader LeerVerificarEntrada = commandVerificarSiRegistroEntrada.ExecuteReader();

                        if(LeerVerificarEntrada.HasRows)
                        {
                            while(LeerVerificarEntrada.Read())
                            {
                                fechaEntrada = DateTime.Parse(LeerVerificarEntrada["FechaEntrada"].ToString());
                                PersonalEntro = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("No ha registrado su entrada o ya registro su salida del dia de hoy");
                        }
                        connection.Close();
                    }catch(Exception ex)
                    {
                        MessageBox.Show("hubo un error  " + ex);
                        connection.Close();
                    }
                }
                if(PersonalEntro == true)
                {
                    connection.Open();
                    OleDbCommand commandActualizar = new OleDbCommand();
                    commandActualizar.Connection = connection;
                    commandActualizar.CommandText = "UPDATE ASISTENCIAS SET FechaSalida = @fechaSalida WHERE Codigo = @codigo AND FechaEntrada = @fechaEntrada";
                    commandActualizar.Parameters.AddWithValue("@fechaSalida", fechaSalida);
                    commandActualizar.Parameters.AddWithValue("@codigo", usuario_Tbx.Text);
                    commandActualizar.Parameters.AddWithValue("@fechaEntrada", fechaEntrada);
                    commandActualizar.ExecuteNonQuery();
                    using (MemoryStream ms = new MemoryStream(imagenMostrar))
                    {
                        fotoPersonal_Picbox.Image = Image.FromStream(ms);

                    }
                    nombreApellido_Lbl.Text = nombreCompletoAux;
                    MessageBox.Show("Lo lograste mau");
                    connection.Close();

                }

            }
            else
            {
                MessageBox.Show("Usted no ah escrito su codigo");
            }
        }

        private void validarUsuario_Btn_Click(object sender, EventArgs e)
        {
            if (usuario_Tbx.Text == "")
            {
                MessageBox.Show("No ha ingresado ningun codigo");
            }
            else
            {
                if (verificarCodigoEntrada.Equals(usuario_Tbx.Text))
                {
                    MessageBox.Show("Ya se ha registrado su entrada");
                }
                else
                {
                    try
                    {
                        connection.Open();
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = connection;
                        String query = "select * from PERSONAL where Codigo='" + usuario_Tbx.Text + "'";
                        command.CommandText = query;

                        OleDbDataReader reader = command.ExecuteReader();
                        int contador = 0;
                        if(reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                nombreCompletoAux = reader["NombreCompleto"].ToString();
                                imagenMostrar = (byte[])reader["Foto"];
                                contador++;
                            }
                            if (contador == 1)
                            {
                                using (MemoryStream ms = new MemoryStream(imagenMostrar))
                                {
                                    fotoPersonal_Picbox.Image = Image.FromStream(ms);
                                }
                                fotoPersonal_Picbox.Visible = true;
                                nombreApellido_Lbl.Visible = true;
                                nombreApellido_Lbl.Text = nombreCompletoAux;
                                MessageBox.Show("Usted esta registrado en la base de datos");

                            }
                            else
                            {
                                if (contador > 1)
                                {
                                    MessageBox.Show("Error, hay mas de un dato igual");

                                }
                                else
                                {
                                    MessageBox.Show("Usted no esta registrado en la base de datos");
                                }
                            }
                            connection.Close();
                        }
                        else
                        {
                            MessageBox.Show("Usted no esta registrado");
                            connection.Close();
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hubo un error " + ex);
                    }
                }
            }
        }
        private void ingresarUsuario_Btn_Click(object sender, EventArgs e)
        {
            if(rutaImagen == null)
            {
                MessageBox.Show("Falta Seleccionar una imagen");
            }
            else
            {
                byte[] imagenBytes = File.ReadAllBytes(rutaImagen);

                if (usuario_Tbx.Text == "" || nombreCompleto_Tbx.Text == "" || rFC_Tbx.Text == "" || departamento_Cbx.SelectedIndex == -1 || fotoPersonal_Picbox.Image == null || rutaImagen == null)
                {
                    MessageBox.Show("No ha terminado de rellenar los datos");
                }
                else
                {
                    try
                    {
                        connection.Open();
                        OleDbCommand commandAsistencia = new OleDbCommand();
                        commandAsistencia.Connection = connection;
                        commandAsistencia.CommandText = "insert into PERSONAL ([Codigo],[NombreCompleto],[RFC],[Foto],[Departamento]) values(@Codigo,@NombreCompleto,@RFC,@Foto,@Departamento)";

                        commandAsistencia.Parameters.AddWithValue("@Codigo", usuario_Tbx.Text);
                        commandAsistencia.Parameters.AddWithValue("@NombreCompleto", nombreCompleto_Tbx.Text);
                        commandAsistencia.Parameters.AddWithValue("@RFC", rFC_Tbx.Text);
                        commandAsistencia.Parameters.AddWithValue("@Foto", imagenBytes);
                        commandAsistencia.Parameters.AddWithValue("@Departamento", departamento_Cbx.Text);

                        commandAsistencia.ExecuteNonQuery();
                        MessageBox.Show("Usuario Registrado");
                        nombreApellido_Lbl.Text = nombreCompleto_Tbx.Text;
                        rutaImagen = null;
                        connection.Close();
                        usuario_Tbx.Text = "";
                        nombreCompleto_Tbx.Text = "";
                        rFC_Tbx.Text = "";
                        departamento_Cbx.SelectedIndex = -1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hubo un error " + ex);
                        connection.Close();
                    }

                }
            }

           
        }

        private void generarReporte_Btn_Click(object sender, EventArgs e)
        {
            ReporteForm RF = new ReporteForm();
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from ASISTENCIAS";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                RF.MostrarDatosEnDataGridView(dt);
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            RF.Show();
        }
    }
}
