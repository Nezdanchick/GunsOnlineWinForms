using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunsOnlineWinForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            var obj = new Object2D();
            obj.Move(new Point(1, 1));

            Application.Exit();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Lobby());
        }
    }
}
