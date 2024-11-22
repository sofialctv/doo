using CalculatorSOLID.Services.Interfaces;

namespace CalculatorSOLID.Services
{
    public class DivisionOperation : IOperation
    {
        public double Execute(double value1, double value2)
        {
            if (value2 == 0)
                throw new ArgumentException("Cannot divide by zero");
            return value1 / value2;
        }
    }
}
