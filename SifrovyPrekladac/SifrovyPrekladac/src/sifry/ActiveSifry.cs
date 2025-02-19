﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SifrovyPrekladac.src.sifry
{
    /// <summary>
    /// Enumerace představující seznam aktivních  šifer, kterými lze sifrovat, či dešifrovat v této verzi aplikace.
    /// </summary>
    public enum ActiveSifry
    {
        Morseova_Sifra,
        Caesarova_Sifra,
        Petronilka,
        Mezerova_Sifra,
        Klavesnicova_Sifra,
        Telefonni_Sifra,
        Numericka_Sifra,
        Reverzni_Sifra,
        Obracena_ABC_Sifra,
        Prohazena_Sifra,
        Moje_Sifra
    }
}
