using System.Security.Principal;

namespace Parcial2.Models
{
    public class prestamo
    {
        public int id_Prestamo { get; set; }
        public DateTime fecha_Prestamo { get; set; }
        public DateTime fecha_Devolucion { get; set; }
        public bool Devuelto { get; set; }
        public int id_Usuario { get; set; }
        public int id_Libro { get; set; }
    }
}
