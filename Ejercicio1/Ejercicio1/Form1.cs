using Ejercicio1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        //usuario predefinido para autenticación
        private Usuario usuarioAdmin;
        public Form1()
        {
            InitializeComponent();

            this.tbContrasena.PasswordChar = '*';

            //se configura el usuario admin con credenciales de prueba
            usuarioAdmin = new Usuario
            {
                NombreUsuario = "admin",
                Contrasena = "1234"
            };

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            //eliminar espacios al inicio y al final
            string usuario = tbUsuario.Text.Trim();
            string contrasena = tbContrasena.Text.Trim();

            //verificacion si alguno de los campos esta vacío
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor, ingresa el usuario y la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //validacion de usuario y contraseña con el método EsUsuarioValido
            if (usuarioAdmin.EsUsuarioValido(usuario, contrasena))
            {
                MessageBox.Show($"¡Bienvenido, {usuarioAdmin.NombreUsuario}!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
