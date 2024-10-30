using System.Runtime.InteropServices;
using System.IO;
using CsvHelper;
using System.Diagnostics;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public List<AssetName> assetObjects = [];

        public Form1()
        {
            InitializeComponent();
        }

        public string OpenFileDialog()
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    ClearText(fileStream, filePath);
                }
            }

            return filePath;
        }

        private void ClearText(Stream stream, string clonePath)
        {
            if (!File.Exists(clonePath))
            {
                // Create a file to write to.
                File.CreateText(clonePath);
            }

            // Open the file to read from.
            using (StreamWriter sr = new StreamWriter(clonePath))
            {
                sr.Write("AssetType,Domain,Prefix,Suffix,Example\n");
                string txt = "";
                string item = "";
                int count = 0;

                using (StreamReader reader = new StreamReader(stream))
                {
                    while ((txt = reader.ReadLine()) != null)
                    {
                        if (string.IsNullOrEmpty(txt) || string.IsNullOrWhiteSpace(txt))
                            continue;

                        if (txt.StartsWith("<p") || !txt.StartsWith("<"))
                        {
                            if(!txt.StartsWith("<path"))
                            {
                                txt = txt.Remove(0, txt.IndexOf(">") + 1);

                                switch(txt)
                                {
                                    case "Example":
                                        continue;
                                    case "Prefix":
                                        continue;
                                    case "Suffix":
                                        continue;
                                }

                                if (count < 4)
                                {
                                    item += $"{txt},";
                                    count++;
                                }
                                else
                                {
                                    item += $"{txt}";
                                    sr.WriteLine(item);
                                    item = string.Empty;
                                    count = 0;
                                }
                            }
                        }
                    }
                }
            }

            Process.Start("notepad.exe", clonePath);
        }

        private void MakeSheet(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string txt = "";
                while ((txt = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrEmpty(txt) || string.IsNullOrWhiteSpace(txt))
                        continue;

                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = OpenFileDialog();
            assetObjects.Add(new AssetName());

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public bool TextValidation(string txt)
        {

            return true;
        }
    }
}
