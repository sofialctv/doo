using CalculatorSOLID.Services.Interfaces;
using CalculatorSOLID.View;

namespace CalculatorSOLID.Controllers
{
    public class MenuController
    {
        private readonly IOperationFactory _operationFactory;
        private readonly Menu _menu;

        public MenuController(IOperationFactory operationFactory, Menu menu)
        {
            _operationFactory = operationFactory;
            _menu = menu;
        }

        public void Run()
        {
            bool continueRunning = true;

            while (continueRunning)
            {

                try
                {
                    var operationType = _menu.GetOperation();

                    double value1 = _menu.GetNumber("Enter the first value: ");
                    double value2 = _menu.GetNumber("Enter the second value: ");

                    var operation = _operationFactory.GetOperation(operationType);

                    var result = operation.Execute(value1, value2);

                    _menu.DisplayResult(result);
                }

                catch (ArgumentException ex)
                {
                    _menu.DisplayError(ex.Message);
                }

                continueRunning = _menu.AskToContinue();
            }
        }
    }
}
