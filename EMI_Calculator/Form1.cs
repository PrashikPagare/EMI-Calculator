namespace EMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double P, R, N;
            double MonthlyEMI, YearlyEMI;

            try
            {
                // Parse inputs as double for more precise calculations
                P = double.Parse(Principle.Text);
                R = double.Parse(Rate.Text) / 12 / 100; // Convert annual interest rate to monthly decimal rate
                N = double.Parse(Tenure.Text);    // Convert years to months
                MonthlyEMI = (P * R * Math.Pow(1 + R, N)) / (Math.Pow(1 + R, N) - 1);
                YearlyEMI = MonthlyEMI * 12;
                // Display the results
                Output1.Text = $"{MonthlyEMI:F0}";
            }
            catch (Exception ex)
            {
                Output1.Text = $"An Error Occured: {ex.Message}";
            }
        }

    }
}
