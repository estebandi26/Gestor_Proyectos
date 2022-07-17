using System.ComponentModel.DataAnnotations;

namespace Gestor_Proyectos.API.Data.Entities
{
    public class Requerimiento
    {
        public int Id { get; set; }
        public DateTime Fecha_Reg { get; set; }
        //[Display(Name = "Nombre de la Iniciativa")]
        //[MaxLength(50, ErrorMessage ="El campo {0} no puede tener más de {1} carácteres")]
        //[Required(ErrorMessage ="El campo {0} es obligatorio")]
        public string Nombre_Iniciativa { get; set; }
        public string Detalle_Req { get; set; }
        public string Aplicativo { get; set; }
        public string Sustentac_Req { get; set; }
        public string Objetivo1 { get; set; }
        public string Objetivo2 { get; set; }
        public string Objetivo3 { get; set; }
        public string Indicador1 { get; set; }
        public string Indicador2 { get; set; }
        public string Indicador3 { get; set; }
        public string Eviden_Mejora { get; set; }
        public string Periodo_Ent { get; set; }
        public DateTime Fecha_Entrega { get; set; }
        public decimal Ppto_Aprox { get; set; }
        public decimal Ppto_Area { get; set; }



    }
}
