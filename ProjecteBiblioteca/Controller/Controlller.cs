using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View;
using System.Windows.Forms;


namespace Controller {
    public class Controller {
        Form1 f1 = new Form1();
        BibliotecaEntities2 db = new BibliotecaEntities2();


        public void init() {
            //contactesPopulate();
            initListeners();
            run();

        }

        public void initListeners() {

        }

        public void run() {
            Application.Run(f1);
        }
    }
}
