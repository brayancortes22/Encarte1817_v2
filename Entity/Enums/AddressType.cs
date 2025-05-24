using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Enums
{
    /// <summary>
    /// Enum para tipos de vías o direcciones
    /// </summary>
    public enum AddressType
    {
        [Description("Calle")]
        Street = 1,

        [Description("Carrera")]
        Avenue = 2,

        [Description("Transversal")]
        Transversal = 3,

        [Description("Diagonal")]
        Diagonal = 4,

        [Description("Circular")]
        Circular = 5,

        [Description("Autopista")]
        Highway = 6,

        [Description("Avenida")]
        Boulevard = 7,

        [Description("Km")]
        Kilometer = 8,

        [Description("Variante")]
        Variant = 9,

        [Description("Via")]
        Road = 10,

        [Description("Sector")]
        Sector = 11,

        [Description("Barrio")]
        Neighborhood = 12,

        [Description("Conjunto")]
        Complex = 13,

        [Description("Edificio")]
        Building = 14,

        [Description("Torre")]
        Tower = 15,

        [Description("Casa")]
        House = 16,

        [Description("Apartamento")]
        Apartment = 17,

        [Description("Local")]
        Local = 18,

        [Description("Oficina")]
        Office = 19,

        [Description("Bodega")]
        Warehouse = 20
    }
}