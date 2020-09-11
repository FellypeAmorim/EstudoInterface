using System;
using System.Collections.Generic;
using System.Text;

namespace PropostoArquivos.Entities
{
    class Vehicle
    {
        public string Model { get; set; }

        public Vehicle()
        {
        }

        public Vehicle(string model)
        {
            Model = model;
        }
    }
}
