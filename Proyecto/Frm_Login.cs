using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (validar_Usuario(txt_usuario.Text, txt_clave.Text))
            {
                Frm_Login frm = new Frm_Login();
                frm.Show();
            }
        }
        private bool validar_Usuario(string user, string clave) {
            BasedeDatosDataContext context = new BasedeDatosDataContext();
            var q = from p in context.TBL_USUARIO
                    where p.USU_USUARIO == txt_usuario.Text
                    &&  p.USU_CLAVE == txt_clave.Text
                    select p
                    if (q.Any()) {

                MessageBox.Show("Bienvenido al Sistema");
                return true;

            }
            else {
                MessageBox.Show("Usuario o Clave Incorrectos");
                return false;
            }

        
        }

        
    }
}
