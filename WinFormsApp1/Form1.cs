using System.Globalization;

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

        private void SetDomain()
        {
            string selected = comboBox1.SelectedItem.ToString();

            SearchBox.Text = string.Empty;
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

        private void SetSreach()
        {
            string selected = comboBox1.SelectedItem.ToString();

            List<string> opetions;
            listBox1.Sorted = false;
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
            foreach (var asset in opetions.Where(x => x.StartsWith(SearchBox.Text, StringComparison.CurrentCultureIgnoreCase)))
            {
                listBox1.Items.Add(asset);
                lenght++;
            }

            int tempHeight = (lenght * 22) / 2;

            listBox1.Size = new Size(listBox1.Size.Width, ((int)MathF.Max(ListMaxHeight, tempHeight)));
        }
        
        public void SetNameField()
        {
            //Prefix_ModelType_Name_suffix_Variation(A,B,C)_SpcVersion(IIV)_Version(#)
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
                else if (string.IsNullOrEmpty(tempName))
                {
                    tempName += charName.ToString().ToUpper();
                }
                else
                {
                    tempName += charName;
                }
            }

            FileName = tempName;

            if (!string.IsNullOrEmpty(ClassBox.Text))
            {
                FileName = $"{ClassBox.Text.ToUpper()[0]}{ClassBox.Text.Substring(1)}_{FileName}";
            }

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
            }
            else
            {
                NameField.Text = FileName;
            }

            string variationTemp = VariationBox.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(variationTemp))
            {
                variationTemp = variationTemp.Substring(variationTemp.Length - 1);

                if (!string.IsNullOrWhiteSpace(variationTemp))
                {
                    NameField.Text += $"_{variationTemp}";
                }
            }

            variationTemp = VariantBox.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(variationTemp))
            {
                variationTemp = variationTemp.Substring(3);

                if (!string.IsNullOrWhiteSpace(variationTemp))
                {
                    NameField.Text += $"_{variationTemp}";
                }
            }

            if (!string.IsNullOrEmpty(VerText.Text))
            {
                NameField.Text += $"_{VerText.Text}";
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

            VariationBox.Items.AddRange("0)  ,1) A,2) B,3) C,4) D,5) E,6) F,7) G,8) H".Split(','));
            VariantBox.Items.AddRange("0)  ,1) I,2) II,3) III,4) IV,5) V,6) VI,7) VII,8) VIII,9) IX,10) X".Split(','));

            VariationBox.SelectedIndex = 0;
            VariantBox.SelectedIndex = 0;

            VariantBox.SelectedIndexChanged += VariantBox_SelectedIndexChanged;
            VariationBox.SelectedIndexChanged += VariationBox_SelectedIndexChanged;

            SetDomain();

            ExPanel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string getAddress = OpenFileDialog();

            if (!string.IsNullOrEmpty(getAddress))
            {
                textBox1.Text = getAddress;
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchBox.Text))
            {
                SetDomain();
            }
            else
            {
                SetSreach();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDomain();
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

        private void ClassBox_TextChanged(object sender, EventArgs e)
        {
            SetNameField();
        }

        private void VariationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetNameField();
        }

        private void VariantBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetNameField();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(NameField.Text);
        }
    }
}
