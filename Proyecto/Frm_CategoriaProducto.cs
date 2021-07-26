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
    public partial class Frm_CategoriaProducto : Form
    {
        public Frm_CategoriaProducto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_CategoriaProducto frm = new Frm_CategoriaProducto();
            frm.Close();
        }
    }
}
