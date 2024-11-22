using CalculatorSOLID.Services.Interfaces;

namespace CalculatorSOLID.Services
{
    public class OperationFactory : IOperationFactory
    {
        public IOperation GetOperation(string operationType)
        {
            return operationType switch
            {
                "add" => new AdditionOperation(),
                "subtract" => new SubtractionOperation(),
                "multiply" => new MultiplicationOperation(),
                "divide" => new DivisionOperation(),
                _ => throw new ArgumentException("Invalid operation type")
            };
        }
    }
}