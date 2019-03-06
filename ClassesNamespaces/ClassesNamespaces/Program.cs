using ClassesNamespaces.Legos;
using ClassesNamespaces.Legos.Heads;
using ClassesNamespaces.Legos.Legs;
using ClassesNamespaces.Legos.Torsos;
using System;

namespace ClassesNamespaces
{
    class Program
    {
        // string _myData = "this is just for me to use aka this is a FIELD";

       // public int Number { get; set; }
        //Number is the name of the property
        //this property can both be gotten and set by someone

        // public void DoTheThing()
        // {
           // Number = 1;
           // var x = Number;
        //}

        private static void Main(string[] args)
        // everything inside Main is a Method Signature
        // Method is a funciton inside of a class
        {
            // instanciating new string class
            //var x = new string('a', 1);
            Console.WriteLine("Hello World!");


            // var taffy = new Candy();
            //taffy.Flavor = "Banana";
            //taffy.Name = "Banana Saltwater Taffy";
            //taffy.Rating = 5;
            //taffy.Type = CandyType.Taffy;

            //var taffy = new Candy {
            //    Flavor = "Banana",
            //    Name = "Banana Saltwater Taffy",
            //    Rating = 5,
            //    Type = CandyType.Taffy,
            //};

            //var taffy = new Candy("Banana", "Banana Saltwater Taffy", CandyType.Taffy);

            //taffy.SetRating(1, "It is average");

            //Console.WriteLine(taffy.ToString());

            var myDogHead = new DogHead();
            myDogHead.Talk();

            var martinHead = new BaldHead();
            var astronaught = new AstronautHead();

            var fitTorso = new FitTorso(2, Sex.Male, Colors.Freckles);
            fitTorso.Crunch(12);

            var adamsLegs = new OrangeLegs(Length.Short);
            adamsLegs.Jump();

            var minifigure = new MiniFigure("Adam", astronaught, fitTorso, adamsLegs);

            minifigure.Greet();


            Console.ReadLine();
        }
    }
}
