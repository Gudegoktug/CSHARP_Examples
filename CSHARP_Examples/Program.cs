using CSHARP_Examples.Dice_Game;
using CSHARP_Examples.For_Loop;
using CSHARP_Examples.If_Else;
using CSHARP_Examples.Switch_Case;
using CSHARP_Examples.Try_Catch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHARP_Examples
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Simple_Dice_Game());
        }
    }
}
