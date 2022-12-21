using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
       public string Doors { get; set; }
       public string Seats { get; set; }
       public string EnginSize { get; set; }
       public string SportPacage { get; set; }

    }
}
