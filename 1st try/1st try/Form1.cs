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

        public List<char> InitialiseAlphabet()
        {
            for (int i = 0; i < 26; i++)
            {
                alphabet.Add((char)(i + 65));
            }
            return alphabet;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PressedLetter();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        List<char> alphabet = new List<char>();

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
            if (comboBox3.Text == "")
            {
                label5.Text = "The rotors must be set to the right setting!";
                
            }
            else
            {
                int value = int.Parse(comboBox3.Text);
                comboBox3.Text = (++value).ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //ShowMessage(label5);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<char> rotor_1 = alphabet;

            for (int i = 0; i < int.Parse(comboBox1.Text); i++)
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
            List<char> rotor_1 = alphabet;

            for (int i = 0; i < int.Parse(comboBox1.Text); i++)
            {
                char temp = rotor_1[0];
                for (int j = 0; j < rotor_1.Count - 1; j++)
                {
                    rotor_1[j] = rotor_1[j + 1];
                }
                rotor_1[rotor_1.Count - 1] = temp;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<char> rotor_1 = alphabet;

            for (int i = 0; i < int.Parse(comboBox1.Text); i++)
            {
                char temp = rotor_1[0];
                for (int j = 0; j < rotor_1.Count - 1; j++)
                {
                    rotor_1[j] = rotor_1[j + 1];
                }
                rotor_1[rotor_1.Count - 1] = temp;
            }
        }
    }
}
