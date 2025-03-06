using System.Linq.Expressions;
using api_filmes_senai.Context;
using api_filmes_senai.Domains;
using api_filmes_senai.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace api_filmes_senai.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {
        private readonly Filme_Context _context;
        public FilmeRepository(Filme_Context context)
        {
            _context = context;
        }

       

        public void Atualizar(Guid id, Filme filme)
        {
            try
            {
                Filme filmeBuscado = _context.Filme.Find(id);

                if (filmeBuscado != null)
                {
                    filmeBuscado.Titulo = filme.Titulo;

                    filmeBuscado.IdGenero = filme.IdGenero;
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Filme BuscarPorId(Guid id)
        {
            try
            {
                Filme filmeBuscado = _context.Filme.Find(id)!;

                return filmeBuscado;
            }
            catch (Exception)

            {
                throw;
            }
        }


        public void Cadastrar(Filme novoFilme)
        {
            try
            {
                _context.Filme.Add(novoFilme);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void deletar(Guid id)
        {
            try
            {
                Filme filmeBuscado = _context.Filme.Find(id);
                if (filmeBuscado != null)
                {
                    _context.SaveChanges();
                }

            }
            catch (Exception)
            {
                throw;
            }
        }


        public List<Filme> Listar()
        {
            try
            {
                List<Filme> listaDeFilmes = _context.Filme.ToList();

                return listaDeFilmes;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Filme> ListarPorGenero(Guid idGenero)
        {
            return _context.Filme.Where(f => f.IdGenero == idGenero).ToList();
        }

       

    }
}
