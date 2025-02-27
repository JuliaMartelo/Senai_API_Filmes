using api_filmes_senai.Domains;

namespace api_filmes_senai.Interfaces
{
    public interface IFilmeRepository
    {

        void Cadastrar(Filme novoFilme);

        List<Filme> Listar { get; }

        void Atualizar (Guid id, Filme filme);

        void deletar (Guid id);

        Filme BuscarPorId (Guid id);

        //Listar os filmes pelo seu genero - filtro
        List<Filme> ListarPorGenero (Guid idGenero);


    }
}
