using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaDeTarefas.integracao.Interfaces;
using SistemaDeTarefas.integracao.Response;

namespace SistemaDeTarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CepController : ControllerBase
    {
        private readonly IViaCepIntegracao _viaCepIntegracao;
        public CepController(IViaCepIntegracao viaCepIntegracao)
        {
            _viaCepIntegracao = viaCepIntegracao;
        }
        [HttpGet("{cep}")]
        public async Task<ActionResult<ViaCepResponse>> ListarDadosEndereco(string cep)
        {
            var respondeData = await _viaCepIntegracao.ObterDadosViaCep(cep);
            if(respondeData == null)
            {
                return BadRequest("Cep não encontrado!");
            }
            return Ok(respondeData);
        }
    }
}
