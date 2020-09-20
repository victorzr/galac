using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class FilterFile : Form
    {
        public FilterFile()
        {
            InitializeComponent();
        }

        private void FilterFile_Load(object sender, EventArgs e)
        {
            string defaultFilePath = System.IO.Directory.GetCurrentDirectory() + "\\Origen.txt";
            FilterText(defaultFilePath);
        }

        private void newFile_Click(object sender, EventArgs e)
        {
            inputText.Text = String.Empty;
            outputText.Text = String.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Seleccione el archivo de texto";
            openFileDialog.Filter = "TXT files | *.txt";
            openFileDialog.InitialDirectory = System.IO.Directory.GetCurrentDirectory();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                FilterText(filePath);
            }
        }

        private void emailOutput_Click(object sender, EventArgs e)
        {
            EmailFile email = new EmailFile();
            email.ShowDialog();
        }       


        private void FilterText(string filePath)
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines(filePath);
                string output = String.Empty;

                Regex regex = new Regex(@"\b*\w*s\w*\b*", RegexOptions.IgnoreCase);
                MatchCollection matches;

                foreach (string line in lines)
                {
                    inputText.AppendText($"{line}\r\n");
                    matches = regex.Matches(line);

                    foreach (Match match in matches)
                    {
                        output += $"{match.ToString().Trim()}; ";
                    }
                }

                System.IO.File.WriteAllText(System.IO.Directory.GetCurrentDirectory() + "\\Palabras.txt", output);
                outputText.Text = output;
            }
            catch (System.IO.FileNotFoundException)
            {
                //No se encontro el archivo por defecto
            }            
        }
    }
}
