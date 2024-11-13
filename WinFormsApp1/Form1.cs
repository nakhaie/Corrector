using System.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace WinFormsApp1
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private float ListMaxHeight;

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
                }
            }

            return filePath;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = OpenFileDialog();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ListMaxHeight = listBox1.Size.Height;
            var keys = Domains.Keys;

            comboBox1.Items.Add("All");

            foreach (var key in keys)
            {
                comboBox1.Items.Add(key);
            }

            comboBox1.SelectedItem = "All";

            SetDomain(comboBox1.SelectedItem.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDomain(comboBox1.SelectedItem.ToString());
        }

        private void SetDomain(string selected)
        {
            textBox2.Text = string.Empty;
            listBox1.Items.Clear();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string selected = comboBox1.SelectedItem.ToString();

            if (textBox2.Text == string.Empty)
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
    }
}
