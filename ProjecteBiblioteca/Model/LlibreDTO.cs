using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model {
    public class LlibreDTO {
        public string Isbn { get; set; }
        public string Titol { get; set; }
        public int numPagines { get; set; }
        public string editorial { get; set; }
        public string idioma { get; set; }
        public DateTime dataIntroduccio { get; set; }
        public DateTime dataDarreraModificacio { get; set; }
        public DateTime? dataBaixa { get; set; }
        public int LlistaEsperas_Id { get; set; }

        public LlibreDTO(string ISBN, string titol, int numPagines, string editorial,string idioma, DateTime dataIntroduccio, DateTime dataDarreraModificacio, DateTime dataBaixa, int llistaEsperas_Id) {
            this.Isbn = ISBN;
            Titol = titol;
            this.numPagines = numPagines;
            this.editorial = editorial;
            this.idioma = idioma;
            this.dataIntroduccio = dataIntroduccio;
            this.dataDarreraModificacio = dataDarreraModificacio;
            this.dataBaixa = dataBaixa;
            LlistaEsperas_Id = llistaEsperas_Id;
        }

        public LlibreDTO(Llibre l) {
            Isbn = l.Isbn;
            Titol = l.titol;
            this.numPagines = l.numPagines;
            this.editorial = l.editorial;
            this.idioma = l.idioma;
            dataIntroduccio = l.dataIntroduccio;
            dataDarreraModificacio = l.dataDarreraModificacio;
            dataBaixa = l.dataBaixa;
        }

        public LlibreDTO(DataGridViewCellCollection row) {
            this.Isbn = (string) row["ISBN"].Value;
            this.Titol = (string) row["Titol"].Value;
            this.numPagines = (int) row["numPagines"].Value;
            this.editorial = (string) row["editorial"].Value;
            this.idioma = (string) row["idioma"].Value;
            this.dataIntroduccio = (DateTime) row["dataIntroduccio"].Value;
            this.dataDarreraModificacio = (DateTime) row["dataDarreraModificacio"].Value;
            this.dataBaixa = (DateTime) row["dataBaixa"].Value;
        }


    }
}
