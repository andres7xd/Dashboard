using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if(TxtUsuario.TextLength==0){
                
                LoginErrorProvider.SetError(TxtUsuario, "Digite un nombre de usuario");
            }
            else
            {
                LoginErrorProvider.SetError(TxtUsuario, "");
            }

            if (TxtContraseña.TextLength == 0)
            {

                LoginErrorProvider.SetError(TxtContraseña, "Digite la contraseña");
            }
            else
            {
                LoginErrorProvider.SetError(TxtContraseña, "");
            }

        }
    }
}
