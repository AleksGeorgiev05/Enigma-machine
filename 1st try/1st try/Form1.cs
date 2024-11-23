
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
            string letter = "A", new_letter;


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Alphabet(Label a)
        {
            string alphabet = "";
            for (int i = 0; i < 26; i++)
            {
                
                alphabet.Append((char)(i + 65));
            }
            a.Text = alphabet;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Alphabet(label5);
        }
    }
}
