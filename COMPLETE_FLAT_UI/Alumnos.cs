using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ConsultaDistribuida
{
    public partial class Alumnos : Form
    {
        
        public Alumnos()
        {
            InitializeComponent();
            Cargar();
        }

    
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "¡Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        int lx, ly;
        int sw, sh;
        
      

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
    

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelBarraTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            MySqlConnection bd = new MySqlConnection("SERVER=localhost; UID=root; PASSWORD=; PORT=3306");
            bd.Open();
            MySqlCommand cmd = bd.CreateCommand();
            cmd.CommandText = "SELECT * FROM bd_unimex_veracruz.tb_alumnos_veracruz WHERE AL_NOMBRE LIKE ('" + txtNombre.Text+ "%') UNION SELECT * FROM bd_unimex_satellite.tb_alumnos_satellite WHERE AL_NOMBRE LIKE ('" + txtNombre.Text + "%')UNION SELECT * FROM bd_unimex_polanco.tb_alumnos_polanco WHERE AL_NOMBRE LIKE ('" + txtNombre.Text + "%')UNION SELECT * FROM bd_unimex_izcalli.tb_alumnos_izcalli WHERE AL_NOMBRE LIKE ('" + txtNombre.Text + "%')";
            //cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            bd.Close();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection bd = new MySqlConnection("SERVER=localhost; UID=root; PASSWORD=; PORT=3306");
            bd.Open();
            MySqlCommand cmd = bd.CreateCommand();
            cmd.CommandText = "SELECT * FROM bd_unimex_veracruz.tb_alumnos_veracruz WHERE AL_PLANTEL LIKE ('" + comboBox1.Text + "%') UNION SELECT * FROM bd_unimex_satellite.tb_alumnos_satellite WHERE AL_PLANTEL LIKE ('" + comboBox1.Text + "%') UNION SELECT * FROM bd_unimex_polanco.tb_alumnos_polanco WHERE AL_PLANTEL LIKE ('" + comboBox1.Text + "%') UNION SELECT * FROM bd_unimex_izcalli.tb_alumnos_izcalli WHERE AL_PLANTEL LIKE ('" + comboBox1.Text + "%')";
            //cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            bd.Close();
        }

        public void Cargar()
        {
            MySqlConnection bd = new MySqlConnection("SERVER=localhost; UID=root; PASSWORD=; PORT=3306");
            bd.Open();

            try
            {
                MySqlCommand cmd = bd.CreateCommand();
                cmd.CommandText = "SELECT * FROM bd_unimex_veracruz.tb_alumnos_veracruz UNION SELECT * FROM bd_unimex_satellite.tb_alumnos_satellite UNION SELECT * FROM bd_unimex_polanco.tb_alumnos_polanco UNION SELECT * FROM bd_unimex_izcalli.tb_alumnos_izcalli";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (bd.State == ConnectionState.Open)
                {
                    bd.Clone();
                }
            }
        }
        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    

    }
}
