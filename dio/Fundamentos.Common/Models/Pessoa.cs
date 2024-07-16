using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dio.Common.Models
{
    public class Pessoa
    {
        public string Name { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"olá !, meu nome é {Name}, e tenho {Idade} anos.");
        }
    }
}