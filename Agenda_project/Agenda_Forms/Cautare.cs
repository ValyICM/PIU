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
    public partial class Cautare : Form
    {
        public Cautare()
        {
            InitializeComponent();
        }

        private void Cautabtn_Click(object sender, EventArgs e)
        {
            // Obține termenul de căutare din TextBox
            string searchTerm = Numetxt.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Introdu un termen de căutare.");
                return;
            }

            // Caută activitatea în fișier
            SearchInFile(searchTerm);
        }

        private void SearchInFile(string searchTerm)
        {
            try
            {
                // Citește toate liniile din fișier
                string[] lines = File.ReadAllLines("D:\\Projects\\PIU-main\\Agenda_project\\Agenda_project\\numeFisier.txt");

                // Verifică dacă termenul de căutare există în oricare dintre liniile fișierului
                var results = lines.Where(line => line.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

                if (results.Any())
                {
                    // Construiește un mesaj cu toate rezultatele găsite
                    string resultMessage = "Rezultate găsite:\n\n" + string.Join("\n", results);
                    MessageBox.Show(resultMessage, "Rezultate căutare");
                }
                else
                {
                    MessageBox.Show("Nicio activitate găsită.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A apărut o eroare la citirea fișierului: " + ex.Message);
            }
        }
    }
}
