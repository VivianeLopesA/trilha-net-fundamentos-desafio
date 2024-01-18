using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Utilitarios
{
 
    public static class Ferramentas

    {
        public static bool EhVazio(string texto){
            if(texto != string.Empty)
            {
                return false;
            }else{
                return true;
            }
        }

        public static string RetiraVazioString(string texto){
            return texto.Replace(" ", "");
        }

         
    }
    
}