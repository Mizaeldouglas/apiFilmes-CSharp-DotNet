using System.ComponentModel.DataAnnotations;

namespace apiFilmes.Models;

public class Filme
{
    [Required(ErrorMessage = "O Titulo do Filme é Obrigatório")]
    public string? Titulo {get; set;}
    
    [Required(ErrorMessage = "O Genero do Filme é Obrigatório")]
    public string? Genero { get; set; }

    [Required(ErrorMessage = "O Duracao do Filme é Obrigatório")]
    [Range(70,600, ErrorMessage ="A Duração deve ser entre 70 a 600 Minutos")]
    public int Duracao { get; set; }
    
    
}