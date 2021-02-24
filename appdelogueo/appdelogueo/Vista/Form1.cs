using appdelogueo.Dominio;
using appdelogueo.Negocio;
using appdelogueo.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appdelogueo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsDominio Objetodominio = new ClsDominio();
            ClsLoguin ObjetoLoguin = new ClsLoguin();
            Objetodominio.Usuario = txtUsuario.Text;
            Objetodominio.Passwork = txtPassword.Text;


            Boolean acceder = ObjetoLoguin.loqueo(Objetodominio);
            if (acceder == true)
            {
                MessageBox.Show("acceso concedido");

                frmMenu Objetomenu = new frmMenu();
                Objetomenu.Show();

                this.Hide();
            
            
            
            }
            else {
                MessageBox.Show("acceso denegado");
                    
                    }







        }
    }
}
