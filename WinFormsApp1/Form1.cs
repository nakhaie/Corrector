using System.Linq;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private float ListMaxHeight;
        private string FileName;
        private string FileExtention;
        private string LastAddress;

        public string OpenFileDialog()
        {
            var filePath = string.Empty;
            FileName = string.Empty;
            FileExtention = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (LastAddress == string.Empty)
                {
                    openFileDialog.InitialDirectory = "c:\\";
                }
                else
                {
                    openFileDialog.InitialDirectory = LastAddress;
                }

                openFileDialog.Filter = SupportedItem;
                openFileDialog.FilterIndex = 0;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.SafeFileName;
                    LastAddress = openFileDialog.FileName;
                }
            }

            return filePath;
        }

        private void SetDomain(string selected)
        {
            textBox2.Text = string.Empty;
            listBox1.Items.Clear();
            listBox1.Sorted = true;
            int tempHeight = 0;

            if (selected == "All")
            {
                foreach (var asset in AssetNames)
                {
                    listBox1.Items.Add(asset.AssetType);
                }

                tempHeight = (AssetNames.Count * 22) / 2;
            }
            else
            {
                int lenght = 2;
                foreach (var asset in AssetNames.Where(x => x.Domain == selected))
                {
                    listBox1.Items.Add(asset.AssetType);
                    lenght++;
                }

                tempHeight = (lenght * 22) / 2;
            }

            listBox1.Size = new Size(listBox1.Size.Width, ((int)MathF.Max(ListMaxHeight, tempHeight)));
        }

        public void SetNameField()
        {
            FileName = string.Empty;

            if (textBox1.Text.Contains('.'))
            {
                string[] fileNamePiece = textBox1.Text.Split('.');

                FileExtention = fileNamePiece.Last();

                for (int i = 0; i < fileNamePiece.Length - 1; i++)
                {
                    FileName += fileNamePiece[i];
                }
            }
            else
            {
                FileName = textBox1.Text;
            }

            string tempName = string.Empty;

            foreach (char charName in FileName)
            {
                if (charName == ' ')
                {
                    tempName += '-';
                }
                else if (charName == '+'
                     || charName == '}'
                     || charName == '{'
                     || charName == '['
                     || charName == ']'
                     || charName == '('
                     || charName == ')')
                {
                    continue;
                }
                else
                {
                    tempName += charName;
                }
            }

            FileName = tempName;

            if (listBox1.SelectedItem != null)
            {
                string SelectedItem = listBox1.SelectedItem.ToString();

                AssetName asset = AssetNames.Find(x => x.AssetType == SelectedItem);

                if (string.IsNullOrEmpty(asset.ExceptionText))
                {
                    ExPanel.Visible = false;
                    NameField.Text = string.Format(asset.Example, FileName);
                }
                else
                {
                    ExPanel.Visible = true;
                    ExceptionLabel.Text = asset.ExceptionText;
                    NameField.Text = string.Format(asset.Example, FileName, ExBox.Text);
                }

                if (!string.IsNullOrEmpty(VerText.Text))
                {
                    NameField.Text += $"_{VerText.Text}";
                }
            }
            else
            {
                NameField.Text = FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string getAddress = OpenFileDialog();

            if (!string.IsNullOrEmpty(getAddress))
            {
                textBox1.Text = getAddress;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListMaxHeight = listBox1.Size.Height;

            foreach (var domain in Domains)
            {
                comboBox1.Items.Add(domain);
            }

            comboBox1.SelectedItem = "All";

            SetDomain(comboBox1.SelectedItem.ToString());

            ExPanel.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDomain(comboBox1.SelectedItem.ToString());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string selected = comboBox1.SelectedItem.ToString();
            listBox1.Sorted = false;

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                SetDomain(selected);
                return;
            }

            List<string> opetions;
            listBox1.Items.Clear();

            if (selected == "All")
            {
                opetions = AssetNames.Select(x => x.AssetType).ToList();
            }
            else
            {
                opetions = AssetNames.Where(x => x.Domain == selected).Select(x => x.AssetType).ToList();
            }

            opetions.Sort();

            int lenght = 2;
            foreach (var asset in opetions.Where(x => x.StartsWith(textBox2.Text, StringComparison.CurrentCultureIgnoreCase)))
            {
                listBox1.Items.Add(asset);
                lenght++;
            }

            int tempHeight = (lenght * 22) / 2;

            listBox1.Size = new Size(listBox1.Size.Width, ((int)MathF.Max(ListMaxHeight, tempHeight)));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SetNameField();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetNameField();
        }

        private void ExBox_TextChanged(object sender, EventArgs e)
        {
            SetNameField();
        }

        private void VerText_TextChanged(object sender, EventArgs e)
        {
            SetNameField();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(NameField.Text);
        }
    }
}
