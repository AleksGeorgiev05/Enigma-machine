using System.Security.Cryptography;
namespace _1st_try
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        List<char> alphabet = new List<char>();
        
        public void ShowMessage(Label a)
        {
            //alphabet.Shuffle
            for (int i = 0; i < 26; i++)
            {

                alphabet.Add((char)(i + 65));
            }

            label5.Text = "";

            for (int i = 0; i < alphabet.Count; i++)
            {
                a.Text += alphabet[i];
            }
        }

        private List<char> Shuffle(List<char> list)
        {
            char[] shuffled_arr = new char[list.Count];
            Random rnd = new Random();
            
            for (int i = 0; i<list.Count; i++)
            {
                int a;
                do
                {
                    a = rnd.Next(list.Count);
                } while (shuffled_arr[a] == '0');
                shuffled_arr[a] = list[i];
            }
            
            return shuffled_arr.ToList();
        }
        private void PressedLetter(Button btn_pressed)
        {
            Random random = new Random();
            random.Next(25);
            //alphabet.Shuffle();
            //int a = int.
            //List<char> alphabet_rotor_1 = alphabet.
            //List<char> alphabet_rotor_2 = new List<char>();
            //List<char> alphabet_rotor_3 = new List<char>();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowMessage(label5);
            Shuffle(alphabet);
        }
    }
}
