using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krotoz
{
    class Lexema
    {
        public string palabra { get; set; }
        public int token { get; set; }

        public bool isReserved()
        {
            return (token >= 100 && token < 103) || (token >= 106 && token < 110) || (token >= 112 && token < 114) || token == 123;
        }

        public bool isOperator()
        {

            return (token >= 54 && token <= 65) || (token >= 103 && token <= 105);
        }

        public bool isOperand()
        {
            return (token >= 50 && token <= 53) || token == 72;
        }

        public bool isCicle()
        {
            return (token == 100 || token == 106 || token == 112 || token == 113);
        }
    }
}
