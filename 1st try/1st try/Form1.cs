//TO DO
/*
 -New message button which clears label5 and enables radioButtons and comboBoxes 
 */
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
        private List<char> rotor_1 = new List<char> { 'N', 'O', 'C', 'W', 'L', 'H', 'P', 'R', 'K', 'Y', 'U', 'Q', 'V', 'I', 'J', 'D', 'E', 'M', 'G', 'F', 'T', 'A', 'B', 'S', 'Z', 'X' };
        private List<char> rotor_2 = new List<char> { 'C', 'E', 'J', 'A', 'Q', 'V', 'D', 'G', 'U', 'B', 'O', 'T', 'X', 'P', 'S', 'I', 'Y', 'F', 'N', 'M', 'W', 'Z', 'R', 'H', 'K', 'L' };
        private List<char> rotor_3 = new List<char> { 'S', 'V', 'E', 'Z', 'G', 'Y', 'I', 'K', 'J', 'N', 'W', 'T', 'B', 'O', 'M', 'Q', 'P', 'H', 'A', 'U', 'C', 'X', 'D', 'L', 'F', 'R' };
        bool flag_comboBox1 = false;
        bool flag_comboBox2 = false;
        bool flag_comboBox3 = false;
        bool flag_initialisedRotors = false;

        #region Methods
        private List<char> InitialiseAlphabet()
        {
            for (int i = 0; i < 26; i++)
            {
                alphabet.Add((char)(i + 65));
            }
            return alphabet;
        }
        //private List<char> ResetRotor(List<char> rotor)
        //{
        //    rotor.Clear();
        //    for (int i = 0; i < 26; i++)
        //    {
        //        rotor.Add((char)(i + 65));
        //    }
        //    return rotor;
        //}
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
            RotateRotor(rotor_1, int.Parse(comboBox1.Text) - 1);
            flag_comboBox1 = true;
        }
        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            RotateRotor(rotor_2, int.Parse(comboBox2.Text) - 1);
            flag_comboBox2 = true;
        }
        private void comboBox3_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            if(!flag_comboBox3)
            {
                RotateRotor(rotor_3, int.Parse(comboBox3.Text) - 1);
                flag_comboBox3 = true;
            }
            else
            {
                RotateRotor(rotor_3, 1);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (flag_comboBox1 && flag_comboBox2 && flag_comboBox3 && radioButton1.Checked)
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;

                if (label5.Text == "Make sure that the you have checked encryption or decryption\nand rotors are set to the right setting."
                    || label5.Text == "Your encrypted message will show here!")
                {
                    label5.Text = "";
                }

                //Rotors rotation
                if (int.Parse(comboBox1.Text) == 26 && int.Parse(comboBox2.Text) % 4 == 0 && int.Parse(comboBox3.Text) % 6 == 0)//Previous -> int.Parse(comboBox1.Text) == 26
                {
                    RotateRotor(rotor_1, 1);
                    comboBox1.Text = 1.ToString();
                }
                else if (int.Parse(comboBox2.Text) % 4 == 0 && int.Parse(comboBox3.Text) % 6 == 0)
                {
                    comboBox1.Text = (int.Parse(comboBox1.Text) + 1).ToString();
                }

                if (int.Parse(comboBox2.Text) == 26 && int.Parse(comboBox3.Text) % 6 == 0)//Previous -> int.Parse(comboBox2.Text) == 26
                {
                    RotateRotor(rotor_2, 1);
                    comboBox2.Text = 1.ToString();
                }
                else if (int.Parse(comboBox3.Text) % 6 == 0)
                {
                    comboBox2.Text = (int.Parse(comboBox2.Text) + 1).ToString();
                }

                if (int.Parse(comboBox3.Text) == 26)
                {
                    RotateRotor(rotor_3, 1);
                    comboBox3.Text = 0.ToString();//Previous -> comboBox3.Text = 1.ToString();
                }
                comboBox3.Text = (int.Parse(comboBox3.Text) + 1).ToString();

                //Ecnryption logic
                char letter = richTextBox1.Text[richTextBox1.TextLength - 1];
                label5.Text += letter;
            }
            else if (flag_comboBox1 && flag_comboBox2 && flag_comboBox3 && radioButton2.Checked)
            {
                //Decription not done

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
                label5.Text += letter;

            }
            else
            {
                label5.Text = "Make sure that the you have checked encryption or decryption\nand rotors are set to the right setting.";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
