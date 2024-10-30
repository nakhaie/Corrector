using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
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
                    filePath = filePath.Insert(filePath.IndexOf('.'), "_Fixed");

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    ClearText(fileStream, filePath);
                }
            }

            return filePath;
        }

        private void ClearText(Stream stream, string clonePath)
        {
            string ItemRead;
            Dictionary<string, List<AssetName>> tempDomains = new Dictionary<string, List<AssetName>>();
            List<string> Keys = new List<string>();

            using (StreamReader reader = new StreamReader(stream))
            {
                while ((ItemRead = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrEmpty(ItemRead) || string.IsNullOrWhiteSpace(ItemRead))
                        continue;

                    string[] itemArray = ItemRead.Split(',');

                    if (!tempDomains.ContainsKey(itemArray[1]))
                    {
                        tempDomains.Add(itemArray[1], new List<AssetName>());
                        Keys.Add(itemArray[1]);
                    }

                    tempDomains[itemArray[1]].Add(new AssetName(itemArray[0], itemArray[2], itemArray[3], itemArray[4]));
                }
            }

            if (!File.Exists(clonePath))
            {
                // Create a file to write to.
                File.CreateText(clonePath);
            }

            // Open the file to read from.
            using (StreamWriter sr = new StreamWriter(clonePath))
            {
                string ItemOpend = "{";
                string domainForm = "\"{0}\", new List<AssetName>";
                string domainOpend = "  {";
                string assetOpend = "       {";
                string assetForm = "new AssetName(\"{0}\",\"{1}\",\"{2}\",\"{3}\")";
                string assetClosed = "},";
                string ItemClosed = "  }\n},";

                sr.Write("");

                foreach (string key in Keys)
                {
                    sr.WriteLine(ItemOpend + string.Format(domainForm, key));
                    sr.WriteLine(domainOpend);

                    foreach (var item in tempDomains[key])
                    {
                        sr.WriteLine(assetOpend
                            + string.Format(assetForm, item.AssetType, item.Prefix, item.Suffix, item.Example)
                            + assetClosed);
                    }


                    sr.WriteLine(ItemClosed);
                }
            }

            Process.Start("notepad.exe", clonePath);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = OpenFileDialog();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
