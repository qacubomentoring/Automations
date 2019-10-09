using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTE_1._0.Suporte
{
    class DataHora
    {
        public static String dataEhoraSistema()
        {
            String dataAtual = DateTime.Now.ToString("dd/MM/yyyy");
            String horaAtual = DateTime.Now.ToString("HH:mm:ss");
            String datahora = dataAtual.Replace("/", "") + "_" + horaAtual.Replace(":", "");

            return datahora;
        }
            
    }
}
