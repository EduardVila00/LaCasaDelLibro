using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model {
    class LlibreDTO {
        public int ISBN { get; set; }
        public string Titol { get; set; }
        public int numPagines { get; set; }
        public bool disponible { get; set; }
        public string editorial { get; set; }
        public DateTime dataIntroduccio { get; set; }
        public DateTime dataDarreraModificacio { get; set; }
        public DateTime dataBaixa { get; set; }
        public int LlistaEsperas_Id { get; set; }

        public LlibreDTO(int ISBN, string titol, int numPagines, bool disponible, string editorial, DateTime dataIntroduccio, DateTime dataDarreraModificacio, DateTime dataBaixa, int llistaEsperas_Id) {
            this.ISBN = ISBN;
            Titol = titol;
            this.numPagines = numPagines;
            this.disponible = disponible;
            this.editorial = editorial;
            this.dataIntroduccio = dataIntroduccio;
            this.dataDarreraModificacio = dataDarreraModificacio;
            this.dataBaixa = dataBaixa;
            LlistaEsperas_Id = llistaEsperas_Id;
        }

        public LlibreDTO(Llibre l) {
            ISBN = l.ISBN;
            Titol = l.Titol;
            this.numPagines = l.numPagines;
            this.disponible = l.disponible;
            this.editorial = l.editorial;
            dataIntroduccio = l.dataIntroduccio;
            dataDarreraModificacio = l.dataDarreraModificacio;
            dataBaixa = l.dataBaixa;
            LlistaEsperas_Id = l.LlistaEsperas_Id;
        }

        public LlibreDTO(DataGridViewCellCollection row) {
            this.ISBN = (int) row["ISBN"].Value;
            this.Titol = (string) row["Titol"].Value;
            this.numPagines = (int) row["numPagines"].Value;
            this.disponible = (bool) row["disponible"].Value;
            this.editorial = (string) row["editorial"].Value;
            this.dataIntroduccio = (DateTime) row["dataIntroduccio"].Value;
            this.dataDarreraModificacio = (DateTime) row["dataDarreraModificacio"].Value;
            this.dataBaixa = (DateTime) row["dataBaixa"].Value;
        }


    }
}
