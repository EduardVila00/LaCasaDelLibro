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
        BibliotecaAdmin BibliotecaAdmin = new BibliotecaAdmin();
        ConfigDades cd = new ConfigDades();
        Calendari calendari = new Calendari();
        BibliotecaEntities db = new BibliotecaEntities();

        #region Controller Principal
        public void init() {
            initListeners();
            run();
        }

        public void initListeners() {
            menu.buttonCalendari.Click += obrirCalendari;
            BibliotecaAdmin.buttonAutors.Click += changeButton1;
            BibliotecaAdmin.buttonCalendari.Click += changeButton1;
            BibliotecaAdmin.buttonConfiguracio.Click += changeButton1;
            BibliotecaAdmin.buttonCopies.Click += changeButton1;
            BibliotecaAdmin.buttonLlibres.Click += changeButton1;
            BibliotecaAdmin.buttonPrestecs.Click += changeButton1;
            BibliotecaAdmin.buttonUsuaris.Click += changeButton1;
            //cd.dgvAutors.SelectionChanged += autorSelectionChanged;
            //calendari.buttondesabilitar.Click += habilitarCalendari;
            //cd.buttonAfegirAutor.Click += finestraAutor;
            //cd.dgvAutors.SelectionChanged += autorSelectionChanged;

        }


        public void changeButton1(object sender, EventArgs e) {

            Button button = sender as Button;
            BibliotecaAdmin.SidePanel.Top = button.Top;
            BibliotecaAdmin.SidePanel.Height = button.Height;
            int pos = button.Top;
            switch (pos) {

                case 59:
                    BibliotecaAdmin.autor1.BringToFront();
                    break;
                case 116:
                    BibliotecaAdmin.llibre1.BringToFront();
                    break;
                case 173:
                    BibliotecaAdmin.copia1.BringToFront();
                    break;
                case 230:
                    BibliotecaAdmin.usuari1.BringToFront();
                    break;
                case 287:
                    BibliotecaAdmin.prestec1.BringToFront();
                    break;
                case 344:
                    BibliotecaAdmin.calendariFinal1.BringToFront();
                    break;
                case 401:
                    BibliotecaAdmin.configuracio1.BringToFront();
                    break;
                default:
                    break;
            }

        }

        public void run() {
            Application.Run(BibliotecaAdmin);
        }
        #endregion
        #region Calendari

        protected void diesNoHabilsPopulate() {
            // f1.dgvContactes.DataSource = db.contactes.ToList().Select(c => new ContacteDTO(c)).ToList();
            //calendari.dgvDiesNoHabils.DataSource = db.DiaNoHabil.ToList().Select();
        }


        protected void obrirCalendari(object sender, EventArgs args) {
            menu.Hide();
            calendari.ShowDialog();
        }

        protected void habilitarCalendari(object sender, EventArgs args) {
            DateTime dataNoValida = calendari.dateTimePicker1.Value;
            string dataNoValidaString = dataNoValida.ToString("MM/dd/yyyy");

            DiaNoHabil diaNoHabil = new DiaNoHabil();
            diaNoHabil.data = dataNoValida;
            db.DiaNoHabil.Add(diaNoHabil);

            MessageBox.Show(dataNoValidaString);
        }

        #endregion
        /*
        #region Config Dades
        protected void obrirConfigDades(object sender, EventArgs args) {
            menu.Hide();
            cd.ShowDialog();
            autorsPopulate();
        }
        protected void finestraAutor(object sender, EventArgs args) {
            cd.Hide();
            fa.ShowDialog();
        }
        protected int trySave() {
            try {
                db.SaveChanges();
                return (cd.dgvAutors.SelectedRows[0].Index);
            } catch (Exception e) {
                Console.WriteLine(e);
                return 0;
            }
        }
        protected void autorsGo(int n) {
            try {
                cd.dgvAutors.CurrentCell = cd.dgvAutors.Rows[n].Cells[0];
            } catch (Exception e) {
            }
        }
        protected void llibresGo(int n) {
            try {
                cd.dgvLlibres.CurrentCell = cd.dgvLlibres.Rows[n].Cells[0];
            } catch (Exception e) {
            }
        }
        protected void copiesGo(int n) {
            try {
                cd.dgvCopies.CurrentCell = cd.dgvCopies.Rows[n].Cells[0];
            } catch (Exception e) {
            }
        }
        protected void afegirAutor(object sender, EventArgs args) {
            string nom;
            string cognom;
            if (((nom = fa.textBoxNom.Text).CompareTo("") > 0) && ((cognom = fa.textBoxCognom.Text).CompareTo("") > 0)) {
                Autors a = new Autors();
                a.Nom = nom;
                a.Cognom = cognom;
                a.dataIntroduccio = DateTime.Now;
                a.dataDarreraModificacio = DateTime.Now;
                a.dataBaixa = DateTime.Parse("01/01/1990");
                db.Autors.Add(a);
                int n = trySave();
                autorsPopulate();
                autorsGo(cd.dgvAutors.RowCount - 1);
                cd.Visible = true;
                fa.Hide();
            }
        }
        public void autorsPopulate() {
            try {
                cd.dgvAutors.DataSource = db.Autors.ToList().Select(a => new AutorDTO(a)).ToList();
            } catch (Exception e) {
                MessageBox.Show("Error: \n" + e.ToString());
            }
        }
        public void llibresPopulate(AutorDTO a) {
            try {
                cd.dgvLlibres.DataSource = db.Llibre.ToList().Where(l => l.Autors.Equals(a)).Select(l => new LlibreDTO(l)).ToList();
            } catch (Exception e) {
                MessageBox.Show("Error: \n" + e.ToString());
            }
        }
        public void copiesPopulate(LlibreDTO l) {
            try {
                cd.dgvCopies.DataSource = db.Copias.ToList().Where(c => c.Llibre_ISBN.Equals(l.ISBN)).Select(c => new CopiaDTO(c)).ToList();
            } catch (Exception e) {
                MessageBox.Show("Error: \n" + e.ToString());
            }
        }
        protected void autorSelectionChanged(object sender, EventArgs args) {
            AutorDTO a;
            if ((a = autorGetSelected()) != null) {
                llibresPopulate(a);
            }
        }

        protected AutorDTO autorGetSelected() {
            if (cd.dgvAutors.SelectedRows.Count == 0) {
                return null;
            } else {
                return (new AutorDTO(cd.dgvAutors.SelectedRows[0].Cells));
            }
        }
        #endregion
    */
    }
}
