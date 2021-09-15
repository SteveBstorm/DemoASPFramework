using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoASPFramework.Models
{
    public static class ArticleStocke
    {
        public static List<Article> articles = new List<Article>()
        {
            new Article { Id = 1, Libelle = "Tomate", Description = "Fruit ou légume", Prix = 1},
            new Article { Id = 2, Libelle = "Iphone", Description = "Trop cher pour ce que c'est", Prix = 1234},
            new Article { Id = 3, Libelle = "Coca", Description = "Boisson sucrée", Prix = 2},
        };
    }
}