using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace PTE_1._0.Suporte
{
    public class JanelasWindows
    {
        [TestMethod]

        public static void selecionarArquivoAnexo_PTE()
        {
            String caminho = $"C:\\Suporte\\AddFilesProposta.exe";
            Process executavel = System.Diagnostics.Process.Start(caminho);
            executavel.WaitForExit();
        }

        public static void selecionarPlanilhaImportacao()
        {
            String caminho = $"C:\\Suporte\\ImportBeneficiarios.exe";
            Process executavel = System.Diagnostics.Process.Start(caminho);
            executavel.WaitForExit();
        }
    }
}
