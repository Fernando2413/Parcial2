namespace Parcial2.Models
{
    public class libro
    {
        public int id_Libro { get; set; }
        public string titulo { get; set; }
        public string editorial { get; set; }
        public string area { get; set; }
        public string cover_Url { get; set; }
        public string digital_Url { get; set; }
        public bool disponible_Fisico { get; set; }
    }
}
