using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empadronamiento
{
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtConfirmacionCorreo.Text != txtCorreoElectronico.Text)
            {
                MessageBox.Show("advertencia", "pendejo");
            }
        }
    }
}
