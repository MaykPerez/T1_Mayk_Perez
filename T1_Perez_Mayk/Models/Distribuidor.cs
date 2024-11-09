using System.ComponentModel.DataAnnotations;

namespace T1_Perez_Mayk.Models
{
    public class Distribuidor
    {

        [Key]
        public int Id { get; set; }
        public string NombreDistribuidor { get; set; }
        public string RazonSocial { get; set; }
        public string Telefono { get; set; }
        public string AnioInicioOperacion { get; set; }
        public string Contacto { get; set; }

    }
}
