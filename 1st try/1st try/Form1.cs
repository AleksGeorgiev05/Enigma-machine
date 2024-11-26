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

        private void ShowMessage(string message)
        {
            label5.Text = "";

            for (int i = 0; i < alphabet.Count; i++)
            {
                label5.Text += alphabet[i];
            }
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
        private void PressedLetter()
        {
            if (comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "")
            {
                label5.Text = "The rotors must be set to the right setting!";
            }
            else
            {
                label5.Text = "";
                int value = int.Parse(comboBox3.Text);
                comboBox3.Text = (++value).ToString();
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetRotor(rotor_1);
            for (int i = 0; i < int.Parse(comboBox1.Text) - 1; i++)
            {
                char temp = rotor_1[0];
                for (int j = 0; j < rotor_1.Count - 1; j++)
                {
                    rotor_1[j] = rotor_1[j + 1];
                }
                rotor_1[rotor_1.Count - 1] = temp;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetRotor(rotor_2);
            for (int i = 0; i < int.Parse(comboBox1.Text) - 1; i++)
            {
                char temp = rotor_2[0];
                for (int j = 0; j < rotor_2.Count - 1; j++)
                {
                    rotor_2[j] = rotor_2[j + 1];
                }
                rotor_2[rotor_2.Count - 1] = temp;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetRotor(rotor_3);
            for (int i = 0; i < int.Parse(comboBox1.Text) - 1; i++)
            {
                char temp = rotor_3[0];
                for (int j = 0; j < rotor_3.Count - 1; j++)
                {
                    rotor_3[j] = rotor_3[j + 1];
                }
                rotor_3[rotor_3.Count - 1] = temp;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "")
            {
                label5.Text = "";
                label5.Text = "The rotors must be set to the right setting!";
            }
            else
            {
                label5.Text = "";
            }
        }
    }
}
