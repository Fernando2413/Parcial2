using System.Security.Principal;

namespace Parcial2.Models
{
    public class libro_autor
    {
        public int id_Libro_Autor { get; set; }
        public int id_Libro { get; set; }
        public int id_Autor { get; set; }
    }
}
