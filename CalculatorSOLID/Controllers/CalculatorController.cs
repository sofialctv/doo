using CalculatorSOLID.Models.DTOs;
using CalculatorSOLID.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorSOLID.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly IOperationFactory _operationFactory;

        // A factory aplicada via injeção de dependência
        public CalculatorController(IOperationFactory operationFactory)
        {
            _operationFactory = operationFactory;
        }

        // Endpoint para calcular a operação
        [HttpPost("calculate")]
        public ActionResult<CalculatorResponseDTO> Calculate([FromBody] CalculatorRequestDTO request)
        {
            try
            {
                // Sabemos qual a operação correta a partir da factory
                var operation = _operationFactory.GetOperation(request.Operation);

                // Execução da operação
                var result = operation.Execute(request.Value1, request.Value2);

                // Retorno do resultado
                return Ok(new CalculatorResponseDTO { Result = result });
            }
            catch (ArgumentException ex)
            {
                // Caso ocorra uma exceção (ex: operação inválida ou divisão por zero)
                return BadRequest(ex.Message);
            }
        }
    }
}
