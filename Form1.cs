using System.Collections;

namespace Conc
{
    public partial class Form1 : Form
    {
        private ArrayList words = new ArrayList();
        private ArrayList concatenatedWords = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void add_word_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter something on the text box");
            }
            else
            {

                if (comboBox1.Items.Contains(textBox1.Text) || comboBox2.Items.Contains(textBox1.Text))
                {
                    MessageBox.Show("Word Already Exist on list");

                }
                else
                {
                    comboBox1.Items.Add(textBox1.Text);
                    comboBox2.Items.Add(textBox1.Text);
                    words.Add(textBox1.Text);
                    MessageBox.Show($"{textBox1.Text} Added to the list");
                    textBox1.Clear();
                }


            }
        }

        private void remove1_CheckedChanged(object sender, EventArgs e)
        {
            conc.Text = "Remove";
        }

        private void remove2_CheckedChanged(object sender, EventArgs e)
        {
            conc.Text = "Remove";

        }

        private void conc_Click(object sender, EventArgs e)
        {
            if (conc.Text== "concatenate")
            {
                if(comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
                {
                    MessageBox.Show("Please selected from both lists");
                }
                else if(comboBox1.SelectedItem== comboBox2.SelectedItem)
                {
                    MessageBox.Show("Select different Items");
                }
                else
                {
                    labelout.Text = comboBox1.SelectedItem.ToString()+comboBox2.SelectedItem.ToString();
                    concatenatedWords.Add(labelout.Text);
                    MessageBox.Show(labelout.Text + " added to collection.");
                }
            }
            else
            {
                if (remove1.Checked) {
                    comboBox1.Items.Remove(comboBox1.SelectedItem);
                    MessageBox.Show("Word deleted from the collection.");
                    comboBox1.Text = "";
                } if (remove2.Checked)
                {
                    comboBox2.Items.Remove(comboBox2.SelectedItem);
                    MessageBox.Show("Word deleted from the collection.");
                    comboBox2.Text = "";
                }
            }
        }
    }
}