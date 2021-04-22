using System;
using System.Collections.Generic;
using System.Linq;
using TestIntern;

namespace TestIntern
{
    class Program
    {
        static void Main(string[] args)
        {
            var personList = new List<Persoana>()
                {
                new Persoana{Nume = "Ada", Prenume = "Albertina", Inaltimea = 150.5, Masa = 55, Varsta = 22, Salariu = 200},
                new Persoana{Nume = "Beatrice", Prenume = "Amelia", Inaltimea = 155.5, Masa = 75, Varsta = 23, Salariu = 500},
                new Persoana{Nume = "Camelia", Prenume = "Molovitsa", Inaltimea = 171.5, Masa = 45, Varsta = 23, Salariu = 100},
                new Persoana{Nume = "Casandra", Prenume = "Romana", Inaltimea = 172.5, Masa = 85, Varsta = 13, Salariu = 200},
                new Persoana{Nume = "Daciana", Prenume = "Condrea", Inaltimea = 173.5, Masa = 55, Varsta = 25, Salariu = 300},
                new Persoana{Nume = "Dorna", Prenume = "Marina", Inaltimea = 160.5, Masa = 25, Varsta = 28, Salariu = 400},
                new Persoana{Nume = "Lilianca", Prenume = "Misha", Inaltimea = 185.5, Masa = 35, Varsta = 29, Salariu = 600},
                new Persoana{Nume = "Dor", Prenume = "Madina", Inaltimea = 140.5, Masa = 65, Varsta = 21, Salariu = 700},
                new Persoana{Nume = "Doinasca", Prenume = "Malvina", Inaltimea = 175.5, Masa = 55, Varsta = 24, Salariu = 800},
                new Persoana{Nume = "Alionascu", Prenume = "Dina", Inaltimea = 160.5, Masa = 95, Varsta = 23, Salariu = 900},
                new Persoana{Nume = "Marinascu", Prenume = "Ira", Inaltimea = 140.5, Masa = 175, Varsta = 20, Salariu = 650},
                new Persoana{Nume = "Ivleeva", Prenume = "Anastasia", Inaltimea = 155.5, Masa = 75, Varsta = 21, Salariu = 1500},
                new Persoana{Nume = "Zaitseva", Prenume = "Olia", Inaltimea = 166.5, Masa = 55, Varsta = 53, Salariu = 2500},
                new Persoana{Nume = "Pushkina", Prenume = "Sasha", Inaltimea = 152.5, Masa = 75, Varsta = 123, Salariu = 520},
                new Persoana{Nume = "Sitnic", Prenume = "Sergiu", Inaltimea = 170.5, Masa = 45, Varsta = 56, Salariu = 5000},
                new Persoana{Nume = "Popescu", Prenume = "Mihai", Inaltimea = 170.5, Masa = 76, Varsta = 33, Salariu = 3500},
                new Persoana{Nume = "Miscu", Prenume = "Liliana", Inaltimea = 162.5, Masa = 76, Varsta = 40, Salariu = 900},
                new Persoana{Nume = "Hubencu", Prenume = "Andrian", Inaltimea = 186.5, Masa = 56, Varsta = 23, Salariu = 5500},
                new Persoana{Nume = "Pogor", Prenume = "Cleopatra", Inaltimea = 166.5, Masa = 56, Varsta = 20, Salariu = 4500},
                new Persoana{Nume = "Sireaev", Prenume = "Vladislav", Inaltimea = 178.5, Masa = 52, Varsta = 25, Salariu = 5500},
                new Persoana{Nume = "Ghijitchi", Prenume = "Tatiana", Inaltimea = 166.5, Masa = 203, Varsta = 25, Salariu = 3500},
                new Persoana{Nume = "Gordelenco", Prenume = "Cristian", Inaltimea = 170.5, Masa = 89, Varsta = 19, Salariu = 3500},
                new Persoana{Nume = "Goncear", Prenume = "Cristian", Inaltimea = 180.5, Masa = 98, Varsta = 20, Salariu = 3500},
                new Persoana{Nume = "Rogac", Prenume = "Dumitru", Inaltimea = 190.5, Masa = 78, Varsta = 24, Salariu = 3500},
                new Persoana{Nume = "Markova", Prenume = "Irena", Inaltimea = 140.5, Masa = 69, Varsta = 78, Salariu = 1500},
                new Persoana{Nume = "Lopez", Prenume = "Jenifer", Inaltimea = 150.5, Masa = 65, Varsta = 50, Salariu = 2500},
                new Persoana{Nume = "Gomez", Prenume = "Selena", Inaltimea = 166.5, Masa = 62, Varsta = 26, Salariu = 3500},
                new Persoana{Nume = "Dumitrascu", Prenume = "Matius", Inaltimea = 135.5, Masa = 55, Varsta = 43, Salariu = 4500},
                new Persoana{Nume = "Ursu", Prenume = "Liliana", Inaltimea = 158.5, Masa = 93, Varsta = 25, Salariu = 5500},
                new Persoana{Nume = "Rusu", Prenume = "Andrei", Inaltimea = 190.5, Masa = 321, Varsta = 33, Salariu = 6500},
                new Persoana{Nume = "Dontu", Prenume = "Ilana", Inaltimea = 171.5, Masa = 123, Varsta = 23, Salariu = 500},
                };

            var person1 = new Persoana {
                Nume = "Dontu",
                Prenume = "Ilana",
                Inaltimea = 171.5,
                Masa = 123,
                Varsta = 23,
                Salariu = 500
            };


            var first = personList.First(x => x.Nume == "Ghijitchi");
            Console.WriteLine("First = " + first.Nume + " " + first.Prenume);
            var second = personList.FirstOrDefault(x => x.Nume == "Cleopatra");
            Console.WriteLine("FirstorDefault = " + second);
            var third = personList.Any(x => x.Salariu >= 3500);
            Console.WriteLine("Any = " + third);
            var fourth = personList.Where(x => x.Masa > 200);
            foreach (var person in fourth)
            {
                Console.WriteLine($"where Nume {person.Nume} Prenume {person.Prenume}");
            }
            var fith = personList.All(x => x.Inaltimea == 166.5);
            Console.WriteLine("All = " + fith);
            var sixth = personList.Contains(person1);
            Console.WriteLine("Contains = " + sixth);
            var seventh = personList.Select(x => new Persoana { Nume = x.Nume });

            foreach (var person in seventh) {
                Console.WriteLine($"seventh select Nume {person.Nume} Prenume {person.Prenume}");
            }
            var eighth = personList.Select(x => new { x.Nume, x.Varsta, x.Salariu });

            foreach (var person3 in eighth) {
                Console.WriteLine($"eight select Varsta {person3.Varsta} Salariu {person3.Salariu}");
            }
            var nineth = personList.OrderBy(x => x.Nume).ThenBy(x => x.Prenume);

            foreach (var person4 in nineth) {
                Console.WriteLine($"ninenth select Inaltimea {person4.Inaltimea} Masa {person4.Salariu}");

            }

            var userList = new List<Persoana>()
                {
                new Persoana{Nume = "Ada", Prenume = "Albertina", Inaltimea = 150.5, Masa = 55, Varsta = 22, Salariu = 200},
                new Persoana{Nume = "B eatrice", Prenume = "Amelia", Inaltimea = 155.5, Masa = 75, Varsta = 23, Salariu = 500},
                new Persoana{Nume = "Camelia", Prenume = "Molovitsa", Inaltimea = 171.5, Masa = 45, Varsta = 23, Salariu = 100},
            };
            var personx = new Persoana { Nume = "bol", Prenume = "bola", Inaltimea = 55.2, Masa = 55, Varsta = 22, Salariu = 200 };
            userList.Add(personx);

            Console.WriteLine(userList[3].Nume);

            var persony = userList.Remove(personx);
            Console.WriteLine(persony);

            var userList1 = new List<Persoana>()
                {
                new Persoana{Nume = "Ada", Prenume = "Albertina", Inaltimea = 150.5, Masa = 55, Varsta = 22, Salariu = 200},
                new Persoana{Nume = "B eatrice", Prenume = "Amelia", Inaltimea = 155.5, Masa = 75, Varsta = 23, Salariu = 500},
                new Persoana{Nume = "Camelia", Prenume = "Molovitsa", Inaltimea = 171.5, Masa = 45, Varsta = 23, Salariu = 100},
            };
            userList.AddRange(userList1);

            foreach (var nameX in userList)
            {
                Console.WriteLine($"Varsta {nameX.Varsta} Salariu {nameX.Salariu}");

            }
            Console.WriteLine("before " + userList.Count);
            userList.RemoveRange(0, 1);
            Console.WriteLine("after " + userList.Count);

            var numberList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var minNumber = numberList.Min();
            var maxNumber = numberList.Max();
            var average = numberList.Average();
            var sum = numberList.Sum();
            Console.WriteLine("min " + minNumber);
            Console.WriteLine("max " + maxNumber);
            Console.WriteLine("average " + average);
            Console.WriteLine("sum " + sum);
        }
    }
}
