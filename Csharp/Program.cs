using Csharp;
using Interface;
using Enum;
internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa person = new Pessoa();

        person.Nome = "Miguel";
        person.Idade = 24;
        person.Estado = "SP";

        var person2 = new Pessoa();

        person2.Nome = "Giovanna";
        person2.Idade = 25;
        person2.Estado = "AM";

        Animal animal = new Animal();

        animal.Nome = "Tody";
        animal.Dono = "Giova";
        animal.Especie = "Cachorro";

        var pessoas = (Pessoas)0;
        Pessoas pessoas2 = Pessoas.Midorya;
        Pessoas pessoas3 = (Pessoas)4;

  

        
    }
}