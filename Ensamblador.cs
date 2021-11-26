using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krotoz
{
    class Ensamblador
    {
        List<Lexema> posfijo;
        List<Var> variables;
        private string asm;
        public string ASM { get { return asm; } }
        public Ensamblador(List<Lexema> posfijo, List<Var> variables)
        {
            this.posfijo = posfijo;
            this.variables = variables;
            var header = ".model small\n.stack\n";
            asm = header + Data();
        }
        private string Data()
        {
            var data = ".data\n";
            foreach (var _var in variables)
            {
                switch (_var.tipo)
                {
                    case 114: //int
                        data += $"{_var.nombre} DW {_var.valor}\n";
                        break;
                    case 115: //dec
                        data += $"{_var.nombre} DQ {_var.valor}\n";
                        break;
                    case 116: //str
                        var val = ((string)_var.valor);
                        data += $"{_var.nombre} DW {val.Insert(val.Length - 1, "$")}\n";
                        break;
                    default:
                        break;
                }
            }

           // bool proc = false;
            var procs = variables.Where(e => e.tipo == 121);
            foreach (var proc in procs)
            {
                var inProc = posfijo.FindIndex(e => e.palabra == proc.nombre) + 1;
                var outProc = posfijo.FindLastIndex(e => e.palabra.Contains(proc.nombre) && e.token == -121) - 1;
                data += $"{proc.nombre} PROC\n";
                posfijoToASM(posfijo.GetRange(inProc, outProc - inProc));
                data += $"ENDPROC {proc.nombre}\n";
            }
            
            return data;
        }

        private string posfijoToASM(List<Lexema> posfijo)
        {
            string result = "";

            for (int i = 0; i < posfijo.Count; i++)
            {
                var lexema = posfijo[i];
                switch (lexema.token)
                {
                    case 1:
                        break;
                    default:
                        break;
                }
            }

            return result;
        }

        private string Code()
        {
            var code = ".code\n";
            foreach (var lex in posfijo)
            {
                switch (lex.token)
                {
                    default:
                        break;
                }
            }

            return code;
        } 

    }
}
