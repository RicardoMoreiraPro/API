using Refit;
using SistemaDeTarefas.integracao.Response;

namespace SistemaDeTarefas.integracao.Refit
{
    public interface IViaCepIntegracaoRefit
    {
        [Get("/ws/{cep}/json")]
        Task<ApiResponse<ViaCepResponse>> ObterDadosViaCep(string cep);
    }
}
