using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineIT
{
    public class Piece : Composant
    {
        string reference;

        public Piece(string _numero) :base()
        {
            reference = _numero;
        }

        public string Reference { get => reference; set => reference = value; }
    }
}
