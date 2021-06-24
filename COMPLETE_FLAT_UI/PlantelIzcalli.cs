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
    public partial class PlantelIzcalli : Form
    {
        
        public PlantelIzcalli()
        {
            InitializeComponent();
            Cargar();
        }

        public void habilitarboton_eliminar_actualizar()
        {
            if (txtID.Text != string.Empty)
            {
                btnEliminar.Enabled = true;
                btnActualizar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
                btnActualizar.Enabled = false;
            }
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

        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int poc2 = dataGridView1.CurrentRow.Index;
            txtID.Text = dataGridView1[0, poc2].Value.ToString();
            txtNombre.Text = dataGridView1[1, poc2].Value.ToString();
            txtCURP.Text = dataGridView1[2, poc2].Value.ToString();
            txtCarrera.Text = dataGridView1[3, poc2].Value.ToString();
            txtPlantel.Text = dataGridView1[4, poc2].Value.ToString();
            comboEstatus.Text = dataGridView1[5, poc2].Value.ToString();
            txtTelefono.Text = dataGridView1[6, poc2].Value.ToString();
            txtEmail.Text = dataGridView1[7, poc2].Value.ToString();
            habilitarboton_eliminar_actualizar();
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MySqlConnection bd = new MySqlConnection("SERVER=localhost; DATABASE=bd_unimex_izcalli; UID=root; PASSWORD=; PORT=3306");
            MySqlCommand cmdact;
            bd.Open();

            try
            {
                cmdact = bd.CreateCommand();

                cmdact.CommandText = "UPDATE tb_alumnos_izcalli SET AL_NOMBRE=@Nombre, AL_CURP=@CURP, AL_CARRERA=@Carrera, AL_PLANTEL=@Plantel, AL_ESTATUS=@Estatus, AL_TELEFONO=@Telefono, AL_EMAIL=@Email WHERE AL_ID=@ID";
                cmdact.Parameters.AddWithValue("@ID", txtID.Text);
                cmdact.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmdact.Parameters.AddWithValue("@CURP", txtCURP.Text);
                cmdact.Parameters.AddWithValue("@Carrera", txtCarrera.Text);
                cmdact.Parameters.AddWithValue("@Plantel", txtPlantel.Text);
                cmdact.Parameters.AddWithValue("@Estatus", comboEstatus.Text);
                cmdact.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                cmdact.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmdact.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (bd.State == ConnectionState.Open)
                {
                    MessageBox.Show("¡Alumno actualizado!");
                    Cargar();
                    bd.Close();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MySqlConnection bd = new MySqlConnection("SERVER=localhost; DATABASE=bd_unimex_izcalli; UID=root; PASSWORD=; PORT=3306");
            MySqlCommand cmdEliminar;
            bd.Open();

            try
            {
                cmdEliminar = bd.CreateCommand();
                cmdEliminar.CommandText = "DELETE FROM tb_alumnos_izcalli WHERE AL_ID=@ID";
                cmdEliminar.Parameters.AddWithValue("@ID", txtID.Text);
                cmdEliminar.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (bd.State == ConnectionState.Open)
                {
                    MessageBox.Show("¡Alumno eliminado!");
                    Cargar();
                    bd.Close();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MySqlConnection bd = new MySqlConnection("SERVER=localhost; DATABASE=bd_unimex_izcalli; UID=root; PASSWORD=; PORT=3306");
            MySqlCommand cmd;
            bd.Open();

            try
            {
                cmd = bd.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_alumnos_izcalli(AL_NOMBRE,AL_CURP,AL_CARRERA,AL_PLANTEL,AL_ESTATUS,AL_TELEFONO,AL_EMAIL)VALUES(@Nombre,@CURP,@Carrera,@Plantel,@Estatus,@Telefono,@Email)";
                cmd.Parameters.AddWithValue("@ID", txtID.Text);
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@CURP", txtCURP.Text);
                cmd.Parameters.AddWithValue("@Carrera", txtCarrera.Text);
                cmd.Parameters.AddWithValue("@Plantel", txtPlantel.Text);
                cmd.Parameters.AddWithValue("@Estatus", comboEstatus.Text);
                cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.ExecuteNonQuery();
                
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (bd.State == ConnectionState.Open)
                {
                    MessageBox.Show("¡Registro guardado!");
                    Cargar();
                    bd.Close();
                }
            }
        }    

    

        public void Cargar()
        {
            MySqlConnection bd = new MySqlConnection("SERVER=localhost; DATABASE=bd_unimex_izcalli; UID=root; PASSWORD=; PORT=3306");
            bd.Open();

            try
            {
                MySqlCommand cmd = bd.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_alumnos_izcalli";
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
