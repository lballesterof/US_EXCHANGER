//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace US_EXCHANGER.ModelEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class RRHH_ASIGNACION_RECURSO
    {
        public decimal ID_ASIGNACION { get; set; }
        public decimal ID_PERSONA { get; set; }
        public decimal ID_PRODUCTO { get; set; }
        public decimal CANTIDAD { get; set; }
        public string MARCA { get; set; }
        public string MODELO { get; set; }
        public string SERIE { get; set; }
        public string REFERENCIA { get; set; }
        public string COMENTARIO { get; set; }
        public System.DateTime FECHA_ENTREGA { get; set; }
        public Nullable<System.DateTime> FECHA_DEVOLUCION { get; set; }
        public string USUARIO_CREACION { get; set; }
        public System.DateTime FECHA_CREACION { get; set; }
    }
}
