/*TO DO
? - Numbers encryption
- Enable to erase
- Unsupported symbol
done - Multiple language UI
done - Unsupported symbol protection
done - Decryption
done - Error label
done - ComboBox initialisation
done - "New message" button which clears label5 and richtextBox and enables radioButtons and comboBoxes 
*/
using System.Collections;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
namespace _1st_try
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitialiseRotors();
        }

        private bool flag_comboBox1 = false;
        private bool flag_comboBox2 = false;
        private bool flag_comboBox3 = false;

        private List<int> rotor_1 = new List<int>();
        private List<int> rotor_2 = new List<int>();
        private List<int> rotor_3 = new List<int>();

        private Dictionary<int, int> rotor3_rotor2 = new Dictionary<int, int> {{10, 12}, {2, 22}, {18, 9}, {23, 21}, {21, 11}, {22, 19}, {5, 18}, {13, 23}, {16, 1}, {1, 13},
        {17, 5}, {3, 6}, {9, 2}, {8, 8}, {15, 14}, {12, 15}, {20, 10}, {14, 17}, {4, 16}, {7, 25}, {19, 24}, {11, 20}, {24, 4}, {6, 3}, {25, 7}, {0, 0}};
        private Dictionary<int, int> rotor2_rotor1 = new Dictionary<int, int> {{6, 6}, {19, 23}, {20, 21}, {23, 16}, {13, 11}, {15, 9}, {16, 17}, {1, 20}, {7, 13}, {8, 14},
        {2, 5}, {3, 19}, {18, 22}, {0, 7}, {12, 25}, {24, 10}, {10, 4}, {5, 1}, {25, 24}, {17, 2}, {14, 15}, {21, 0}, {11, 12}, {4, 18}, {22, 3}, {9, 8}};
        private Dictionary<int, int> Reflector = new Dictionary<int, int> { { 19, 25 }, { 22, 16 }, { 3, 10 }, { 6, 8 }, { 20, 12 }, { 1, 5 }, { 24, 13 },
        { 2, 17 }, { 21, 11 }, { 14, 9 }, { 18, 7 }, { 4, 15 }, { 0, 23 } };

        #region Methods
        private void InitialiseRotors()
        {
            rotor_1.Clear();
            rotor_2.Clear();
            rotor_3.Clear();

            for (int i = 0; i < 26; i++)
            {
                rotor_1.Add(i);
                rotor_2.Add(i);
                rotor_3.Add(i);
            }
        }
        private List<int> RotateRotor(List<int> rotor, int rotations)
        {
            for (int i = 0; i < rotations; i++)
            {
                int temp = rotor[0];//char
                for (int j = 0; j < rotor.Count - 1; j++)
                {
                    rotor[j] = rotor[j + 1];
                }
                rotor[rotor.Count - 1] = temp;
            }
            return rotor;
        }
        #endregion

        private void CB1_Rotor3(object sender, EventArgs e)
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
            comboBox1.Enabled = false;
        }

        private void CB2_Rotor2(object sender, EventArgs e)
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
            comboBox2.Enabled = false;
        }

        private void CB3_Rotor1(object sender, EventArgs e)
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
            comboBox3.Enabled = false;
        }

        private void NewMessage(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            label3.Text = string.Empty;

            if (radioButton1.Checked)
            {
                label5.Text = "Your message will show here!";
            }
            else label5.Text = "Съобщението ще се покаже тук.";

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;

            InitialiseRotors();

            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;

            flag_comboBox1 = false;
            flag_comboBox2 = false;
            flag_comboBox3 = false;
        }

        private void Encryption(object sender, EventArgs e)
        {
            #region Encryption

            richTextBox1.Enabled = false;
            try
            {
                bool isLetter = true;

                label5.Text = string.Empty;
                foreach (var item in richTextBox1.Text)
                {
                    if (!string.IsNullOrEmpty(richTextBox1.Text))
                    {
                        if (!(((int)richTextBox1.Text[richTextBox1.Text.Length - 1] >= 65 &&
                            (int)richTextBox1.Text[richTextBox1.Text.Length - 1] <= 90) ||
                            ((int)richTextBox1.Text[richTextBox1.Text.Length - 1] >= 97 &&
                            (int)richTextBox1.Text[richTextBox1.Text.Length - 1] <= 122)))
                        {
                            isLetter = false;
                        }
                        if (flag_comboBox1 && flag_comboBox2 && flag_comboBox3 && isLetter)
                        {
                            comboBox1.Enabled = false;
                            comboBox2.Enabled = false;
                            comboBox3.Enabled = false;

                            if (label5.Text == "Make sure that the rotors are set to the right setting."
                                || label5.Text == "Your message will show here!"
                                || label5.Text == "Уверете се, че роторите са на правилната настройка."
                                || label5.Text == "Съобщението ще се покаже тук")
                            {
                                if (label5.Text == "Make sure that the rotors are set to the right setting."
                                    || label5.Text == "Уверете се, че роторите са на правилната настройка.")
                                {
                                    richTextBox1.Text = "";
                                }
                                label5.Text = "";
                                label3.Text = "";
                            }


                            //Encryption logic
                            char currentLetter = Char.ToUpper(item);

                            for (int i = 0; i < rotor_3.Count; i++)
                            {
                                if (rotor_3[i] == currentLetter - 65)
                                {
                                    currentLetter = (char)i;
                                    break;
                                }
                            }

                            currentLetter = (char)rotor3_rotor2[currentLetter];

                            currentLetter = (char)rotor_2[currentLetter];

                            currentLetter = (char)rotor2_rotor1[currentLetter];

                            currentLetter = (char)rotor_1[currentLetter];

                            if (Reflector.ContainsKey(currentLetter))
                            {
                                currentLetter = (char)Reflector[currentLetter];
                            }
                            else
                            {
                                currentLetter = (char)Reflector.First(x => x.Value == currentLetter).Key;
                            }

                            currentLetter = (char)rotor_1[currentLetter];

                            currentLetter = (char)rotor2_rotor1[currentLetter];

                            currentLetter = (char)rotor_2[currentLetter];

                            currentLetter = (char)rotor3_rotor2[currentLetter];

                            currentLetter = (char)rotor_3[currentLetter];

                            if (Char.IsUpper(item))
                            {
                                label5.Text += (char)(currentLetter + 65);
                            }
                            else
                                label5.Text += char.ToLower((char)(currentLetter + 65));

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


                        }
                        else if (isLetter)
                        {
                            if (radioButton1.Checked)
                            {
                                label5.Text = "Make sure that the rotors are set to the right setting.";
                            }
                            else label5.Text = "Уверете се, че роторите са на правилната настройка.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                label3.Text = "Encryption\n" + ex.Message;
            }
            richTextBox1.Enabled = true;
            richTextBox1.Focus();
            #endregion
        }
        private void Decryption(object sender, EventArgs e)
        {
            #region Decryption

            richTextBox1.Enabled = false;
            try
            {
                bool isLetter = true;

                label5.Text = string.Empty;
                foreach (var item in richTextBox1.Text)
                {
                    isLetter = true;
                    if (!(((int)richTextBox1.Text[richTextBox1.Text.Length - 1] >= 65 &&
                        (int)richTextBox1.Text[richTextBox1.Text.Length - 1] <= 90) ||
                        ((int)richTextBox1.Text[richTextBox1.Text.Length - 1] >= 97 &&
                        (int)richTextBox1.Text[richTextBox1.Text.Length - 1] <= 122)))
                    {
                        isLetter = false;
                    }

                    if (flag_comboBox1 && flag_comboBox2 && flag_comboBox3 && richTextBox1.Text != "" && isLetter)
                    {
                        comboBox1.Enabled = false;
                        comboBox2.Enabled = false;
                        comboBox3.Enabled = false;

                        if (label5.Text == "Make sure that the rotors are set to the right setting."
                            || label5.Text == "Your message will show here!"
                            || label5.Text == "Уверете се, че роторите са на правилната настройка."
                            || label5.Text == "Съобщението ще се покаже тук."
                            )
                        {
                            if (label5.Text == "Make sure that the rotors are set to the right setting."
                                || label5.Text == "Уверете се, че роторите са на правилната настройка.")
                            {
                                richTextBox1.Text = "";
                            }
                            label5.Text = "";
                            label3.Text = "";
                        }

                        //Decryption logic
                        char currentLetter = Char.ToUpper(item);

                        for (int i = 0; i < rotor_3.Count; i++)
                        {
                            if (rotor_3[i] == currentLetter - 65)
                            {
                                currentLetter = (char)i;
                                break;
                            }
                        }

                        currentLetter = (char)rotor3_rotor2.First(x => x.Value == currentLetter).Key;

                        currentLetter = (char)rotor_2.IndexOf(currentLetter);

                        currentLetter = (char)rotor2_rotor1.First(x => x.Value == currentLetter).Key;

                        currentLetter = (char)rotor_1.IndexOf(currentLetter);

                        if (Reflector.ContainsKey(currentLetter))
                        {
                            currentLetter = (char)Reflector[currentLetter];
                        }
                        else
                        {
                            currentLetter = (char)Reflector.First(x => x.Value == currentLetter).Key;
                        }

                        currentLetter = (char)rotor_1.IndexOf(currentLetter);

                        currentLetter = (char)rotor2_rotor1.First(x => x.Value == currentLetter).Key;

                        currentLetter = (char)rotor_2.IndexOf(currentLetter);

                        currentLetter = (char)rotor3_rotor2.First(x => x.Value == currentLetter).Key;

                        currentLetter = (char)rotor_3[currentLetter];

                        if (Char.IsUpper(item))
                        {
                            label5.Text += (char)(currentLetter + 65);
                        }
                        else
                            label5.Text += char.ToLower((char)(currentLetter + 65));

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
                    }
                    else if (isLetter)
                    {
                        if (radioButton1.Checked)
                        {
                            label5.Text = "Make sure that the rotors are set to the right setting.";
                        }
                        else label5.Text = "Уверете се, че роторите са на правилната настройка.";
                    }
                }
            }
            catch (Exception ex)
            {
                label3.Text = "Decryption\n" + ex.Message;
            }
            richTextBox1.Enabled = true;
            richTextBox1.Focus();
            #endregion
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (label5.Text == "" || label5.Text == "Съобщението ще се покаже тук.")
            {
                label5.Text = "Your message will show here!";
            }
            if (label1.Text == "Въведете текста долу.")
            {
                label1.Text = "Enter your text below!";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (label5.Text == "" || label5.Text == "Your message will show here!")
            {
                label5.Text = "Съобщението ще се покаже тук.";
            }
            if (label1.Text == "Enter your text below!")
            {
                label1.Text = "Въведете текста долу.";
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}