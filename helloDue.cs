using System;
using System.Windows.Forms;
using System.Drawing;

namespace EsempioGUI
{
    public class MiaFinestra : Form
    {
        private Button mioPulsante;

        public MiaFinestra()
        {
            // Impostazioni della finestra
            this.Text = "Esempio C# GUI";
            this.Size = new Size(300, 200);

            // Creazione del pulsante
            mioPulsante = new Button();
            mioPulsante.Text = "Cliccami!";
            mioPulsante.Location = new Point(100, 70);
            
            // Evento click
            mioPulsante.Click += (sender, e) => {
                MessageBox.Show("Ciao!!!! Programma scritto da WillTheKid...");
            };

            // Aggiunge il pulsante alla finestra
            this.Controls.Add(mioPulsante);
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new MiaFinestra());
        }
    }
}
