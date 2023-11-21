using System;
using apiFilmes.Models;
using Microsoft.AspNetCore.Mvc;

namespace apiFilmes.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>();
    private static int id = 1;

    [HttpPost]
    public IActionResult CreateMovie([FromBody] Filme filme)
    {
        filme.Id = id++;
        filmes.Add(filme);
        return CreatedAtAction(nameof(FindByIdMovie), new { id = filme.Id }, filme);
    }

    [HttpGet]
    public IEnumerable<Filme> GetAllMovie([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        return filmes.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult? FindByIdMovie(int id)
    {
        var filme = filmes.FirstOrDefault(filme => filme.Id == id);

        if (filme == null) return NotFound();
        return Ok(filme);
    }

}