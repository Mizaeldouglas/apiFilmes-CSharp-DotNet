using apiFilmes.Models;
using Microsoft.AspNetCore.Mvc;

namespace apiFilmes.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>();

    [HttpPost]
    public void AdicionarFilme([FromBody] Filme filme)
    {

        if (string.IsNullOrEmpty(filme.Titulo))
        {
            filmes.Add(filme);
            Console.WriteLine(filme.Titulo);
            Console.WriteLine(filme.Duracao);
        }

    }

}