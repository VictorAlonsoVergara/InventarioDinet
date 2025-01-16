using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace InventarioDinet.Models
{
    public class Inventory
    {
        [Display(Name = "Código de Compañía")]
        public string COD_CIA { get; set; }

        [Display(Name = "Compañía de Venta")]
        public string COMPANIA_VENTA_3 { get; set; }

        [Display(Name = "Almacén de Venta")]
        public string ALMACEN_VENTA { get; set; }

        [Display(Name = "Tipo de Movimiento")]
        public string TIPO_MOVIMIENTO { get; set; }

        [Display(Name = "Tipo de Documento")]
        public string TIPO_DOCUMENTO { get; set; }

        [Display(Name = "Número de Documento")]
        public string NRO_DOCUMENTO { get; set; }

        [Display(Name = "Código de Item")]
        public string COD_ITEM_2 { get; set; }

        [Display(Name = "Proveedor")]
        public string PROVEEDOR { get; set; }

        [Display(Name = "Almacén de Destino")]
        public string ALMACEN_DESTINO { get; set; }

        [Display(Name = "Cantidad")]
        public int? CANTIDAD { get; set; }

        [Display(Name = "Documento de Referencia 1")]
        public string DOC_REF_1 { get; set; }

        [Display(Name = "Documento de Referencia 2")]
        public string DOC_REF_2 { get; set; }

        [Display(Name = "Documento de Referencia 3")]
        public string DOC_REF_3 { get; set; }

        [Display(Name = "Documento de Referencia 4")]
        public string DOC_REF_4 { get; set; }

        [Display(Name = "Documento de Referencia 5")]
        public string DOC_REF_5 { get; set; }

        [Display(Name = "Fecha de Transacción")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.DateTime)]
        public DateTime? FECHA_TRANSACCION { get; set; }
    }
}