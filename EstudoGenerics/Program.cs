using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa
            {
                Id = 1,
                Nome = "Haline"
            };

            Animal animal = new Animal
            {
                Id = 1,
                Especie = "Cachorro"
            };

            RepositorioPessoa repositorioPessoa = new RepositorioPessoa();
            RepositorioAnimal repositorioAnimal = new RepositorioAnimal();

            repositorioPessoa.Insert(pessoa);
            repositorioAnimal.Insert(animal);

            foreach (Pessoa p in repositorioPessoa.Get())
            {
                Console.WriteLine("Nome da pessoa: " + p.Nome);
            }
            foreach (Animal a in repositorioAnimal.Get())
            {
                Console.WriteLine("Especie do animal: " + a.Especie);
            }
            Console.ReadKey();
        }
    }
}
