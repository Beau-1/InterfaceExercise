using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var Inventory = new List<IVehicle>();

            Car Spectra = new Car();
            Spectra.Seats = "4";
            Spectra.EnginSize = "2L";
            Spectra.Logo = "KIA";
            Spectra.SportPacage = "1";
            Spectra.Slogan = "It's a Kia";
            Spectra.Has4x4 = "No";
            Spectra.Coupe = "No";
            Spectra.CargoSpace = "None";
            Inventory.Add(Spectra);

            Truck Silverado = new Truck();
            Silverado.Seats= "4";
            Silverado.SportPacage= "1";
            Silverado.Logo = "Bowtie";
            Silverado.Doors = "4";
            Silverado.Has4x4 = "No";
            Silverado.CargoSpace= "None";
            Silverado.Slogan = "Like a rock";
            Silverado.BedSize = "Lg";
            Inventory.Add(Silverado);

            SUV Avalanch = new SUV();
            Avalanch.Seats = "4";
            Avalanch.SportPacage= "1";
            Avalanch.Doors = "4";
            Avalanch.Seats= "4";
            Avalanch.Logo = "Bowtie";
            Avalanch.EnginSize = "5L";
            Avalanch.Has4x4 = "No";
            Avalanch.Slogan= "Like a rock";
            Inventory.Add(Avalanch);

            Console.WriteLine("-+-----+------+-----+-----+-----+----+----+-");

            Console.WriteLine($"This vehicle is a Chevy Avalanch and it has {Avalanch.Seats} seats, " +
                $"comes with the Sport Package and {Avalanch.Doors} doors. Its engine size is {Avalanch.EnginSize}." +
                $" When all these features combined it's clear to see how it earned its slogan, {Avalanch.Slogan}");

            Console.WriteLine("-+-----+------+-----+-----+-----+----+----+-");

            Console.WriteLine($"This vehicle is a Kia Spectra and it has {Spectra.Seats} seats, " +
                $"comes with the Sport Package and {Spectra.Doors} doors. Its engine size is {Spectra.EnginSize}." +
                $" When all these features combined it's clear to see how it earned its slogan, {Spectra.Slogan}");

            Console.WriteLine("-+-----+------+-----+-----+-----+----+----+-");

            Console.WriteLine($"This vehicle is a Chevy Silverado and it has {Silverado.Seats} seats, " +
                $"comes with the Sport Package and {Silverado.Doors} doors. Its engine size is {Silverado.EnginSize}." +
                $" When all these features combined it's clear to see how it earned its slogan, {Silverado.Slogan}");

            Console.WriteLine("-+-----+------+-----+-----+-----+----+----+-");

            Console.Read();

            //Done-TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Done-Create 2 Interfaces called IVehicle & ICompany

            //Done-Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Done-Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Done-Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //Done-In each of your car, truck, and suv classes

            /*Done-Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Done-Now, create objects of your 3 classes and give their members values;
            //Done-Creatively display and organize their values
        }
    }
}
