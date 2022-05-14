namespace PeliculasAPI.DTOs
{
    public class PeliculaDTO
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public bool EnCines { get; set; }
        public DateTime fechaEstreno { get; set; }
        public string Poster { get; set; }
    }
}
