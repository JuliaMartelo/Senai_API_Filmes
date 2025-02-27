using System.Linq.Expressions;
using api_filmes_senai.Context;
using api_filmes_senai.Controllers;
using api_filmes_senai.Domains;
using api_filmes_senai.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api_filmes_senai.Repositories
{

    /// <summary>
    /// Classe que vai implementar a interface IGeneroRepository
    /// ou seja vamos implementar os metodos(Toda a logica)
    /// </summary>
    public class GeneroRepository : IGeneroRepository
    {
        /// <summary>
        /// Variavel privada 
        /// </summary>

        private readonly Filme_Context _context;

        /// <summary>
        /// Construtor do Repositorio
        /// Aqui, toda vez que um costrutor for chamado,
        /// os dados do contexto estarao disponiveis 
        /// </summary>
        /// <param name="contexto"></param>

        public GeneroRepository(Filme_Context contexto)
        { 
           _context = contexto;
        }
        public void Atualizar(Guid id, Genero genero)
        {
            try
            {
                Genero generoBuscado = _context.Genero.Find(id)!;

                if (generoBuscado != null)
                {
                    generoBuscado.Nome = genero.Nome;
                }


                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public Genero BuscarPorId(Guid id)
        {
            try
            {
                Genero generoBuscado = _context.Genero.Find(id)!;

                return generoBuscado;
            }
            catch (Exception)
            {
                throw;
            }

            throw new NotImplementedException();
        }

        public void Cadastrar(Genero novoGenero)
        {
            try
            {
                _context.Genero.Add(novoGenero);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }

        }

        

  

        public List<Genero> Listar()
        {
            try
            {
                List<Genero> ListaGeneros = _context.Genero.ToList();
                return ListaGeneros;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Deletar(Guid id)
        {
            try
            {
                Genero generoBuscado = _context.Genero.Find(id)!;

                if (generoBuscado != null)
                {
                    _context.Genero.Remove(generoBuscado);
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

      

    }
}
