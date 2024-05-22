using NivelStocareDate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_Forms
{
    public partial class Modifica_date : Form
    {
        public Modifica_date()
        {
            InitializeComponent();

        }

        //butoane de comanda
        private void Adaugabtn_Click(object sender, EventArgs e)
        {

            string filePath = "D:\\Projects\\PIU-main\\Agenda_project\\Agenda_project\\numeFisier.txt";

            try
            {

                string[] lines = File.ReadAllLines(filePath);

                dataGridView1.Rows.Clear();

                foreach (string line in lines)
                {
                    string[] cells = line.Split(',');
                    dataGridView1.Rows.Add(cells);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("A apărut o eroare: " + ex.Message);
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start Start = new Start();
            Start.Show();

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            Start Start = new Start();
            Start.Show();
        }

        private void Salveazabtn_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }
        private void SaveToFile()
        {
            try
            {
                // Deschide fișierul pentru scriere
                using (StreamWriter writer = new StreamWriter("D:\\Projects\\PIU-main\\Agenda_project\\Agenda_project\\numeFisier.txt"))
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string rowData = string.Join(",", Array.ConvertAll(row.Cells.Cast<DataGridViewCell>().ToArray(), cell => cell.Value?.ToString() ?? ""));
                            writer.WriteLine(rowData);
                        }
                    }
                }

                MessageBox.Show("Datele au fost salvate cu succes în fișier.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("A apărut o eroare la salvarea în fișier: " + ex.Message);
            }
        }

        private void Modifibtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                    dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            }
            else
            {
                    MessageBox.Show("Selectează mai întâi un rând înainte de a modifica datele.");
            }

        }

        private void Stergebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;

                dataGridView1.Rows.RemoveAt(selectedRowIndex);

                for (int i = selectedRowIndex; i < dataGridView1.Rows.Count; i++)
                {       
                    dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
                }
            }
            else
            {
                MessageBox.Show("Selectează mai întâi o linie înainte de a șterge.");
            }
        }

        private void VeziAGbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Agenda = new Agenda();
            Agenda.Show();
        }

        private void Cautabtn_Click(object sender, EventArgs e)
        {
            Form Cautare = new Cautare();
            Cautare.Show();
        }
    }
}
