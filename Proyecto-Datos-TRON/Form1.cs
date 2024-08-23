using System;
using System.Windows.Forms;

namespace Proyecto_Datos_TRON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            // Establecer DialogResult a OK para indicar que Form2 debe abrirse
            this.DialogResult = DialogResult.OK;

            // Cerrar Form1
            this.Close();
        }
    }
}
