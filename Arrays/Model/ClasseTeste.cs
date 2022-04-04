using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Model
{
    internal class ClasseTeste
    {
        public ClasseTeste()
        {
            ModificadoresTeste teste = new ModificadoresTeste();
            teste.MetodoPublico();
            teste.MetodoInterno();
            //teste.MetodoProtegido();
            //teste.MetodoPrivado();
        }
    }
    class ClasseDerivada : ModificadoresTeste
    {
        public ClasseDerivada()
        {
            MetodoProtegido();
        }
    }
    public class ModificadoresTeste
    {
        public void MetodoPublico()
        {
            //Visível fora da classe "ModificadoresTeste"
        }
        protected void MetodoProtegido()
        {
            //Visível apenas na classe "ModificadoresTeste" e derivados
        }
        private void MetodoPrivado()
        {
            //Visível apenas na classe "ModificadoresTeste"
        }

        internal void MetodoInterno()
        {
            // Visivel apenas para o projeto ByteBank.Modelos!
        }
       
    }
}
