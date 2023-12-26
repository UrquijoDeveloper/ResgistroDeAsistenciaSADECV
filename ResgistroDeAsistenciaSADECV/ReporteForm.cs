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
    public partial class ReporteForm : Form
    {
        OleDbConnection connection = new OleDbConnection();
        List<(string,string, string, string, string, string)> empleadosLista = new List<(string,string, string, string, string, string)>();
        DateTime fechaJustificada = DateTime.Now;
        public ReporteForm()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|BD\BDCHAMBA.mdb;User Id=admin;Password=;";
        }

        public void MostrarDatosEnDataGridView(DataTable datos)
        {
            dataGridView1.DataSource = datos;
        }

        private void particular_Rbtn_CheckedChanged(object sender, EventArgs e)
        {
            codigo_Lbl.Visible = true;
            codigo_Tbx.Visible = true;
        }

        private void general_Rbtn_CheckedChanged(object sender, EventArgs e)
        {
            codigo_Lbl.Visible = false;
            codigo_Tbx.Visible = false;
        }

        private void confirmarJustificante_Btn_Click(object sender, EventArgs e)
        {
            RegistroDeAsistenciaSADECVForm RDAF = new RegistroDeAsistenciaSADECVForm();
            
            if (particular_Rbtn.Checked && !general_Rbtn.Checked)
            {
                if (codigo_Tbx.Text != "" || motivoJustificante_Rtbx.Text != "")
                {
                    try
                    {
                        connection.Open();
                         OleDbCommand command = new OleDbCommand();
                         command.Connection = connection;
                         String query = "select * from PERSONAL where Codigo= '" + codigo_Tbx.Text + "'";
                         command.CommandText = query;

                        OleDbDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            RDAF.NombreCompletoAux = reader["NombreCompleto"].ToString();
                            RDAF.RFC = reader["RFC"].ToString();
                            RDAF.Departamento = reader["Departamento"].ToString();
                            RDAF.Asistencia = "Justificado";
                            RDAF.Justificante = motivoJustificante_Rtbx.Text;
                            MessageBox.Show("ahuevo hasta aqui vamos bien");
                        }
                        connection.Close();
                    }catch(Exception ex)
                    {
                        MessageBox.Show("Error " + ex);
                    }


                }
            }
        }


        private void ReporteForm_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void fechaJustificante_monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            fechaJustificada = fechaJustificante_monthCalendar.SelectionStart;
        }
    }
}
