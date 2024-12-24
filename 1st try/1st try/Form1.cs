using System.Security.Cryptography;
using System.Windows.Forms;
namespace _1st_try
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitialiseAlphabet();
        }

        private List<char> alphabet = new List<char>();
        private List<char> rotor_1 = new List<char>();
        private List<char> rotor_2 = new List<char>();
        private List<char> rotor_3 = new List<char>();

        #region Methods
        public List<char> InitialiseAlphabet()
        {
            for (int i = 0; i < 26; i++)
            {
                alphabet.Add((char)(i + 65));
            }
            return alphabet;
        }
        private List<char> ResetRotor(List<char> rotor)
        {
            rotor.Clear();
            for (int i = 0; i < 26; i++)
            {
                rotor.Add((char)(i + 65));
            }
            return rotor;
        }
        private List<char> RotateRotor(List<char> rotor, int rotations)
        {
            for (int i = 0; i < rotations; i++)
            {
                char temp = rotor[0];
                for (int j = 0; j < rotor.Count - 1; j++)
                {
                    rotor[j] = rotor[j + 1];
                }
                rotor[rotor.Count - 1] = temp;
            }
            return rotor;
        }
        private List<char> Shuffle(List<char> list)
        {
            char[] shuffled_arr = new char[list.Count];
            Random rnd = new Random();

            for (int i = 0; i < list.Count; i++)
            {
                int a;
                do
                {
                    a = rnd.Next(list.Count);
                } while (shuffled_arr[a].ToString() != "\0");
                shuffled_arr[a] = list[i];
            }
            return shuffled_arr.ToList();
        }
        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetRotor(rotor_1);
            RotateRotor(rotor_1, int.Parse(comboBox1.Text) - 1);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetRotor(rotor_2);
            RotateRotor(rotor_2, int.Parse(comboBox2.Text) - 1);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetRotor(rotor_3);
            RotateRotor(rotor_3, int.Parse(comboBox3.Text) - 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (comboBox1.Text is not "" && comboBox2.Text is not "" && comboBox3.Text is not "")
                {
                    //Rotors rotation
                    if (int.Parse(comboBox1.Text) == 26)
                    {
                        comboBox1.Text = 1.ToString();
                    }
                    else if (int.Parse(comboBox2.Text) % 4 == 0 && int.Parse(comboBox3.Text) % 6 == 0)
                    {
                        comboBox1.Text = (int.Parse(comboBox1.Text) + 1).ToString();
                    }

                    if (int.Parse(comboBox2.Text) == 26)
                    {
                        comboBox2.Text = 1.ToString();
                    }
                    else if (int.Parse(comboBox3.Text) % 6 == 0)
                    {
                        comboBox2.Text = (int.Parse(comboBox2.Text) + 1).ToString();
                    }

                    if (int.Parse(comboBox3.Text) == 26)
                    {
                        comboBox3.Text = 1.ToString();
                    }
                    comboBox3.Text = (int.Parse(comboBox3.Text) + 1).ToString();

                    //Encryption logic
                    char letter = label5.Text[label5.Text.Length - 1];

                }
                else
                {
                    label5.Text = "Rotors must be set to the right setting!";
                }
            }
            else if (radioButton2.Checked)
            {
                if (comboBox1.Text is not "" && comboBox2.Text is not "" && comboBox3.Text is not "")
                {
                    //Rotors rotation
                    if (int.Parse(comboBox1.Text) == 26)
                    {
                        comboBox1.Text = 1.ToString();
                    }
                    else if (int.Parse(comboBox2.Text) % 4 == 0 && int.Parse(comboBox3.Text) % 6 == 0)
                    {
                        comboBox1.Text = (int.Parse(comboBox1.Text) - 1).ToString();
                    }

                    if (int.Parse(comboBox2.Text) == 26)
                    {
                        comboBox2.Text = 1.ToString();
                    }
                    else if (int.Parse(comboBox3.Text) % 6 == 0)
                    {
                        comboBox2.Text = (int.Parse(comboBox2.Text) - 1).ToString();
                    }

                    if (int.Parse(comboBox3.Text) == 26)
                    {
                        comboBox3.Text = 1.ToString();
                    }
                    comboBox3.Text = (int.Parse(comboBox3.Text) - 1).ToString();

                    //Encryption logic
                    char letter = label5.Text[label5.Text.Length - 1];

                }
                else
                {
                    label5.Text = "Rotors must be set to the right setting!";
                }
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
