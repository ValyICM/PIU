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

            if (!IsValid())
            {
                MessageBox.Show("Te rugăm să completezi toate câmpurile obligatorii.");
                return;
            }

            lastId++;

            string numeActivitate = Numetxt.Text;
            string dataActivitate = cboZi.Text + "." + cboLuna.Text + "." + cboAn.Text;
            string oraActivitate = cbostart.Text + " -> " + cbostop.Text;

            string idUnic = lastId.ToString();

            string filePath = "D:\\Projects\\PIU-main\\Agenda_project\\Agenda_project\\numeFisier.txt";

            try
            {
                string activitateString = $"{idUnic}, {numeActivitate}, {dataActivitate}, {oraActivitate}";

                File.AppendAllText(filePath, activitateString + Environment.NewLine);

                preAdauglbl.Text = "Activitatea a fost adaugata";

                Numetxt.Text = "";
                cboLuna.SelectedIndex = -1;
                cboZi.SelectedIndex = -1;
                cboAn.SelectedIndex = -1;
                cbostart.SelectedIndex = -1;
                cbostop.SelectedIndex = -1;
               
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

        private void cboState_SelectedIndexChanged(object sender, EventArgs e)
        {
            preAdauglbl.Text ="Nume: " + Numetxt.Text + "\nData: " + cboZi.Text + "." + cboLuna.Text + "." + cboAn.Text + "\nInterval orar: " + cbostart.Text + "->" + cbostop.Text;
        }

        private bool IsValid()
        {
            bool isValid = true;

            // Verifica numele
            if (string.IsNullOrWhiteSpace(Numetxt.Text))
            {
                Numetxt.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                Numetxt.BackColor = SystemColors.Window;
            }

            // Verifica data
            if (cboZi.SelectedIndex == -1 || cboLuna.SelectedIndex == -1 || cboAn.SelectedIndex == -1)
            {
                if (cboZi.SelectedIndex == -1) cboZi.BackColor = Color.Red;
                if (cboLuna.SelectedIndex == -1) cboLuna.BackColor = Color.Red;
                if (cboAn.SelectedIndex == -1) cboAn.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                cboZi.BackColor = SystemColors.Window;
                cboLuna.BackColor = SystemColors.Window;
                cboAn.BackColor = SystemColors.Window;
            }

            // Verifica ora
            if (cbostart.SelectedIndex == -1 || cbostop.SelectedIndex == -1)
            {
                if (cbostart.SelectedIndex == -1) cbostart.BackColor = Color.Red;
                if (cbostop.SelectedIndex == -1) cbostop.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                cbostart.BackColor = SystemColors.Window;
                cbostop.BackColor = SystemColors.Window;
            }

            return isValid;
        }

        private void ResetControlColors()
        {
            Numetxt.BackColor = SystemColors.Window;
            cboZi.BackColor = SystemColors.Window;
            cboLuna.BackColor = SystemColors.Window;
            cboAn.BackColor = SystemColors.Window;
            cbostart.BackColor = SystemColors.Window;
            cbostop.BackColor = SystemColors.Window;
        }

    }
}
