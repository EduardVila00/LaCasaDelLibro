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
using System.Text.RegularExpressions;

namespace Controller
{
    public class Controller
    {
        BibliotecaAdmin BibliotecaAdmin = new BibliotecaAdmin();
        BibliotecaEntities1 db = new BibliotecaEntities1();
        public static string Missatge = "Hi ha algun camp sense text";
        #region Controller Principal
        public void init()
        {
            initListeners();
            populaters();
            run();
        }

        public void initListeners()
        {
            // Menu Principal
            BibliotecaAdmin.autor1.BringToFront();
            BibliotecaAdmin.buttonBack.Click += returnMenu;
            BibliotecaAdmin.buttonAutors.Click += changeButton1;
            BibliotecaAdmin.buttonCalendari.Click += changeButton1;
            BibliotecaAdmin.buttonConfiguracio.Click += changeButton1;
            BibliotecaAdmin.buttonCopies.Click += changeButton1;
            BibliotecaAdmin.buttonLlibres.Click += changeButton1;
            BibliotecaAdmin.buttonPrestecs.Click += changeButton1;
            BibliotecaAdmin.buttonUsuaris.Click += changeButton1;
            BibliotecaAdmin.buttonExit.Click += exit;
            // Calendari
            BibliotecaAdmin.calendariFinal1.buttonDes.Click += deshabilitarDia;
            BibliotecaAdmin.calendariFinal1.buttonAcceptar.Click += deshabilitarTotsDies;
            BibliotecaAdmin.calendariFinal1.buttonHabilitar.Click += habilitarDia;
            // Autor
            BibliotecaAdmin.autor1.checkBoxDeshabilitats.CheckedChanged += autorsDeshabilitats;
            BibliotecaAdmin.autor1.buttonAfegir.Click += afegirAutorToFront;
            BibliotecaAdmin.autor1.buttonModificar.Click += modificarAutorToFront;
            BibliotecaAdmin.afegirAutor1.buttonAfegir.Click += afegirAutor;
            BibliotecaAdmin.modificarAutor1.buttonAfegirLlibres.Click += afegirLlibreToAutor;
            BibliotecaAdmin.modificarAutor1.buttonModificar.Click += modificarAutor;
            BibliotecaAdmin.autor1.buttonEliminar.Click += eliminarAutor;
            // Llibre
            BibliotecaAdmin.llibre1.checkBoxDeshabilitats.CheckedChanged += llibresDeshabilitats;
            BibliotecaAdmin.llibre1.buttonAfegir.Click += afegirLlibreToFront;
            BibliotecaAdmin.afegirLlibre1.buttonAfegir.Click += afegirLlibre;
            BibliotecaAdmin.llibre1.buttonModificar.Click += modificarLlibreToFront;
            BibliotecaAdmin.modificarLlibre1.buttonAfegirAutors.Click += afegirAutorToLlibre;
            BibliotecaAdmin.modificarLlibre1.buttonModificar.Click += modificarLlibre;
            BibliotecaAdmin.llibre1.buttonEliminar.Click += eliminarLlibre;
            // Copia
            BibliotecaAdmin.copia1.checkBoxDeshabilitats.CheckedChanged += copiesDeshabilitats;
            BibliotecaAdmin.copia1.buttonAfegir.Click += afegirCopia;
            BibliotecaAdmin.copia1.buttonModificar.Click += modificarCopia;
            BibliotecaAdmin.copia1.buttonEliminar.Click += eliminarCopia;
            BibliotecaAdmin.copia1.dgvLlibres.SelectionChanged += llibreSelectionChanged;
            // Usuari
            BibliotecaAdmin.usuari1.buttonAfegir.Click += afegirUsuariToFront;
            BibliotecaAdmin.afegirUsuari1.buttonAfegir.Click += afegirUsuari;
            BibliotecaAdmin.usuari1.buttonModificar.Click += modificarUsuariToFront;
            BibliotecaAdmin.modificarUsuari1.buttonModificar.Click += modificarUsuari;
            BibliotecaAdmin.usuari1.buttonEliminar.Click += eliminarUsuari;
            // Prestec
            BibliotecaAdmin.prestec1.dgvUsuaris.SelectionChanged += SociSelectionChanged;
            BibliotecaAdmin.prestec1.buttonGenerarPrestec.Click += crearPrestecToFront;
            BibliotecaAdmin.prestec1.checkBoxMostrarFinalitzats.CheckedChanged += veurePrestecsDeshabilitats;
            BibliotecaAdmin.generarPrestec1.buttonGenerarPrestec.Click += crearPrestec;
            BibliotecaAdmin.prestec1.buttonFinalitzarPrestec.Click += finalitzarPrestec;
            //Keypress
            BibliotecaAdmin.afegirAutor1.textBoxNom.KeyPress += noNumbers;
            BibliotecaAdmin.afegirAutor1.textBoxCognoms.KeyPress += noNumbers;

            BibliotecaAdmin.modificarAutor1.textBoxNom.KeyPress += noNumbers;
            BibliotecaAdmin.modificarAutor1.textBoxCognoms.KeyPress += noNumbers;

            BibliotecaAdmin.afegirLlibre1.textBoxIdioma.KeyPress += noNumbers;
            BibliotecaAdmin.afegirLlibre1.textBoxIsbn.KeyPress += noLetters;
            BibliotecaAdmin.afegirLlibre1.textBoxNumPagines.KeyPress += noLetters;

            BibliotecaAdmin.modificarLlibre1.textBoxIdioma.KeyPress += noNumbers;
            BibliotecaAdmin.modificarLlibre1.textBoxIsbn.KeyPress += noLetters;
            BibliotecaAdmin.modificarLlibre1.textBoxNumPagines.KeyPress += noLetters;

            BibliotecaAdmin.afegirUsuari1.textBoxNom.KeyPress += noNumbers;
            BibliotecaAdmin.afegirUsuari1.textBoxCognoms.KeyPress += noNumbers;

            BibliotecaAdmin.modificarUsuari1.textBoxNom.KeyPress += noNumbers;
            BibliotecaAdmin.modificarUsuari1.textBoxCognoms.KeyPress += noNumbers;






        }

        private void TextBoxTitol_KeyPress(object sender, KeyPressEventArgs e) {
            throw new NotImplementedException();
        }

        public void populaters() {
            autorsPopulate();
            diesNoHabilsPopulate();
            llibresPopulate();
            copiesPopulate();
            usuarisPopulate();
        }


        public void changeButton1(object sender, EventArgs e)
        {

            Button button = sender as Button;
            BibliotecaAdmin.SidePanel.Top = button.Top;
            BibliotecaAdmin.SidePanel.Height = button.Height;
            int pos = button.Top;
            switch (pos)
            {

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
        private void returnMenu(object sender, EventArgs e)
        {
            switch (BibliotecaAdmin.SidePanel.Top)
            {

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

        public static void exit(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
        #endregion
        #region Calendari

        protected void diesNoHabilsPopulate()
        {
            // f1.dgvContactes.DataSource = db.contactes.ToList().Select(c => new ContacteDTO(c)).ToList();
            //calendari.dgvDiesNoHabils.DataSource = db.DiaNoHabil.ToList().Select();
            BibliotecaAdmin.calendariFinal1.dataGridView1.DataSource = db.DiaNoHabil.ToList().Select(a => new DiaNoHabilDTO(a)).OrderBy(a => a.data).ToList();
        }



        protected void deshabilitarDia(object sender, EventArgs args)
        {
            DateTime dataNoValida = BibliotecaAdmin.calendariFinal1.dateTimePickerDes.Value;
            string dataString = dataNoValida.ToString("yyyy-MM-dd");


            DateTime dataFinal = DateTime.Parse(dataString);
            DiaNoHabil diaNoHabil = new DiaNoHabil
            {
                data = dataFinal
            };
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
                trySaves();
                diesNoHabilsPopulate();
            }
        }
        protected DiaNoHabilDTO diaNoHabilGetSelected()
        {
            if (BibliotecaAdmin.calendariFinal1.dataGridView1.SelectedRows.Count == 0)
            {
                return null;

            }
            else
            {
                return (new DiaNoHabilDTO(BibliotecaAdmin.calendariFinal1.dataGridView1.SelectedRows[0].Cells));
            }
        }


        protected void habilitarDia(object sender, EventArgs e)
        {
            DiaNoHabil c;
            DiaNoHabilDTO cDTO = diaNoHabilGetSelected();
            c = db.DiaNoHabil.Where(x => x.Id == cDTO.Id).FirstOrDefault();
            db.DiaNoHabil.Remove(c);
            trySaves();
            diesNoHabilsPopulate();

        }


        public void deshabilitarTotsDies(object sender, EventArgs e)
        {
            string diaSeleccionat = BibliotecaAdmin.calendariFinal1.comboBoxDia.SelectedItem.ToString();
            if (diaSeleccionat != null)
            {
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
            DiaNoHabil diaNoHabil = new DiaNoHabil
            {
                data = dataFinal
            };
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


        protected void trySaves()
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }



        #endregion
        #region General
        protected int trySave()
        {
            try
            {
                db.SaveChanges();
                return (BibliotecaAdmin.autor1.dgvAutors.SelectedRows[0].Index);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }
        }

        protected void afegirAutorToFront(object sender, EventArgs args)
        {
            BibliotecaAdmin.afegirAutor1.textBoxNom.Text = "";
            BibliotecaAdmin.afegirAutor1.textBoxCognoms.Text = "";
            BibliotecaAdmin.afegirAutor1.BringToFront();
        }

        protected void modificarAutorToFront(object sender, EventArgs args)
        {
            BibliotecaAdmin.modificarAutor1.textBoxNom.Text = autorGetSelected().Nom;
            BibliotecaAdmin.modificarAutor1.textBoxCognoms.Text = autorGetSelected().Cognoms;
            llibresPopulate();
            BibliotecaAdmin.modificarAutor1.BringToFront();
        }

        protected void afegirLlibreToFront(object sender, EventArgs args)
        {
            BibliotecaAdmin.afegirLlibre1.textBoxIsbn.Text = "";
            BibliotecaAdmin.afegirLlibre1.textBoxTitol.Text = "";
            BibliotecaAdmin.afegirLlibre1.textBoxNumPagines.Text = "";
            BibliotecaAdmin.afegirLlibre1.textBoxEditorial.Text = "";
            BibliotecaAdmin.afegirLlibre1.textBoxIdioma.Text = "";
            BibliotecaAdmin.afegirLlibre1.BringToFront();
        }

        protected void modificarLlibreToFront(object sender, EventArgs args)
        {
            BibliotecaAdmin.modificarLlibre1.textBoxIsbn.Text = llibreGetSelected().Isbn;
            BibliotecaAdmin.modificarLlibre1.textBoxTitol.Text = llibreGetSelected().Titol;
            BibliotecaAdmin.modificarLlibre1.textBoxNumPagines.Text = llibreGetSelected().numPagines.ToString();
            BibliotecaAdmin.modificarLlibre1.textBoxEditorial.Text = llibreGetSelected().editorial;
            BibliotecaAdmin.modificarLlibre1.textBoxIdioma.Text = llibreGetSelected().idioma;
            autorsPopulate();
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

        public void noLetters(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void noNumbers(object sender, KeyPressEventArgs e) {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char) Keys.Back) && !char.IsWhiteSpace(e.KeyChar)) {
                e.Handled = true;
            }
        }


        #endregion
        #region Autor
        //protected void autorsGo(int n) {
        //    try {
        //        BibliotecaAdmin.autor1.dgvAutors.CurrentCell = BibliotecaAdmin.autor1.dgvAutors.Rows[n].Cells[0];
        //    } catch (Exception e) {
        //        MessageBox.Show(e.ToString());
        //    }
        //}

        protected void afegirAutor(object sender, EventArgs args)
        {
            string nom;
            string cognoms;
            if (((nom = BibliotecaAdmin.afegirAutor1.textBoxNom.Text).CompareTo("") > 0) && ((cognoms = BibliotecaAdmin.afegirAutor1.textBoxCognoms.Text).CompareTo("") > 0))
            {
                Model.Autor a = new Model.Autor
                {
                    nom = nom,
                    cognoms = cognoms,
                    dataIntroduccio = DateTime.Now,
                    dataDarreraModificacio = DateTime.Now,
                    dataBaixa = null
                };
                db.Autor.Add(a);
                int n = trySave();
                autorsPopulate();
                //autorsGo(BibliotecaAdmin.autor1.dgvAutors.RowCount - 1);
                BibliotecaAdmin.autor1.BringToFront();
            } else {
                MessageBox.Show(Missatge);
            }
        }
        protected void modificarAutor(object sender, EventArgs args)
        {
            string nom;
            string cognoms;
            int id = (autorGetSelected().Id);
            if (((nom = BibliotecaAdmin.modificarAutor1.textBoxNom.Text).CompareTo("") > 0) && ((cognoms = BibliotecaAdmin.modificarAutor1.textBoxCognoms.Text).CompareTo("") > 0))
            {
                Model.Autor a;
                AutorDTO aDTO = autorGetSelected();
                a = db.Autor.Where(x => x.Id == aDTO.Id).FirstOrDefault();
                a.nom = nom;
                a.cognoms = cognoms;
                a.dataDarreraModificacio = DateTime.Now;
                int n = trySave();
                autorsPopulate();
                //autorsGo(n);
                BibliotecaAdmin.autor1.BringToFront();
            } else {
                MessageBox.Show(Missatge);
            }
        }

        protected void eliminarAutor(object sender, EventArgs args)
        {
            int id = (autorGetSelected().Id);
            Model.Autor a;
            AutorDTO aDTO = autorGetSelected();
            Model.Prestec p = null;
            foreach (Model.Llibre llibre in db.Llibre.Where(l => l.Autor.Any(b => b.Id == aDTO.Id)))
            {
                foreach (Model.Copia copia in db.Copia.Where(x => x.LlibreIsbn == llibre.Isbn))
                {
                    if (db.Prestec.Where(x => x.CopiaId == copia.Id).FirstOrDefault() != null)
                    {
                        p = db.Prestec.Where(x => x.CopiaId == copia.Id).FirstOrDefault();
                    }
                }
            }

            if (p != null)
            {
                a = db.Autor.Where(x => x.Id == aDTO.Id).FirstOrDefault();
                a.dataDarreraModificacio = DateTime.Now;
                a.dataBaixa = DateTime.Now;
            }
            else
            {
                a = db.Autor.Where(x => x.Id == aDTO.Id).FirstOrDefault();
                db.Autor.Remove(a);
            }

            int n = trySave();
            autorsPopulate();
            //autorsGo(n);
        }
        protected void afegirLlibreToAutor(object sender, EventArgs args)
        {
            if (BibliotecaAdmin.modificarAutor1.dgvLlibres.SelectedRows[0].Cells != null)
            {
                int id = (autorGetSelected().Id);
                LlibreDTO lDTO = new LlibreDTO(BibliotecaAdmin.modificarAutor1.dgvLlibres.SelectedRows[0].Cells);
                Model.Llibre l = db.Llibre.Where(x => x.Isbn == lDTO.Isbn).FirstOrDefault();
                AutorDTO aDTO = autorGetSelected();
                Model.Autor a = db.Autor.Where(x => x.Id == aDTO.Id).FirstOrDefault();
                a.Llibre.Add(l);
                int n = trySave();
                llibresPopulate();
                //autorsGo(n);
            }
        }

        public void autorsPopulate()
        {
            try
            {
                if (!BibliotecaAdmin.autor1.checkBoxDeshabilitats.Checked)
                {
                    BibliotecaAdmin.autor1.dgvAutors.DataSource = db.Autor.ToList().Where(a => a.dataBaixa == null).Select(a => new AutorDTO(a)).ToList();
                } else
                {
                    BibliotecaAdmin.autor1.dgvAutors.DataSource = db.Autor.ToList().Where(a => a.dataBaixa != null).Select(a => new AutorDTO(a)).ToList();
                }
                if (llibreGetSelected() != null) {
                    string isbn = llibreGetSelected().Isbn;
                    Model.Llibre llib = db.Llibre.Where(x => x.Isbn == isbn).FirstOrDefault();

                    BibliotecaAdmin.modificarLlibre1.dgvAutors.DataSource = db.Autor.ToList().Where(l => !l.Llibre.Any(b => b.Isbn == llib.Isbn)).Select(b => new AutorDTO(b)).ToList();
                    BibliotecaAdmin.modificarLlibre1.dgvAutors.Columns["dataBaixa"].Visible = false;
                    BibliotecaAdmin.modificarLlibre1.dgvAutors.Columns["dataIntroduccio"].Visible = false;
                    BibliotecaAdmin.modificarLlibre1.dgvAutors.Columns["dataDarreraModificacio"].Visible = false;
                }
            } catch (Exception e) {
                MessageBox.Show("Error: \n" + e.ToString());
            }
        }

        protected void autorsDeshabilitats(object sender, EventArgs args)
        {
            autorsPopulate();
        }

        protected AutorDTO autorGetSelected()
        {
            if (BibliotecaAdmin.autor1.dgvAutors.SelectedRows.Count == 0)
            {
                return null;
            }
            else
            {
                return (new AutorDTO(BibliotecaAdmin.autor1.dgvAutors.SelectedRows[0].Cells));
            }
        }
        #endregion
        #region Llibre
        public void llibresPopulate() {
            try {
                if (BibliotecaAdmin.llibre1.checkBoxDeshabilitats.Checked)
                {
                    BibliotecaAdmin.llibre1.dgvLlibres.DataSource = db.Llibre.ToList().Where(a => a.dataBaixa != null).Select(l => new LlibreDTO(l)).ToList();
                }
                else
                {
                    BibliotecaAdmin.llibre1.dgvLlibres.DataSource = db.Llibre.ToList().Where(a => a.dataBaixa == null).Select(l => new LlibreDTO(l)).ToList();
                }

                BibliotecaAdmin.copia1.dgvLlibres.DataSource = db.Llibre.ToList().Select(l => new LlibreDTO(l)).ToList();
                BibliotecaAdmin.copia1.dgvLlibres.Columns["dataBaixa"].Visible = false;
                BibliotecaAdmin.copia1.dgvLlibres.Columns["dataIntroduccio"].Visible = false;
                BibliotecaAdmin.copia1.dgvLlibres.Columns["dataDarreraModificacio"].Visible = false;

                BibliotecaAdmin.generarPrestec1.dgvLlibres.DataSource = db.Llibre.ToList().Select(l => new LlibreDTO(l)).ToList();

                if (autorGetSelected() != null)
                {
                    int id = autorGetSelected().Id;
                    Model.Autor aut = db.Autor.Where(x => x.Id == id).FirstOrDefault();

                    BibliotecaAdmin.modificarAutor1.dgvLlibres.DataSource = db.Llibre.ToList().Where(l => !l.Autor.Any(b => b.Id == aut.Id)).Select(b => new LlibreDTO(b)).ToList();
                    BibliotecaAdmin.modificarAutor1.dgvLlibres.Columns["dataBaixa"].Visible = false;
                    BibliotecaAdmin.modificarAutor1.dgvLlibres.Columns["dataIntroduccio"].Visible = false;
                    BibliotecaAdmin.modificarAutor1.dgvLlibres.Columns["dataDarreraModificacio"].Visible = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: \n" + e.ToString());
            }
        }
        protected LlibreDTO llibreCopiaGetSelected()
        {
            if (BibliotecaAdmin.copia1.dgvLlibres.SelectedRows.Count == 0)
            {
                return null;
            }
            else
            {
                return (new LlibreDTO(BibliotecaAdmin.copia1.dgvLlibres.SelectedRows[0].Cells));
            }
        }

        protected LlibreDTO llibreGetSelected()
        {
            if (BibliotecaAdmin.llibre1.dgvLlibres.SelectedRows.Count == 0)
            {
                return null;
            }
            else
            {
                return (new LlibreDTO(BibliotecaAdmin.llibre1.dgvLlibres.SelectedRows[0].Cells));
            }
        }

        protected void llibreSelectionChanged(object sender, EventArgs args)
        {
            LlibreDTO a;
            if ((a = llibreCopiaGetSelected()) != null)
            {
                copiesPopulate();
            }
        }

        protected void llibresGo(int n)
        {
            try
            {
                BibliotecaAdmin.llibre1.dgvLlibres.CurrentCell = BibliotecaAdmin.llibre1.dgvLlibres.Rows[n].Cells[0];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());

            }
        }

        protected void afegirLlibre(object sender, EventArgs args)
        {
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
                l.dataIntroduccio = DateTime.Now;
                l.dataDarreraModificacio = DateTime.Now;
                l.dataBaixa = null;
                db.Llibre.Add(l);
                int n = trySave();
                llibresPopulate();
                /*llibresGo(BibliotecaAdmin.llibre1.dgvLlibres.RowCount - 1);*/
                BibliotecaAdmin.llibre1.BringToFront();
            } else {
                MessageBox.Show(Missatge);
            }
        }
        protected void modificarLlibre(object sender, EventArgs args)
        {
            string isbn;
            string titol;
            string numpaginesString;
            string editorial;
            string idioma;
            if (((isbn = BibliotecaAdmin.modificarLlibre1.textBoxIsbn.Text).CompareTo("") > 0) && ((titol = BibliotecaAdmin.modificarLlibre1.textBoxTitol.Text).CompareTo("") > 0)
                && ((numpaginesString = BibliotecaAdmin.modificarLlibre1.textBoxNumPagines.Text).CompareTo("") > 0) && ((editorial = BibliotecaAdmin.modificarLlibre1.textBoxEditorial.Text).CompareTo("") > 0)
                 && ((idioma = BibliotecaAdmin.modificarLlibre1.textBoxIdioma.Text).CompareTo("") > 0))
            {
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
                //llibresGo(n);
                BibliotecaAdmin.llibre1.BringToFront();
            } else {
                MessageBox.Show(Missatge);
            }
        }

        protected void eliminarLlibre(object sender, EventArgs args)
        {
            string isbn = (llibreGetSelected().Isbn);
            Model.Llibre l;
            LlibreDTO lDTO = llibreGetSelected();
            Model.Prestec p = null;
            foreach (Model.Copia copia in db.Copia.Where(x => x.LlibreIsbn == lDTO.Isbn))
            {
                if (db.Prestec.Where(x => x.CopiaId == copia.Id).FirstOrDefault() != null)
                {
                    p = db.Prestec.Where(x => x.CopiaId == copia.Id).FirstOrDefault();
                }
            }

            if (p != null)
            {
                l = db.Llibre.Where(x => x.Isbn == lDTO.Isbn).FirstOrDefault();
                l.dataDarreraModificacio = DateTime.Now;
                l.dataBaixa = DateTime.Now;
            }
            else
            {
                l = db.Llibre.Where(x => x.Isbn == lDTO.Isbn).FirstOrDefault();
                db.Llibre.Remove(l);
            }

        int n = trySave();
        llibresPopulate();
        //llibresGo(n);
    }

        protected void llibresDeshabilitats(object sender, EventArgs args)
        {
            llibresPopulate();
        }

        protected void afegirAutorToLlibre(object sender, EventArgs args)
    {
        if (BibliotecaAdmin.modificarLlibre1.dgvAutors.SelectedRows[0].Cells != null)
        {
            string isbn = (llibreGetSelected().Isbn);
            AutorDTO aDTO = new AutorDTO(BibliotecaAdmin.modificarLlibre1.dgvAutors.SelectedRows[0].Cells);
            Model.Autor a = db.Autor.Where(x => x.Id == aDTO.Id).FirstOrDefault();
            LlibreDTO lDTO = llibreGetSelected();
            Model.Llibre l = db.Llibre.Where(x => x.Isbn == lDTO.Isbn).FirstOrDefault();
            l.Autor.Add(a);
            int n = trySave();
            autorsPopulate();
            //autorsGo(n);
        }
    }

    #endregion
        #region Copia
    public void copiesPopulate()
    {
        try
        {
            LlibreDTO a;
            if ((a = llibreCopiaGetSelected()) != null)
            {
                    if (BibliotecaAdmin.copia1.checkBoxDeshabilitats.Checked)
                    {
                        BibliotecaAdmin.copia1.dgvCopies.DataSource = db.Copia.ToList().Where(c => c.dataBaixa != null).Select(c => new CopiaDTO(c)).ToList();
                    }
                    else
                    {
                        BibliotecaAdmin.copia1.dgvCopies.DataSource = db.Copia.ToList().Where(l => l.LlibreIsbn.Equals(a.Isbn)).Where(c => c.dataBaixa == null).Select(l => new CopiaDTO(l)).ToList();
                    } 
            }
        }
        catch (Exception e)
        {
            MessageBox.Show(e.ToString());

        }
    }
    protected void copiesGo(int n)
    {
        try
        {
            BibliotecaAdmin.copia1.dgvCopies.CurrentCell = BibliotecaAdmin.copia1.dgvCopies.Rows[n].Cells[0];
        }
        catch (Exception e)
        {
            MessageBox.Show(e.ToString());

        }
    }

    protected CopiaDTO copiaGetSelected()
    {
        if (BibliotecaAdmin.copia1.dgvCopies.SelectedRows.Count == 0)
        {
            return null;
        }
        else
        {
            return (new CopiaDTO(BibliotecaAdmin.copia1.dgvCopies.SelectedRows[0].Cells));
        }
    }

    protected void afegirCopia(object sender, EventArgs args)
    {
        Model.Copia c = new Model.Copia
        {
            LlibreIsbn = llibreCopiaGetSelected().Isbn,
            disponible = true,
            dataIntroduccio = DateTime.Now,
            dataDarreraModificacio = DateTime.Now,
            dataBaixa = null
        };
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
    protected void eliminarCopia(object sender, EventArgs args)
    {
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

        protected void copiesDeshabilitats(object sender, EventArgs args)
        {
            copiesPopulate();
        }
        #endregion
        #region Prestec

        protected void SociSelectionChanged(object sender, EventArgs args)
    {
        SociDTO a;
        if ((a = sociPrestecGetSelected()) != null)
        {
            prestecsPopulate();
        }
    }

    protected SociDTO sociPrestecGetSelected()
    {
        if (BibliotecaAdmin.prestec1.dgvUsuaris.SelectedRows.Count == 0)
        {
            return null;
        }
        else
        {
            return (new SociDTO(BibliotecaAdmin.prestec1.dgvUsuaris.SelectedRows[0].Cells));
        }
    }

        private void veurePrestecsDeshabilitats(object sender, EventArgs e) {

            if (BibliotecaAdmin.prestec1.checkBoxMostrarFinalitzats.Checked) {
                SociDTO a;
                if ((a = sociPrestecGetSelected()) != null) {
                    var PrestecsFinalitzats = db.Prestec.ToList().Where(l => l.SocisId == a.Id && l.dataRetorn != null).OrderBy(l => l.dataInici).Select(l => new PrestecDTO(l)).ToList();
                    BibliotecaAdmin.prestec1.dgvPrestecs.DataSource = PrestecsFinalitzats;
                } 
            } else {
                prestecsPopulate();
            }
        }

    public void prestecsPopulate()
    {
        try
        {
            SociDTO a;
            if ((a = sociPrestecGetSelected()) != null)
            {
                BibliotecaAdmin.prestec1.dgvPrestecs.DataSource = db.Prestec.ToList().Where(l => l.SocisId == a.Id && l.dataRetorn == null).OrderBy(l => l.dataInici).Select(l => new PrestecDTO(l)).ToList();
            }
        }
        catch (Exception e)
        {
            MessageBox.Show(e.ToString());

        }
    }

        public void crearPrestec(object sender, EventArgs args) {
            string maxPrestecs=null;
            string maxDies=null;
            if (BibliotecaAdmin.generarPrestec1.comboBoxPrestecs.SelectedItem != null && BibliotecaAdmin.generarPrestec1.comboBoxDies.SelectedItem != null) {
                maxPrestecs = BibliotecaAdmin.generarPrestec1.comboBoxPrestecs.SelectedItem.ToString();
                maxDies = BibliotecaAdmin.generarPrestec1.comboBoxDies.SelectedItem.ToString();
            }

            var missatge = "Aquest soci te el maxim de prestecs";
            int maximDePrestecs = 4;
            int cont = 0;
            int maximDeDies = 5;
            if (maxPrestecs != null && maxDies != null) {
                maximDeDies = int.Parse(maxDies);
                maximDePrestecs = int.Parse(maxPrestecs);
            }
            SociDTO sDTO = sociPrestecGetSelected();
            LlibreDTO lDTO = llibrePrestecGetSelected();
            if (sDTO != null && lDTO != null) {
                Soci soci = db.Soci.Where(x => x.Id == sDTO.Id).FirstOrDefault();
                Model.Llibre llibre = db.Llibre.Where(x => x.Isbn.Equals(lDTO.Isbn)).FirstOrDefault();
                Model.Copia c = null;
                foreach (var copia in db.Prestec.Where(z => z.SocisId == soci.Id && (z.dataRetorn == null))) {
                    cont++;
                }
                if (cont <= maximDePrestecs) {
                    foreach (var copia in db.Copia.Where(y => y.LlibreIsbn.Equals(llibre.Isbn))) {
                        if (copia.disponible) {
                            c = copia;
                            break;
                        }
                    }

                int contDiesNoHabils = 0;
                if (c != null)
                {
                    c.disponible = false;
                }


                DateTime avui = DateTime.Today;
                int num = 0;
                DateTime avuiMesos = avui.AddMonths(2);
                DateTime avuiDies = avui.AddDays(0);
                var a = 1;
                while (num < maximDeDies)
                {
                    contDiesNoHabils = 0;
                    avuiDies = avuiDies.AddDays(a++);

                    foreach (var dia in db.DiaNoHabil.Where(d => d.data < avuiMesos))
                    {

                        if (dia.data == avuiDies)
                        {
                            contDiesNoHabils++;
                        }
                    }
                    if (contDiesNoHabils == 0)
                    {
                        num++;
                    }

                }
                DateTime dataFinal = DateTime.Today.AddDays(a);
                Model.Prestec prestec = new Model.Prestec
                {
                    CopiaId = c.Id,
                    SocisId = soci.Id,
                    dataInici = DateTime.Now,
                    dataFinal = dataFinal,
                    dataRetorn = null
                };

                db.Prestec.Add(prestec);
                trySave();
                prestecsPopulate();
                BibliotecaAdmin.prestec1.BringToFront();

            }
            else
            {
                MessageBox.Show(missatge);
            }
        }
    }


    protected void finalitzarPrestec(object sender, EventArgs e)
    {
        PrestecDTO prestecDTO = PrestecGetSelected();
        Model.Prestec p = db.Prestec.Where(x => x.Id == prestecDTO.Id).FirstOrDefault();
        Model.Copia c = db.Copia.Where(y => y.Id == p.CopiaId).FirstOrDefault();
        p.dataRetorn = DateTime.Today;
        c.disponible = true;
        trySave();
        prestecsPopulate();
        copiesPopulate();


    }
    protected LlibreDTO llibrePrestecGetSelected()
    {
        if (BibliotecaAdmin.generarPrestec1.dgvLlibres.SelectedRows.Count == 0)
        {
            return null;
        }
        else
        {
            return (new LlibreDTO(BibliotecaAdmin.generarPrestec1.dgvLlibres.SelectedRows[0].Cells));
        }
    }
    protected PrestecDTO PrestecGetSelected()
    {
        if (BibliotecaAdmin.prestec1.dgvPrestecs.SelectedRows.Count == 0)
        {
            return null;
        }
        else
        {
            return (new PrestecDTO(BibliotecaAdmin.prestec1.dgvPrestecs.SelectedRows[0].Cells));
        }
    }


    protected void crearPrestecToFront(object sender, EventArgs args)
    {
        BibliotecaAdmin.generarPrestec1.BringToFront();
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
            MessageBox.Show(e.ToString());
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

        protected void afegirUsuari(object sender, EventArgs args) {
            string nom;
            string cognoms;
            if (((nom = BibliotecaAdmin.afegirUsuari1.textBoxNom.Text).CompareTo("") > 0) && ((cognoms = BibliotecaAdmin.afegirUsuari1.textBoxCognoms.Text).CompareTo("") > 0)) {
                Model.Soci s = new Model.Soci {
                    nom = nom,
                    cognoms = cognoms,
                    dataIntroduccio = DateTime.Now,
                    dataDarreraModificacio = DateTime.Now,
                    dataBaixa = null
                };
                db.Soci.Add(s);
                int n = trySave();
                usuarisPopulate();
                usuarisGo(BibliotecaAdmin.usuari1.dgvUsuaris.RowCount - 1);
                BibliotecaAdmin.usuari1.BringToFront();
            } else {
                MessageBox.Show(Missatge);
            }
        }
        protected void modificarUsuari(object sender, EventArgs args) {
            string nom;
            string cognoms;
            int id = (usuariGetSelected().Id);
            if (((nom = BibliotecaAdmin.modificarUsuari1.textBoxNom.Text).CompareTo("") > 0) && ((cognoms = BibliotecaAdmin.modificarUsuari1.textBoxCognoms.Text).CompareTo("") > 0)) {
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
            } else {
                MessageBox.Show(Missatge);
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
        private void veureUsuarisBaixa(object sender, EventArgs e) {

            if (BibliotecaAdmin.prestec1.checkBoxMostrarFinalitzats.Checked) {
                SociDTO a;
                    //var PrestecsFinalitzats = db.Prestec.ToList().Where(l => l.SocisId == a.Id && l.dataRetorn != null).OrderBy(l => l.dataInici).Select(l => new PrestecDTO(l)).ToList();
                    //BibliotecaAdmin.prestec1.dgvPrestecs.DataSource = PrestecsFinalitzats;

            } else {
                prestecsPopulate();
            }
        }


    public void usuarisPopulate()
    {
        try
        {
            BibliotecaAdmin.usuari1.dgvUsuaris.DataSource = db.Soci.ToList().Where(s=> s.dataBaixa!=null).Select(s => new SociDTO(s)).ToList();
            BibliotecaAdmin.prestec1.dgvUsuaris.DataSource = db.Soci.ToList().Where(s => s.dataBaixa != null).Select(a => new SociDTO(a)).ToList();
            BibliotecaAdmin.prestec1.dgvUsuaris.Columns["dataBaixa"].Visible = false;
            BibliotecaAdmin.prestec1.dgvUsuaris.Columns["dataIntroduccio"].Visible = false;
            BibliotecaAdmin.prestec1.dgvUsuaris.Columns["dataDarreraModificacio"].Visible = false;
            BibliotecaAdmin.generarPrestec1.dgvUsuaris.DataSource = db.Soci.ToList().Where(s => s.dataBaixa != null).Select(a => new SociDTO(a)).ToList();
            BibliotecaAdmin.generarPrestec1.dgvUsuaris.Columns["dataBaixa"].Visible = false;
            BibliotecaAdmin.generarPrestec1.dgvUsuaris.Columns["dataIntroduccio"].Visible = false;
            BibliotecaAdmin.generarPrestec1.dgvUsuaris.Columns["dataDarreraModificacio"].Visible = false;
        }
        catch (Exception e)
        {
            MessageBox.Show("Error: \n" + e.ToString());
        }
    }

    #endregion
}
}


