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
    
    public partial class OPE_DETALLE_GUIAUBICACION
    {
        public int ID_DOCUMENTO { get; set; }
        public int ID_PRODUCTO { get; set; }
        public string LOTE { get; set; }
        public decimal CANTIDAD { get; set; }
        public string CODIGO_UNIDAD { get; set; }
        public System.DateTime FECHA_ENVASADO { get; set; }
        public System.DateTime FECHA_VENCIMIENTO { get; set; }
        public int MESES { get; set; }
        public int SECUENCIA { get; set; }
        public int SECUENCIA_DOC { get; set; }
        public string CODIGO_SUCURSAL { get; set; }
        public string SERIE { get; set; }
        public string SERIE_GEN { get; set; }
        public string CODIGO_ZONA { get; set; }
        public string FILA { get; set; }
        public string COLUMNA { get; set; }
    }
}
