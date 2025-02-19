/*TO DO

- "New message" button which clears label5 and richtextBox and enables radioButtons and comboBoxes 
- Multiple language UI
*/
using System.Collections;
using System.Drawing.Design;
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
            InitialiseRotors();
        }

        private List<char> alphabet = new List<char>();
        private List<char> rotor_1 = new List<char>(); //{ 'N', 'O', 'C', 'W', 'L', 'H', 'P', 'R', 'K', 'Y', 'U', 'Q', 'V', 'I', 'J', 'D', 'E', 'M', 'G', 'F', 'T', 'A', 'B', 'S', 'Z', 'X' };
        private List<char> rotor_2 = new List<char>(); //{ 'C', 'E', 'J', 'A', 'Q', 'V', 'D', 'G', 'U', 'B', 'O', 'T', 'X', 'P', 'S', 'I', 'Y', 'F', 'N', 'M', 'W', 'Z', 'R', 'H', 'K', 'L' };
        private List<char> rotor_3 = new List<char>(); //{ 'S', 'V', 'E', 'Z', 'G', 'Y', 'I', 'K', 'J', 'N', 'W', 'T', 'B', 'O', 'M', 'Q', 'P', 'H', 'A', 'U', 'C', 'X', 'D', 'L', 'F', 'R' };

        private Dictionary<int, int> rotor3_rotor2 = new Dictionary<int, int> {{10, 12}, {2, 22}, {18, 9}, {23, 21}, {21, 11}, {22, 19}, {5, 18}, {13, 23}, {16, 1}, {1, 13},
        {17, 5}, {3, 6}, {9, 2}, {8, 8}, {15, 14}, {12, 15}, {20, 10}, {14, 17}, {4, 16}, {7, 25}, {19, 24}, {11, 20}, {24, 4}, {6, 3}, {25, 7}, {0, 0}};
        private Dictionary<int, int> rotor2_rotor1 = new Dictionary<int, int> {{6, 6}, {19, 23}, {20, 21}, {23, 16}, {13, 11}, {15, 9}, {16, 17}, {1, 20}, {7, 13}, {8, 14},
        {2, 5}, {3, 19}, {18, 22}, {0, 7}, {12, 25}, {24, 10}, {10, 4}, {5, 1}, {25, 24}, {17, 2}, {14, 15}, {21, 0}, {11, 12}, {4, 18}, {22, 3}, {9, 8}};
        private Dictionary<int, int> Reflector = new Dictionary<int, int> { { 19, 25 }, { 22, 16 }, { 3, 10 }, { 6, 8 }, { 20, 12 }, { 1, 5 }, { 24, 13 },
        { 2, 17 }, { 21, 11 }, { 14, 9 }, { 18, 7 }, { 4, 15 }, { 0, 23 } };

        private bool flag_comboBox1 = false;
        private bool flag_comboBox2 = false;
        private bool flag_comboBox3 = false;

        #region Methods
        private void InitialiseAlphabet()
        {
            for (int i = 0; i < 26; i++)
            {
                alphabet.Add((char)(i + 65));
            }
        }
        private void InitialiseRotors()
        {
            for (int i = 0; i < 26; i++)
            {
                rotor_1.Add(alphabet[i]);
                rotor_2.Add(alphabet[i]);
                rotor_3.Add(alphabet[i]);
            }
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
        private List<char> ResetRotor(List<char> rotor)
        {
            rotor.Clear();
            for (int i = 0; i < 26; i++)
            {
                rotor.Add((char)(i + 65));
            }
            return rotor;
        }
        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!flag_comboBox1)
            {
                if (comboBox1.Text != "1")
                {
                    RotateRotor(rotor_1, int.Parse(comboBox1.Text) - 1);
                }
                flag_comboBox1 = true;
            }
            else
            {
                RotateRotor(rotor_1, 1);
            }


        }
        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (!flag_comboBox2)
            {
                if (comboBox2.Text != "1")
                {
                    RotateRotor(rotor_2, int.Parse(comboBox2.Text) - 1);
                }
                flag_comboBox2 = true;
            }
            else
            {
                RotateRotor(rotor_2, 1);
            }
        }
        private void comboBox3_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (!flag_comboBox3)
                {
                    if (comboBox3.Text != "1")
                    {
                        RotateRotor(rotor_3, int.Parse(comboBox3.Text) - 1);
                    }
                    flag_comboBox3 = true;
                }
                else
                {
                    RotateRotor(rotor_3, 1);
                }
            }
            else if (radioButton2.Checked)
            {
                if (!flag_comboBox3)
                {
                    if (comboBox3.Text != "26")
                    {
                        RotateRotor(rotor_3, int.Parse(comboBox3.Text) - 1);
                    }
                    flag_comboBox3 = true;
                }
                else
                {
                    RotateRotor(rotor_3, 1);
                }
            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (flag_comboBox1 && flag_comboBox2 && flag_comboBox3 && (radioButton1.Checked || radioButton2.Checked))
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;

                if (label5.Text == "Make sure that the you have checked encryption or decryption\nand rotors are set to the right setting."
                    || label5.Text == "Your message will show here!")
                {
                    if (label5.Text == "Make sure that the you have checked encryption or decryption\nand rotors are set to the right setting.")
                    {
                        richTextBox1.Text = "";
                    }
                    label5.Text = "";
                }

                if (radioButton1.Checked)
                {
                    #region Encryption
                    //Rotors rotation
                    if (int.Parse(comboBox1.Text) == 26 && int.Parse(comboBox2.Text) % 4 == 0 && int.Parse(comboBox3.Text) % 6 == 0)
                    {
                        comboBox1.Text = 1.ToString();
                    }
                    else if (int.Parse(comboBox2.Text) % 4 == 0 && int.Parse(comboBox3.Text) % 6 == 0)
                    {
                        comboBox1.Text = (int.Parse(comboBox1.Text) + 1).ToString();
                    }

                    if (int.Parse(comboBox2.Text) == 26 && int.Parse(comboBox3.Text) % 6 == 0)
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
                    else 
                        comboBox3.Text = (int.Parse(comboBox3.Text) + 1).ToString();

                    //Ecnryption logic
                    if (richTextBox1.Text != "")
                    {
                        char currentLetter = Char.ToUpper(richTextBox1.Text[richTextBox1.Text.Length - 1]);

                        for (int i = 0; i < rotor_3.Count; i++)
                        {
                            if (rotor_3[i] == currentLetter)
                            {
                                currentLetter = (char)i;
                                break;
                            }
                        }

                        currentLetter = (char)rotor3_rotor2[currentLetter];

                        currentLetter = (char)rotor2_rotor1[currentLetter];


                        if (Reflector.ContainsKey(currentLetter))
                        {
                            currentLetter = (char)Reflector[currentLetter];
                        }
                        else
                        {
                            currentLetter = (char)Reflector.FirstOrDefault(x => x.Value == currentLetter).Key;
                        }

                        currentLetter = (char)rotor2_rotor1[currentLetter];

                        currentLetter = (char)rotor3_rotor2[currentLetter];

                        if (Char.IsUpper(richTextBox1.Text[richTextBox1.Text.Length - 1]))
                        {
                            label5.Text += rotor_3[currentLetter];
                        }
                        else
                            label5.Text += char.ToLower(rotor_3[currentLetter]);

                    }
                    #endregion
                }
                else if (radioButton2.Checked)
                {
                    #region Decryption
                    //Rotors rotation
                    if (int.Parse(comboBox1.Text) == 1)
                    {
                        comboBox1.Text = 26.ToString();
                    }
                    else if (int.Parse(comboBox2.Text) % 4 == 0 && int.Parse(comboBox3.Text) % 6 == 0)
                    {
                        comboBox1.Text = (int.Parse(comboBox1.Text) - 1).ToString();
                    }

                    if (int.Parse(comboBox2.Text) == 1)
                    {
                        comboBox2.Text = 26.ToString();
                    }
                    else if (int.Parse(comboBox3.Text) % 6 == 0)
                    {
                        comboBox2.Text = (int.Parse(comboBox2.Text) - 1).ToString();
                    }

                    if (int.Parse(comboBox3.Text) == 1)
                    {
                        comboBox3.Text = 26.ToString();
                    }
                    else
                        comboBox3.Text = (int.Parse(comboBox3.Text) - 1).ToString();

                    //Decryption logic
                    if (richTextBox1.Text != "")
                    {
                        char currentLetter = Char.ToUpper(richTextBox1.Text[richTextBox1.Text.Length - 1]);
                    }
                    #endregion
                }
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
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            label5.Text = "Your message will show here!";

            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label5.Text = "";
                foreach (var item in richTextBox1.Text.ToUpper())
                {

                }
            }
            else if (radioButton2.Checked)
            {
                label5.Text = "";
            }
            else
            {
                label5.Text = "Make sure that the you have checked encryption or decryption\nand rotors are set to the right setting.";
            }
        }
    }
}
