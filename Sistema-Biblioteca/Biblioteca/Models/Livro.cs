namespace Biblioteca.Models;

public class Livro {

    public string? Id { get; set; }
    public string? Nome { get; set; }
    public string? Descricao { get; set; }
    public DateTime? DataPublicacao { get; set; }
    public string? AutorId { get; set; }   
    public Autor? Autor{ get; set; }
    public string? GeneroId { get; set; }
    public Genero? Genero { get; set;}
    public bool EstaEmprestado { get; set; }
    public bool EstaReservado { get; set; }
    
    public Livro() {
        Id = Guid.NewGuid().ToString();
    }

    public Livro(string nome, DateTime dataPublicacao) {
        Id = Guid.NewGuid().ToString();
        Nome = nome;
        DataPublicacao = dataPublicacao;
    }

}