using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public string Coupe { get; set; }
        public string Electric { get; set; }
        public string CargoSpace { get; set; }
        public string Has4x4 { get; set; }
        public string Doors { get; set; }
        public string Seats { get; set; }
        public string EnginSize { get; set; }
        public string SportPacage { get; set; }
        public string Logo { get; set; }
        public string Slogan { get; set; }
    }
}
