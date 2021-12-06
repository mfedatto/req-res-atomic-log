namespace MFedatto.ReqRes.LogMonolitico.Api.Entities
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string? Documento { get; set; }
        public TipoDocumento? TipoDocumento { get; set; }
        public DateTime DataNascimento { get; set; }
        public Genero Genero { get; set; } = Genero.NaoInformado;

        public Pessoa(string nome)
        {
            Nome = nome;
        }
    }
}
