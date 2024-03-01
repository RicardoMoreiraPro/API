using SistemaDeTarefas.integracao.Response;

namespace SistemaDeTarefas.integracao.Interfaces
{
    public interface IViaCepIntegracao
    {
        Task<ViaCepResponse> ObterDadosViaCep(string cep);
    }
}
