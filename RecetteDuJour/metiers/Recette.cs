﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetteDuJour.metiers
{
    class Recette
    {
        int Id { get; set; }
        string Nom { get; set; }
        string Image { get; set; }
        string Categorie { get; set; }
        int NbPersonne { get; set; }
        string Ingredients { get; set; }
        string Preparation { get; set; }


        public Recette( string Nom, string Image, string Categorie, int NbPersonne,string Ingredients,string Preparation)
        {

                
        }

    }
}