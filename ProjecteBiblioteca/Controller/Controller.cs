using Model;
using View;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller {
    public class Controller {
        View.Menu menu = new View.Menu();
        ConfigDades cd = new ConfigDades();
        Calendari calendari = new Calendari();
        BibliotecaEntities db = new BibliotecaEntities();


        public void init() {
            initListeners();
            run();
        }

        public void initListeners() {
            menu.buttonCalendari.Click += obrirCalendari;
            cd.dgvAutors.SelectionChanged += autorSelectionChanged;

        }

        protected void obrirCalendari(object sender, EventArgs args) {
            menu.Hide();
            calendari.ShowDialog();
            menu.Dispose();


        public void run() {
            Application.Run(menu);
        }

        protected void autorSelectionChanged(object sender, EventArgs args)
        {
            AutorDTO a;
            if ((a = autorGetSelected()) != null)
            {
            }
        }

        protected AutorDTO autorGetSelected()
        {
            if (cd.dgvAutors.SelectedRows.Count == 0)
            {
                return null;
            }
            else
            {
                return (new AutorDTO(cd.dgvAutors.SelectedRows[0].Cells));
            }
        }

    }
}
