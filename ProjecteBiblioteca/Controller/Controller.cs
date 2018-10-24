using Model;
using View;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class Controller
    {
        View.Menu menu = new View.Menu();
        BibliotecaEntities db = new BibliotecaEntities();


        public void init()
        {
            initListeners();
            run();
        }

        public void initListeners()
        {
                //hHola
        }

        public void run()
        {
            Application.Run(menu);
            //hello mama
            //Hail
        }

    }
}
