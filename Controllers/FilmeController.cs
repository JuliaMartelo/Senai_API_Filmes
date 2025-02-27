using api_filmes_senai.Domains;
using api_filmes_senai.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api_filmes_senai.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class FilmeController : ControllerBase
    {
        private readonly IFilmeRepository _filmeRepository;

        public FilmeController(IFilmeRepository filmeRepository)
        {
            _filmeRepository = filmeRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {

            try
            {
                List<Filme> listaDeFilme = _filmeRepository.Listar;

                return Ok(listaDeFilme);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
        [HttpPost]
        public IActionResult Post(Filme novoFilme)
        {
            try
            {
                _filmeRepository.Cadastrar(novoFilme);

                return Ok(novoFilme);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, Filme filme)
        {
            try
            {
                _filmeRepository.Atualizar(id, filme);

                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }



        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _filmeRepository.deletar(id);
                return NoContent();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("genero/{idGenero}")]
        public IActionResult ListarPorGenero(Guid idGenero)
        {
            var filmes = _filmeRepository.ListarPorGenero(idGenero);

            if (filmes == null || !filmes.Any())
            {
                return NotFound(new { mensagem = "Nenhum filme encontrado para este gênero." });
            }

            return Ok(filmes);
        }
    }

}

