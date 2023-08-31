public class BmiCalculator
{
    public double Height { get; set; }

    public double Weight { get; set; }

    public double Bmi
    {
        get
        {
            if (Height <= 0) return 0;
            return Weight / (Height * Height);
        }
    }
    public double Result
    {
        get { return Math.Round(Bmi,2); }
    }
}