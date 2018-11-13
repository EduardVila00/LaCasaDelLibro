using Model;
using View;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

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
            BibliotecaAdmin.calendariFinal1.buttonAcceptar.Click += deshabilitarTotsDies;
            BibliotecaAdmin.calendariFinal1.buttonHabilitar.Click += habilitarDia;
            BibliotecaAdmin.autor1.buttonAfegir.Click += afegirAutorToFront;
            BibliotecaAdmin.autor1.buttonModificar.Click += modificarAutorToFront;
            BibliotecaAdmin.afegirAutor1.buttonAfegir.Click += afegirAutor;
            BibliotecaAdmin.modificarAutor1.buttonModificar.Click += modificarAutor;
            BibliotecaAdmin.autor1.buttonEliminar.Click += eliminarAutor;
            BibliotecaAdmin.llibre1.buttonAfegir.Click += afegirLlibreToFront;
            BibliotecaAdmin.afegirLlibre1.buttonAfegir.Click += afegirLlibre;
            BibliotecaAdmin.llibre1.buttonModificar.Click += modificarLlibreToFront;
            BibliotecaAdmin.modificarLlibre1.buttonModificar.Click += modificarLlibre;
            BibliotecaAdmin.llibre1.buttonEliminar.Click += eliminarLlibre;
            BibliotecaAdmin.copia1.buttonAfegir.Click += afegirCopia;
            BibliotecaAdmin.copia1.buttonModificar.Click += modificarCopia;
            BibliotecaAdmin.copia1.buttonEliminar.Click += eliminarCopia;
            BibliotecaAdmin.usuari1.buttonAfegir.Click += afegirUsuariToFront;
            BibliotecaAdmin.afegirUsuari1.buttonAfegir.Click += afegirUsuari;
            BibliotecaAdmin.usuari1.buttonModificar.Click += modificarUsuariToFront;
            BibliotecaAdmin.modificarUsuari1.buttonModificar.Click += modificarUsuari;
            BibliotecaAdmin.usuari1.buttonEliminar.Click += eliminarUsuari;
            BibliotecaAdmin.calendariFinal1.textBoxAny.KeyPress += controlarAny;
            BibliotecaAdmin.prestec1.dgvUsuaris.SelectionChanged += SociSelectionChanged;



        }

        public void populaters() {
            autorsPopulate();
            diesNoHabilsPopulate();
            llibresPopulate();
            copiesPopulate();
            usuarisPopulate();
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

        public void run()
        {
            Application.Run(BibliotecaAdmin);
        }

        public void exit(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
        #endregion
        #region Calendari

        protected void diesNoHabilsPopulate() {
            // f1.dgvContactes.DataSource = db.contactes.ToList().Select(c => new ContacteDTO(c)).ToList();
            //calendari.dgvDiesNoHabils.DataSource = db.DiaNoHabil.ToList().Select();
            BibliotecaAdmin.calendariFinal1.dataGridView1.DataSource = db.DiaNoHabil.ToList().Select(a => new DiaNoHabilDTO(a)).OrderBy(a => a.data).ToList();
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

        public void deshabilitarTotsDies(object sender, EventArgs e)
        {
            string diaSeleccionat = BibliotecaAdmin.calendariFinal1.comboBoxDia.SelectedItem.ToString();
            if (diaSeleccionat != null) {
                int any = int.Parse(BibliotecaAdmin.calendariFinal1.textBoxAny.Text);
                if (any < 2099 && any > 2017)
                {
                    var year = any;
                    foreach (var month in Enumerable.Range(1, 12))
                    {
                        foreach (var day in Enumerable.Range(1, DateTime.DaysInMonth(year, month))
                      .Select(day => new DateTime(year, month, day).ToString("yyyy-MM-dd")))
                        {
                            DateTime dia = DateTime.Parse(day);
                            if (diaSeleccionat.Equals("Dilluns") && dia.DayOfWeek == DayOfWeek.Monday)
                            {
                                deshabilitarTotDia(dia);
                            }
                            if (diaSeleccionat.Equals("Dimarts") && dia.DayOfWeek == DayOfWeek.Tuesday)
                            {
                                deshabilitarTotDia(dia);
                            }
                            if (diaSeleccionat.Equals("Dimecres") && dia.DayOfWeek == DayOfWeek.Wednesday)
                            {
                                deshabilitarTotDia(dia);
                            }
                            if (diaSeleccionat.Equals("Dijous") && dia.DayOfWeek == DayOfWeek.Thursday)
                            {
                                deshabilitarTotDia(dia);
                            }
                            if (diaSeleccionat.Equals("Divendres") && dia.DayOfWeek == DayOfWeek.Friday)
                            {
                                deshabilitarTotDia(dia);
                            }
                            if (diaSeleccionat.Equals("Dissabte") && dia.DayOfWeek == DayOfWeek.Saturday)
                            {
                                deshabilitarTotDia(dia);
                            }
                            if (diaSeleccionat.Equals("Diumenge") && dia.DayOfWeek == DayOfWeek.Sunday)
                            {
                                deshabilitarTotDia(dia);
                            }
                        }
                    }
                    trySaves();
                    diesNoHabilsPopulate();
                }
                else
                {
                    MessageBox.Show("Introduiex un any entre 2017 i 2099");
                }
            }
            else
            {
                MessageBox.Show("Selecciona un dia");
            }

        }
        public void deshabilitarTotDia(DateTime dataFinal)
        {
            DiaNoHabil diaNoHabil = new DiaNoHabil();
            diaNoHabil.data = dataFinal;
            bool comp = true;
            foreach (DiaNoHabil dia in db.DiaNoHabil)
            {
                if (dia.data == diaNoHabil.data)
                {
                    comp = false;
                }
            }
            if (comp)
            {
                db.DiaNoHabil.Add(diaNoHabil);

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
        #region General
        protected int trySave() {
            try {
                db.SaveChanges();
                return (BibliotecaAdmin.autor1.dgvAutors.SelectedRows[0].Index);
            } catch (Exception e) {
                Console.WriteLine(e);
                return 0;
            }
        }

        protected void afegirAutorToFront(object sender, EventArgs args) {
            BibliotecaAdmin.afegirAutor1.textBoxNom.Text = "";
            BibliotecaAdmin.afegirAutor1.textBoxCognoms.Text = "";
            BibliotecaAdmin.afegirAutor1.BringToFront();
        }

        protected void modificarAutorToFront(object sender, EventArgs args) {
            BibliotecaAdmin.modificarAutor1.textBoxNom.Text = autorGetSelected().Nom;
            BibliotecaAdmin.modificarAutor1.textBoxCognoms.Text = autorGetSelected().Cognoms;
            BibliotecaAdmin.modificarAutor1.BringToFront();
        }

        protected void afegirLlibreToFront(object sender, EventArgs args) {
            BibliotecaAdmin.afegirLlibre1.textBoxIsbn.Text = "";
            BibliotecaAdmin.afegirLlibre1.textBoxTitol.Text = "";
            BibliotecaAdmin.afegirLlibre1.textBoxNumPagines.Text = "";
            BibliotecaAdmin.afegirLlibre1.textBoxEditorial.Text = "";
            BibliotecaAdmin.afegirLlibre1.textBoxIdioma.Text = "";
            BibliotecaAdmin.afegirLlibre1.BringToFront();
        }

        protected void modificarLlibreToFront(object sender, EventArgs args) {
            BibliotecaAdmin.modificarLlibre1.textBoxIsbn.Text = llibreGetSelected().Isbn;
            BibliotecaAdmin.modificarLlibre1.textBoxTitol.Text = llibreGetSelected().Titol;
            BibliotecaAdmin.modificarLlibre1.textBoxNumPagines.Text = llibreGetSelected().numPagines.ToString();
            BibliotecaAdmin.modificarLlibre1.textBoxEditorial.Text = llibreGetSelected().editorial;
            BibliotecaAdmin.modificarLlibre1.textBoxIdioma.Text = llibreGetSelected().idioma;
            BibliotecaAdmin.modificarLlibre1.BringToFront();
        }
        protected void afegirUsuariToFront(object sender, EventArgs args)
        {
            BibliotecaAdmin.afegirUsuari1.textBoxNom.Text = "";
            BibliotecaAdmin.afegirUsuari1.textBoxCognoms.Text = "";
            BibliotecaAdmin.afegirUsuari1.BringToFront();
        }

        protected void modificarUsuariToFront(object sender, EventArgs args)
        {
            BibliotecaAdmin.modificarUsuari1.textBoxNom.Text = usuariGetSelected().nom;
            BibliotecaAdmin.modificarUsuari1.textBoxCognoms.Text = usuariGetSelected().cognoms;
            BibliotecaAdmin.modificarUsuari1.BringToFront();
        }
        #endregion
        #region Autor
        protected void autorsGo(int n) {
            try {
                BibliotecaAdmin.autor1.dgvAutors.CurrentCell = BibliotecaAdmin.autor1.dgvAutors.Rows[n].Cells[0];
            } catch (Exception e) {
            }
        }

        protected void afegirAutor(object sender, EventArgs args) {
            string nom;
            string cognoms;
            if (((nom = BibliotecaAdmin.afegirAutor1.textBoxNom.Text).CompareTo("") > 0) && ((cognoms = BibliotecaAdmin.afegirAutor1.textBoxCognoms.Text).CompareTo("") > 0)) {
                Model.Autor a = new Model.Autor();
                a.nom = nom;
                a.cognoms = cognoms;
                a.dataIntroduccio = DateTime.Now;
                a.dataDarreraModificacio = DateTime.Now;
                a.dataBaixa = null;
                db.Autor.Add(a);
                int n = trySave();
                autorsPopulate();
                autorsGo(BibliotecaAdmin.autor1.dgvAutors.RowCount - 1);
                BibliotecaAdmin.autor1.BringToFront();
            }
        }
        protected void modificarAutor(object sender, EventArgs args)
        {
            string nom;
            string cognoms;
            int id = (autorGetSelected().Id);
            if (((nom = BibliotecaAdmin.modificarAutor1.textBoxNom.Text).CompareTo("") > 0) && ((cognoms = BibliotecaAdmin.modificarAutor1.textBoxCognoms.Text).CompareTo("") > 0)) {
                Model.Autor a;
                AutorDTO aDTO = autorGetSelected();
                a = db.Autor.Where(x => x.Id == aDTO.Id).FirstOrDefault();
                a.nom = nom;
                a.cognoms = cognoms;
                a.dataDarreraModificacio = DateTime.Now;
                int n = trySave();
                autorsPopulate();
                autorsGo(n);
                BibliotecaAdmin.autor1.BringToFront();
            }
        }

        protected void eliminarAutor(object sender, EventArgs args) {
            int id = (autorGetSelected().Id);
            Model.Autor a;
            AutorDTO aDTO = autorGetSelected();
            a = db.Autor.Where(x => x.Id == aDTO.Id).FirstOrDefault();
            db.Autor.Remove(a);
            int n = trySave();
            autorsPopulate();
            autorsGo(n);
        }
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
                BibliotecaAdmin.copia1.dgvLlibres.Columns["dataBaixa"].Visible = false;
                BibliotecaAdmin.copia1.dgvLlibres.Columns["dataIntroduccio"].Visible = false;
                BibliotecaAdmin.copia1.dgvLlibres.Columns["dataDarreraModificacio"].Visible = false;
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

        protected LlibreDTO llibreGetSelected() {
            if (BibliotecaAdmin.llibre1.dgvLlibres.SelectedRows.Count == 0) {
                return null;
            } else {
                return (new LlibreDTO(BibliotecaAdmin.llibre1.dgvLlibres.SelectedRows[0].Cells));
            }
        }

        protected void llibreSelectionChanged(object sender, EventArgs args) {
            LlibreDTO a;
            if ((a = llibreCopiaGetSelected()) != null) {
                copiesPopulate();
            }
        }

        protected void llibresGo(int n) {
            try {
                BibliotecaAdmin.llibre1.dgvLlibres.CurrentCell = BibliotecaAdmin.llibre1.dgvLlibres.Rows[n].Cells[0];
            } catch (Exception e) {
            }
        }

        protected void afegirLlibre(object sender, EventArgs args) {
            string isbn;
            string titol;
            string numpaginesString;
            string editorial;
            string idioma;
            if (((isbn = BibliotecaAdmin.afegirLlibre1.textBoxIsbn.Text).CompareTo("") > 0) && ((titol = BibliotecaAdmin.afegirLlibre1.textBoxTitol.Text).CompareTo("") > 0)
                && ((numpaginesString = BibliotecaAdmin.afegirLlibre1.textBoxNumPagines.Text).CompareTo("") > 0) && ((editorial = BibliotecaAdmin.afegirLlibre1.textBoxEditorial.Text).CompareTo("") > 0)
                 && ((idioma = BibliotecaAdmin.afegirLlibre1.textBoxIdioma.Text).CompareTo("") > 0)) {
                Model.Llibre l = new Model.Llibre();
                l.Isbn = isbn;
                l.titol = titol;
                l.numPagines = int.Parse(numpaginesString);
                l.editorial = editorial;
                l.idioma = idioma;
                l.AutorId = autorLlibreGetSelected().Id;
                l.dataIntroduccio = DateTime.Now;
                l.dataDarreraModificacio = DateTime.Now;
                l.dataBaixa = null;
                db.Llibre.Add(l);
                int n = trySave();
                llibresPopulate();
                llibresGo(BibliotecaAdmin.llibre1.dgvLlibres.RowCount - 1);
                BibliotecaAdmin.llibre1.BringToFront();
            }
        }
        protected void modificarLlibre(object sender, EventArgs args) {
            string isbn;
            string titol;
            string numpaginesString;
            string editorial;
            string idioma;
            int id = (autorGetSelected().Id);
            if (((isbn = BibliotecaAdmin.modificarLlibre1.textBoxIsbn.Text).CompareTo("") > 0) && ((titol = BibliotecaAdmin.modificarLlibre1.textBoxTitol.Text).CompareTo("") > 0)
                && ((numpaginesString = BibliotecaAdmin.modificarLlibre1.textBoxNumPagines.Text).CompareTo("") > 0) && ((editorial = BibliotecaAdmin.modificarLlibre1.textBoxEditorial.Text).CompareTo("") > 0)
                 && ((idioma = BibliotecaAdmin.modificarLlibre1.textBoxIdioma.Text).CompareTo("") > 0)) {
                Model.Llibre l;
                LlibreDTO lDTO = llibreGetSelected();
                l = db.Llibre.Where(x => x.Isbn == lDTO.Isbn).FirstOrDefault();
                l.Isbn = isbn;
                l.titol = titol;
                l.numPagines = int.Parse(numpaginesString);
                l.editorial = editorial;
                l.idioma = idioma;
                l.dataDarreraModificacio = DateTime.Now;
                int n = trySave();
                llibresPopulate();
                llibresGo(n);
                BibliotecaAdmin.llibre1.BringToFront();
            }
        }

        protected void eliminarLlibre(object sender, EventArgs args) {
            string isbn = (llibreGetSelected().Isbn);
            Model.Llibre l;
            LlibreDTO lDTO = llibreGetSelected();
            l = db.Llibre.Where(x => x.Isbn == lDTO.Isbn).FirstOrDefault();
            db.Llibre.Remove(l);
            int n = trySave();
            llibresPopulate();
            llibresGo(n);
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
        }
        protected void copiesGo(int n) {
            try {
                BibliotecaAdmin.copia1.dgvCopies.CurrentCell = BibliotecaAdmin.copia1.dgvCopies.Rows[n].Cells[0];
            } catch (Exception e) {
            }
        }

        protected CopiaDTO copiaGetSelected() {
            if (BibliotecaAdmin.copia1.dgvCopies.SelectedRows.Count == 0) {
                return null;
            } else {
                return (new CopiaDTO(BibliotecaAdmin.copia1.dgvCopies.SelectedRows[0].Cells));
            }
        }

        protected void afegirCopia(object sender, EventArgs args)
        {
            Model.Copia c = new Model.Copia();
            c.LlibreIsbn = llibreCopiaGetSelected().Isbn;
            c.disponible = true;
            c.dataIntroduccio = DateTime.Now;
            c.dataDarreraModificacio = DateTime.Now;
            c.dataBaixa = null;
            db.Copia.Add(c);
            int n = trySave();
            copiesPopulate();
            copiesGo(BibliotecaAdmin.copia1.dgvCopies.RowCount - 1);
        }
        protected void modificarCopia(object sender, EventArgs args)
        {
            Model.Copia c;
            CopiaDTO cDTO = copiaGetSelected();
            c = db.Copia.Where(x => x.Id == cDTO.Id).FirstOrDefault();
            if (c.disponible)
            {
                c.disponible = false;
            }
            else
            {
                c.disponible = true;
            }
            c.dataDarreraModificacio = DateTime.Now;
            int n = trySave();
            copiesPopulate();
            copiesGo(n);
        }
        protected void eliminarCopia(object sender, EventArgs args) {
            int id = (copiaGetSelected().Id);
            Model.Prestec p = db.Prestec.Where(x => x.CopiaId == id).FirstOrDefault();
            Model.Copia c;
            CopiaDTO cDTO = copiaGetSelected();
            if (p == null)
            {
                c = db.Copia.Where(x => x.Id == cDTO.Id).FirstOrDefault();
                db.Copia.Remove(c);
            }
            else
            {
                c = db.Copia.Where(x => x.Id == cDTO.Id).FirstOrDefault();
                c.dataDarreraModificacio = DateTime.Now;
                c.dataBaixa = DateTime.Now;
            }
            int n = trySave();
            copiesPopulate();
            copiesGo(n);
        }
        #endregion
        #region Prestec
        public void UsuarisPopulate() {
            try {
                BibliotecaAdmin.prestec1.dgvUsuaris.DataSource = db.Soci.ToList().Select(a => new SociDTO(a)).ToList();

                BibliotecaAdmin.prestec1.dgvUsuaris.Columns["dataBaixa"].Visible = false;
                BibliotecaAdmin.prestec1.dgvUsuaris.Columns["dataIntroduccio"].Visible = false;
                BibliotecaAdmin.prestec1.dgvUsuaris.Columns["dataDarreraModificacio"].Visible = false;


            } catch (Exception e) {
                MessageBox.Show("Error: \n" + e.ToString());
            }
        }

        protected void SociSelectionChanged(object sender, EventArgs args) {
            SociDTO a;
            if ((a = sociPrestecGetSelected()) != null) {
                prestecsPopulate();
            }
        }

        protected SociDTO sociPrestecGetSelected() {
            if (BibliotecaAdmin.prestec1.dgvUsuaris.SelectedRows.Count == 0) {
                return null;
            } else {
                return (new SociDTO(BibliotecaAdmin.prestec1.dgvUsuaris.SelectedRows[0].Cells));
            }
        }

        public void prestecsPopulate() {
            try {
                SociDTO a;
                if ((a = sociPrestecGetSelected()) != null) {
                    BibliotecaAdmin.prestec1.dgvPrestecs.DataSource = db.Prestec.ToList().Where(l => l.SocisId == a.Id).Select(l => new PrestecDTO(l)).ToList();
                }
            } catch (Exception e) {
            }
        }

        public void crearPrestec(object sender, EventArgs args) {
            int maximDePrestecs = 4;
            SociDTO sDTO = sociPrestecGetSelected();
            LlibreDTO lDTO = llibreGetSelected();
            if (sDTO != null && lDTO != null) {
                Soci soci = db.Soci.Where(x=> x.Id == sDTO.Id).FirstOrDefault();
                Model.Llibre llibre = db.Llibre.Where(x=> x.Isbn.Equals(lDTO.Isbn)).FirstOrDefault();
                foreach (var copia in db.Llibre.ToList()) {

                }
            }

        }

        #endregion
        #region Soci/Usuari
        protected void usuarisGo(int n)
        {
            try
            {
                BibliotecaAdmin.usuari1.dgvUsuaris.CurrentCell = BibliotecaAdmin.usuari1.dgvUsuaris.Rows[n].Cells[0];
            }
            catch (Exception e)
            {
            }
        }

        protected SociDTO usuariGetSelected()
        {
            if (BibliotecaAdmin.usuari1.dgvUsuaris.SelectedRows.Count == 0)
            {
                return null;
            }
            else
            {
                return (new SociDTO(BibliotecaAdmin.usuari1.dgvUsuaris.SelectedRows[0].Cells));
            }
        }

        protected void afegirUsuari(object sender, EventArgs args)
        {
            string nom;
            string cognoms;
            if (((nom = BibliotecaAdmin.afegirUsuari1.textBoxNom.Text).CompareTo("") > 0) && ((cognoms = BibliotecaAdmin.afegirUsuari1.textBoxCognoms.Text).CompareTo("") > 0))
            {
                Model.Soci s = new Model.Soci();
                s.nom = nom;
                s.cognoms = cognoms;
                s.dataIntroduccio = DateTime.Now;
                s.dataDarreraModificacio = DateTime.Now;
                s.dataBaixa = null;
                db.Soci.Add(s);
                int n = trySave();
                usuarisPopulate();
                usuarisGo(BibliotecaAdmin.usuari1.dgvUsuaris.RowCount - 1);
                BibliotecaAdmin.usuari1.BringToFront();
            }
        }
        protected void modificarUsuari(object sender, EventArgs args)
        {
            string nom;
            string cognoms;
            int id = (usuariGetSelected().Id);
            if (((nom = BibliotecaAdmin.modificarUsuari1.textBoxNom.Text).CompareTo("") > 0) && ((cognoms = BibliotecaAdmin.modificarUsuari1.textBoxCognoms.Text).CompareTo("") > 0))
            {
                Model.Soci a;
                SociDTO aDTO = usuariGetSelected();
                a = db.Soci.Where(x => x.Id == aDTO.Id).FirstOrDefault();
                a.nom = nom;
                a.cognoms = cognoms;
                a.dataDarreraModificacio = DateTime.Now;
                int n = trySave();
                usuarisPopulate();
                usuarisGo(n);
                BibliotecaAdmin.usuari1.BringToFront();
            }
        }

        protected void eliminarUsuari(object sender, EventArgs args)
        {
            int id = (usuariGetSelected().Id);
            Model.Soci a;
            SociDTO aDTO = usuariGetSelected();
            a = db.Soci.Where(x => x.Id == aDTO.Id).FirstOrDefault();
            db.Soci.Remove(a);
            int n = trySave();
            usuarisPopulate();
            usuarisGo(n);
        }

        public void usuarisPopulate()
        {
            try
            {
                BibliotecaAdmin.usuari1.dgvUsuaris.DataSource = db.Soci.ToList().Select(s => new SociDTO(s)).ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: \n" + e.ToString());
            }
        }

        #endregion
    }
}


