namespace CalculatorSOLID.Services.Interfaces
{
    public interface IOperationFactory
    {
        IOperation GetOperation(string operationType);
    }
}
