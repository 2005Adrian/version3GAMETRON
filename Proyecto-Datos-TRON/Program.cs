using System;
using System.Windows.Forms;

namespace Proyecto_Datos_TRON
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Crear e iniciar Form1
            Form1 form1 = new Form1();
            Application.Run(form1);

            // Verificar si Form1 se cerró con DialogResult.OK para abrir Form2
            if (form1.DialogResult == DialogResult.OK)
            {
                // Crear e iniciar Form2
                Form2 form2 = new Form2();
                Application.Run(form2);
            }
        }
    }
}
