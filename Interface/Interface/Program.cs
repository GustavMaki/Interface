using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. List | 2. Search Brand | 3.Add");
            Repository repo = new CarsForSale();
            var Choice = Console.ReadLine();


            if(Choice == "1")
            {
                repo.ListCars();
            }
            if (Choice == "2")
            {
                Console.WriteLine("1. Brand Name: ");
                var SearchName = Console.ReadLine();
                repo.SearchForCar(SearchName);
            }
            if (Choice == "3")
            {
                Console.WriteLine("Car NAME and MODEL:");
                var NewCar = Console.ReadLine();
                repo.AddCar(NewCar);
            }
            Console.ReadLine();
        }
    }

    interface Repository
    {
        void ListCars();

        void SearchForCar(string Search);

        void AddCar(string NewCar);

    }

    class CarsForSale : Repository
    {
        string[] car = new string[] {"Volvo V70", "Volvo V60", "Audi R8", "Audi R6", "Nissan Micra", "Opel Alpha", "Corvette Stingray"};
        int i;

        public void AddCar(string NewCar)
        {
            Console.WriteLine("New car added: " + (car.Length+1) + ". " + NewCar);
            
        }

        public void SearchForCar(string Search)
        {
            if (Array.Find(car, x => x.StartsWith(Search)) != null)
            {

                for (i = 0; i < car.Length; i++)
                {
                    if (car[i].StartsWith(Search))
                    {
                        Console.WriteLine((1+1) +". "+ car[i]);
                    }
                    else { }
                }
            }
            else
            {
                Console.WriteLine("No results matching search.");
            }
            
        }

        public void ListCars()
        {
            for(i = 0; i < car.Length; i++)
            {
                Console.WriteLine((i+1) + ". " + car[i]);
            }
        }
    }

    class Car
    {
        
    }
}
