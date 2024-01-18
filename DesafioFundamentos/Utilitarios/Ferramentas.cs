using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Ferramentas
{
    public class Ferramentas
    {
        public bool EhVazio(string texto){
            if(texto != string.Empty)
            {
                return false;
            }else{
                return true;
            }
        }

        public string RetiraVazioString(string texto){
            return texto.Replace(" ", "");
        }

         
    }
}