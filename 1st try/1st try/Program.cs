namespace _1st_try
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            Form1.InitialiseAlphabet();

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}