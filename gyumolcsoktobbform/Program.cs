using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gyumolcsoktobbform
{
    internal static class Program
    {
        static public gyumolcsok_mod gyumolcsok_Mod = null;
        static public gyumolcsok_del gyumolcsok_Del = null;
        static public gyumolcsok_upd gyumolcsok_Upd = null;
        static public Gyumolcsok_nyit gyumolcsok_Nyit = null;
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            gyumolcsok_Del = new gyumolcsok_del();
            gyumolcsok_Mod=new gyumolcsok_mod();
            gyumolcsok_Nyit = new Gyumolcsok_nyit();
            gyumolcsok_Upd=new gyumolcsok_upd();
            Application.Run(gyumolcsok_Nyit);
        }
    }
}
