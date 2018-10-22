using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model {
    class AutorDTO {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Cognom { get; set; }
        public DateTime dataIntroduccio { get; set; }
        public DateTime dataDarreraModificacio { get; set; }
        public DateTime dataBaixa { get; set; }

        public AutorDTO(int id, string nom, string cognom, DateTime dataintroduccio, DateTime datadarreramodificacio, DateTime databaixa) {
            this.Id = id;
            this.Nom = nom;
            this.Cognom = cognom;
            this.dataIntroduccio = dataintroduccio;
            this.dataDarreraModificacio = datadarreramodificacio;
            this.dataBaixa = databaixa;
        }
        public AutorDTO(Autors a) {
            this.Id = a.Id;
            this.Nom = a.Nom;
            this.Cognom = a.Cognom;
            this.dataIntroduccio = a.dataIntroduccio;
            this.dataDarreraModificacio = a.dataDarreraModificacio;
            this.dataBaixa = a.dataBaixa;

        }
        public AutorDTO(DataGridViewCellCollection row) {
            this.Id = (int) row["Id"].Value;
            this.Nom = (string) row["Nom"].Value;
            this.Cognom = (string) row["Cognom"].Value;
            this.dataIntroduccio = (DateTime) row["dataIntroduccio"].Value;
            this.dataDarreraModificacio = (DateTime) row["dataDarreraModificacio"].Value;
            this.dataBaixa = (DateTime) row["dataBaixa"].Value;
        }
    }
}
