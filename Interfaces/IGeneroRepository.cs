using api_filmes_senai.Controllers;
using api_filmes_senai.Domains;

namespace api_filmes_senai.Interfaces
{
    /// <summary>
    /// Interface para Genero : Contrato
    /// Toda classe que herdar(implementar) essa interface, devera implementar
    /// todos os metodos definidos aqui dentro
    /// </summary>
    public interface IGeneroRepository
    {
        //CRUD: Metodos
        // C= Create
        // R= Read
        // U= Update
        // D= Delete

        // Tipo de retorno NomeDoMetodo(Argumentos)


        void Cadastrar(Genero novoGenero);

        List<Genero> Listar();
        void Atualizar(Guid id, Genero genero);

        void Deletar (Guid id);

        Genero BuscarPorId(Guid id);
    
    }
}
