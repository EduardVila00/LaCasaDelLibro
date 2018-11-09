using Model;
using View;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Controller {
    public class Controller {
        BibliotecaAdmin BibliotecaAdmin = new BibliotecaAdmin();
        BibliotecaEntities db = new BibliotecaEntities();

        #region Controller Principal
        public void init() {
            initListeners();
            populaters();
            run();
        }

        public void initListeners() {
            BibliotecaAdmin.autor1.BringToFront();
            BibliotecaAdmin.buttonAutors.Click += changeButton1;
            BibliotecaAdmin.buttonCalendari.Click += changeButton1;
            BibliotecaAdmin.buttonConfiguracio.Click += changeButton1;
            BibliotecaAdmin.buttonCopies.Click += changeButton1;
            BibliotecaAdmin.buttonLlibres.Click += changeButton1;
            BibliotecaAdmin.buttonPrestecs.Click += changeButton1;
            BibliotecaAdmin.buttonUsuaris.Click += changeButton1;
            BibliotecaAdmin.buttonExit.Click += exit;
            BibliotecaAdmin.llibre1.dgvAutors.SelectionChanged += autorSelectionChanged;
            BibliotecaAdmin.copia1.dgvLlibres.SelectionChanged += llibreSelectionChanged;
            BibliotecaAdmin.calendariFinal1.buttonDes.Click += deshabilitarDia;
            BibliotecaAdmin.calendariFinal1.buttonHabilitar.Click += habilitarDia;
            BibliotecaAdmin.calendariFinal1.textBoxAny.KeyPress += controlarAny;

            //cd.dgvAutors.SelectionChanged += autorSelectionChanged;
            //calendari.buttondesabilitar.Click += habilitarCalendari;
            //cd.buttonAfegirAutor.Click += finestraAutor;


        }

        public void populaters() {
            autorsPopulate();
            diesNoHabilsPopulate();
            llibresPopulate();
            copiesPopulate();
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

        public void exit(object sender, EventArgs e) {
            Environment.Exit(-1);
        }
        #endregion
        #region Calendari

        protected void diesNoHabilsPopulate() {
            // f1.dgvContactes.DataSource = db.contactes.ToList().Select(c => new ContacteDTO(c)).ToList();
            //calendari.dgvDiesNoHabils.DataSource = db.DiaNoHabil.ToList().Select();
            BibliotecaAdmin.calendariFinal1.dataGridView1.DataSource = db.DiaNoHabil.ToList().Select(a => new DiaNoHabilDTO(a)).OrderBy(a=>a.data).ToList();
        }



        protected void deshabilitarDia(object sender, EventArgs args) {

            DateTime dataNoValida = BibliotecaAdmin.calendariFinal1.dateTimePickerDes.Value;
            string dataString = dataNoValida.ToString("yyyy-MM-dd");


            DateTime dataFinal = DateTime.Parse(dataString);
            DiaNoHabil diaNoHabil = new DiaNoHabil();
            diaNoHabil.data = dataFinal;
            bool comp = true;
            foreach (DiaNoHabil dia in db.DiaNoHabil) {
                if (dia.data == diaNoHabil.data) {
                    comp = false;
                }
            }
            if (comp) {
                db.DiaNoHabil.Add(diaNoHabil);
                trySaves();
                diesNoHabilsPopulate();
            }

        }
        protected DiaNoHabilDTO diaNoHabilGetSelected() {
            if (BibliotecaAdmin.calendariFinal1.dataGridView1.SelectedRows.Count == 0) {
                return null;

            } else {
                return (new DiaNoHabilDTO(BibliotecaAdmin.calendariFinal1.dataGridView1.SelectedRows[0].Cells));
            }
        }


        protected void habilitarDia(object sender, EventArgs e) {
            DiaNoHabil c;
            DiaNoHabilDTO cDTO = diaNoHabilGetSelected();
            c = db.DiaNoHabil.Where(x => x.Id == cDTO.Id).FirstOrDefault();
            db.DiaNoHabil.Remove(c);
            trySaves();
            diesNoHabilsPopulate();

        }
        public void controlarAny(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        public void deshabilitarTotsDies(object sender, EventArgs e) {
            if (BibliotecaAdmin.calendariFinal1.comboBoxDia.SelectedIndex. != null) {
                int any = int.Parse(BibliotecaAdmin.calendariFinal1.textBoxAny.Text);
                if (any < 2099 && any > 2017) {

                }
            }
            
        }


        protected void trySaves() {
            try {
                db.SaveChanges();
            } catch (Exception e) {
                Console.WriteLine(e);
            }
        }



        #endregion

        #region Autor
        protected int trySave() {
            try {
                db.SaveChanges();
                return (BibliotecaAdmin.autor1.dgvAutors.SelectedRows[0].Index);
            } catch (Exception e) {
                Console.WriteLine(e);
                return 0;
            }
        }
        protected void autorsGo(int n) {
            try {
                BibliotecaAdmin.autor1.dgvAutors.CurrentCell = BibliotecaAdmin.autor1.dgvAutors.Rows[n].Cells[0];
            } catch (Exception e) {
            }
        }
        protected void llibresGo(int n) {
            try {
                BibliotecaAdmin.llibre1.dgvLlibres.CurrentCell = BibliotecaAdmin.llibre1.dgvLlibres.Rows[n].Cells[0];
            } catch (Exception e) {
            }
        }
        protected void copiesGo(int n) {
            try {
                BibliotecaAdmin.copia1.dgvCopies.CurrentCell = BibliotecaAdmin.copia1.dgvCopies.Rows[n].Cells[0];
            } catch (Exception e) {
            }
        }
        //protected void afegirAutor(object sender, EventArgs args) {
        //    string nom;
        //    string cognom;
        //    if (((nom = fa.textBoxNom.Text).CompareTo("") > 0) && ((cognom = fa.textBoxCognom.Text).CompareTo("") > 0)) {
        //        Autors a = new Autors();
        //        a.Nom = nom;
        //        a.Cognom = cognom;
        //        a.dataIntroduccio = DateTime.Now;
        //        a.dataDarreraModificacio = DateTime.Now;
        //        a.dataBaixa = DateTime.Parse("01/01/1990");
        //        db.Autors.Add(a);
        //        int n = trySave();
        //        autorsPopulate();
        //        autorsGo(cd.dgvAutors.RowCount - 1);
        //        cd.Visible = true;
        //        fa.Hide();
        //    }
        //}
        public void autorsPopulate() {
            try {
                BibliotecaAdmin.autor1.dgvAutors.DataSource = db.Autor.ToList().Select(a => new AutorDTO(a)).ToList();
                BibliotecaAdmin.llibre1.dgvAutors.DataSource = db.Autor.ToList().Select(a => new AutorDTO(a)).ToList();
                BibliotecaAdmin.llibre1.dgvAutors.Columns["dataBaixa"].Visible = false;
                BibliotecaAdmin.llibre1.dgvAutors.Columns["dataIntroduccio"].Visible = false;
                BibliotecaAdmin.llibre1.dgvAutors.Columns["dataDarreraModificacio"].Visible = false;
            } catch (Exception e) {
                MessageBox.Show("Error: \n" + e.ToString());
            }
        }
        //public void llibresPopulate(AutorDTO a) {
        //    try {
        //        cd.dgvLlibres.DataSource = db.Llibre.ToList().Where(l => l.Autor.Equals(a)).Select(l => new LlibreDTO(l)).ToList();
        //    } catch (Exception e) {
        //        MessageBox.Show("Error: \n" + e.ToString());
        //    }
        //}
        //public void copiesPopulate(LlibreDTO l) {
        //    try {
        //        cd.dgvCopies.DataSource = db.Copias.ToList().Where(c => c.Llibre_ISBN.Equals(l.ISBN)).Select(c => new CopiaDTO(c)).ToList();
        //    } catch (Exception e) {
        //        MessageBox.Show("Error: \n" + e.ToString());
        //    }
        //}
        protected void autorSelectionChanged(object sender, EventArgs args) {
            AutorDTO a;
            if ((a = autorGetSelected()) != null) {
                llibresPopulate();
            }
        }

        protected AutorDTO autorGetSelected() {
            if (BibliotecaAdmin.autor1.dgvAutors.SelectedRows.Count == 0) {
                return null;
            } else {
                return (new AutorDTO(BibliotecaAdmin.autor1.dgvAutors.SelectedRows[0].Cells));
            }
        }
        protected AutorDTO autorLlibreGetSelected() {
            if (BibliotecaAdmin.llibre1.dgvAutors.SelectedRows.Count == 0) {
                return null;
            } else {
                return (new AutorDTO(BibliotecaAdmin.llibre1.dgvAutors.SelectedRows[0].Cells));
            }
        }
        #endregion
        #region Llibre
        public void llibresPopulate() {
            try {
                AutorDTO a;
                if ((a = autorLlibreGetSelected()) != null) {
                    BibliotecaAdmin.llibre1.dgvLlibres.DataSource = db.Llibre.ToList().Where(l => l.AutorId.Equals(a.Id)).Select(l => new LlibreDTO(l)).ToList();
                    BibliotecaAdmin.copia1.dgvLlibres.DataSource = db.Llibre.ToList().Select(l => new LlibreDTO(l)).ToList();
                } else {
                    BibliotecaAdmin.copia1.dgvLlibres.DataSource = db.Llibre.ToList().Select(l => new LlibreDTO(l)).ToList();
                }
            } catch (Exception e) {
                MessageBox.Show("Error: \n" + e.ToString());
            }
        }
        protected LlibreDTO llibreCopiaGetSelected() {
            if (BibliotecaAdmin.copia1.dgvLlibres.SelectedRows.Count == 0) {
                return null;
            } else {
                return (new LlibreDTO(BibliotecaAdmin.copia1.dgvLlibres.SelectedRows[0].Cells));
            }
        }

        protected void llibreSelectionChanged(object sender, EventArgs args) {
            LlibreDTO a;
            if ((a = llibreCopiaGetSelected()) != null) {
                copiesPopulate();
            }
        }
        #endregion
        #region Copia
        public void copiesPopulate() {
            try {
                LlibreDTO a;
                if ((a = llibreCopiaGetSelected()) != null) {
                    BibliotecaAdmin.copia1.dgvCopies.DataSource = db.Copia.ToList().Where(l => l.LlibreIsbn.Equals(a.Isbn)).Select(l => new CopiaDTO(l)).ToList();
                }
            } catch (Exception e) {

            }
            #endregion

        }

    }
}


