using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Agenda_Forms
{
    public partial class AgendaAdd : Form
    {

        private static int lastId = 0;

        public AgendaAdd()
        {
            InitializeComponent();
            UpdateLastId();
        }

        private void Adaugabutton_Click(object sender, EventArgs e)
        {
            lastId++;

            string numeActivitate = Numetxt.Text;
            string dataActivitate = Datatxt.Text;
            string oraActivitate = Oratxt.Text;

            string idUnic = lastId.ToString();


            string filePath = "D:\\Projects\\PIU-main\\Agenda_project\\Agenda_project\\numeFisier.txt";

            try
            {
                string activitateString = $"{idUnic}, {numeActivitate}, {dataActivitate}, {oraActivitate}";

                File.AppendAllText(filePath, activitateString + Environment.NewLine);

                MessageBox.Show("Activitatea a fost adăugată în fișier.");

                Numetxt.Text = "";
                Datatxt.Text = "";
                Oratxt.Text = "";
            }
            catch (Exception ex) { }

        }
        private void UpdateLastId()
        {
            string filePath = "D:\\Projects\\PIU-main\\Agenda_project\\Agenda_project\\numeFisier.txt";

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                if (lines.Length > 0)
                {

                    string lastLine = lines[lines.Length - 1];

                    string[] parts = lastLine.Split(',');

                    if (int.TryParse(parts[0], out int lastIdFromFile))
                    {
                        lastId = lastIdFromFile;
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Start = new Start();
            Start.Show();
        }

        private void VeziAGbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Agenda = new Agenda();
            Agenda.Show();
        }
    }
}
