using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_1_TRONGAME
{
    public class Form2 : Form
    {
        public Form2()
        {
            this.ClientSize = new Size(800, 600);
            this.Text = "Tablero de Juego";
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit(); // Cierra la aplicación completa cuando Form2 se cierra
        }
    }
}
