namespace StreamsWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SubmitNumBtn_Click(object sender, EventArgs e)
        {
            if (MinNumsTB.Text != "" && MaxTB.Text != "")
            {
                int.TryParse(MinNumsTB.Text, out int min);
                int.TryParse(MaxTB.Text, out int max);
                Thread thread = new Thread(() => { PrintFor(min, max); });
                thread.Start();
            }
            else
            {
                Thread thread = new Thread(() => { PrintFor(); });
                thread.Start();
            }


            void PrintFor(int start = 0, int count = 50)
            {
                for (int i = start; i <= count; i++)
                {
                    richTextBox1.Text += $"{i} ";
                }
            }
        }

        private void Task2Btn_Click(object sender, EventArgs e)
        {
            int max;
            int min;
            double avg;
            List<int> nums = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < 10000; i++)
            {
                nums.Add(rand.Next(0, 9));
            }
            max = nums.Max();
            min = nums.Min();
            avg = nums.Average();
            Thread maxThread = new Thread(() => { richTextBox1.Text += $"max: {max}\n"; });
            maxThread.Start();
            Thread minThread = new Thread(() => { richTextBox1.Text += $"min: {min}\n"; });
            minThread.Start();
            Thread avgThread = new Thread(() => { richTextBox1.Text += $"avg: {avg} \n"; });
            avgThread.Start();
 
        }
    }
}