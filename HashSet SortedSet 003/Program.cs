using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HashSet_SortedSet_003.Entitides;

namespace HashSet_SortedSet_003
{
    internal class Program
    {
        static void Main(string[] args)
        {
           HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV",900.0));//ADICIONANDO PRIMEIRO PRODUTO
            a.Add(new Product("Notebook",1999.0));
            //criando outro conjunto do tipo point

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5,10));

            //criar um produto abaixo
            Product prod = new Product("Notebook", 1999.0);
            Console.WriteLine(a.Contains(prod));//endereço de memoria sera considerado pelo contains
            //referencias de memoria (objetos diferente)

            //ATENÇÃO FOI FEITO IMPLEMENTAÇÃO DO GETHASHcODE E Equals
            //basicamente sera feito um comparação, mesmo sendo um objeto diferente, o conteudo e igual( valores,atributos)
            Point p = new Point(5, 10);

            Console.WriteLine(b.Contains(p));//quando o tipo e struct , ele ira comparar por tipo conteudo e não referencia
        }
    }
}
