using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejem_app_gui_mensajr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Mostrar_Mensaje_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollo de aplicaciones");
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = MessageBox.Show("Desea salir de la aplicación?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          

            if (resultado==DialogResult.Yes)
            {
                Close();
            }
            
         
        }
    }
}
