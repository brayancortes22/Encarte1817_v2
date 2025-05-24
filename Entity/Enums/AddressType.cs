using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Enums
{
    /// <summary>
    /// Enum para tipos de vías
    /// </summary>
    public enum StreetType
    {
        [Description("Calle")]
        Calle = 1,

        [Description("Carrera")]
        Carrera = 2,

        [Description("Transversal")]
        Transversal = 3,

        [Description("Diagonal")]
        Diagonal = 4,

        [Description("Circular")]
        Circular = 5,

        [Description("Autopista")]
        Autopista = 6,

        [Description("Avenida")]
        Avenida = 7,

        [Description("Km")]
        Km = 8,

        [Description("Variante")]
        Variante = 9,

        [Description("Vía")]
        Via = 10
    }

    /// <summary>
    /// Enum para letras adicionales (A, B, C, etc.)
    /// </summary>
    public enum StreetLetter
    {
        [Description("")]
        Ninguna = 0,
        [Description("A")]
        A = 1,
        [Description("B")]
        B = 2,
        [Description("C")]
        C = 3,
        [Description("D")]
        D = 4,
        [Description("E")]
        E = 5,
        [Description("F")]
        F = 6,
        [Description("G")]
        G = 7,
        [Description("H")]
        H = 8,
        [Description("I")]
        I = 9,
        [Description("J")]
        J = 10
    }

    /// <summary>
    /// Enum para tipos de unidad residencial/comercial
    /// </summary>
    public enum UnitType
    {
        [Description("")]
        Ninguno = 0,
        [Description("Apto")]
        Apartamento = 1,
        [Description("Casa")]
        Casa = 2,
        [Description("Local")]
        Local = 3,
        [Description("Oficina")]
        Oficina = 4,
        [Description("Bodega")]
        Bodega = 5,
        [Description("Torre")]
        Torre = 6,
        [Description("Bloque")]
        Bloque = 7,
        [Description("Edificio")]
        Edificio = 8,
        [Description("Conjunto")]
        Conjunto = 9,
        [Description("Urbanización")]
        Urbanizacion = 10,
        [Description("Sector")]
        Sector = 11
    }
}