using COMP123_S2019_FinalTestA.Objects;
using COMP123_S2019_FinalTestA.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_FinalTestA
{
    static class Program
    {
        
        public static MasterForm heroGenerator;
        public static Character character;
        public static Hero hero;
        public static Power power;
        public static AboutForm aboutform;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            character = new Character();
            hero = new Hero();
            power = new Power();
            heroGenerator= new MasterForm();
            aboutform = new AboutForm();
            Application.Run(heroGenerator);
        }
    }
}
