using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splash
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entrar();
        }

        private void user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Entrar();
            }
        }

        private void pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Entrar();
            }
        }

        private void Entrar()
        {
            if (textb_user.Text.Equals("admin") && textb_pass.Text.Equals("admin"))
            {
                Splash S = new Splash();
                S.ShowDialog();
                Close();
            }
            else
            {
                String msg_error = "ERROR. USUARI O CONTRASENYA INCORRECTES";

                MessageBox.Show(msg_error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
