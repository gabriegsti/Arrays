using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Model
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }

        public override bool Equals(object obj)
        {
            Cliente outroCliente = obj as Cliente;

            if(outroCliente == null)
            {
                return false;   
            }

            return outroCliente.CPF == this.CPF ;
        }
        public override int GetHashCode()
        {
            return 0;
        }
    }
}
