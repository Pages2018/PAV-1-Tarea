using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_PAV1
{
    public partial class frmLogin : Form
    {
        string user = "admin";
        string pass = "1234";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (this.txtUsuario.Text == "")
            if (this.txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("Debe Ingresar Usuario...");
                this.txtUsuario.Focus();
                return;
            }
            //if (this.txtClave.Text == "")
            if (string.IsNullOrEmpty(this.txtClave.Text))
            {
                MessageBox.Show("Debe Ingresar Clave...");
                this.txtClave.Focus();
                return;
            }
            //Validar Usuario y Clave

            string msj = "";
            if (this.txtUsuario.Text == this.user && this.txtClave.Text == this.pass)
            {
                msj = "Login OK;
                MessageBox.Mostrar(msj,"Ingreso al sistemas",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                
                //cambiado a exclamacion
            }      
            else
            {
                msj = "Usuario y/o Clave Incorrectos";
                MessageBox.Show(msj, "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsuario.Text = "";
                this.txtClave.Text = string.Empty;
                this.txtUsuario.Focus();
            }    
                         
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
