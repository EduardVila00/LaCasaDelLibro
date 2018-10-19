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
        public DateTime DataIntroduccio { get; set; }
        public DateTime DataDarreraModificacio { get; set; }
        public DateTime DataBaixa { get; set; }

        public AutorDTO(int id, string nom, string cognom, DateTime dataintroduccio, DateTime datadarreramodificacio, DateTime databaixa) {
            this.Id = id;
            this.Nom = nom;
            this.Cognom = cognom;
            this.DataIntroduccio = dataintroduccio;
            this.DataDarreraModificacio = datadarreramodificacio;
            this.DataBaixa = databaixa;
        }
        public AutorDTO(Autor a) {
            this.Id = a.Id;
            this.Nom = a.Nom;
            this.Cognom = a.Cognom;
            this.DataIntroduccio = a.dataIntroduccio;
            this.DataDarreraModificacio = a.dataDarreraModificacio;
            this.DataBaixa = a.dataBaixa;

        }
        public AutorDTO(DataGridViewCellCollection row) {
            this.Id = (int) row["Id"].Value;
            this.Nom = (string) row["Nom"].Value;
            this.Cognom = (string) row["Cognom"].Value;
            this.DataIntroduccio = (DateTime) row["dataIntroduccio"].Value;
            this.DataDarreraModificacio = (DateTime) row["dataDarreraModificacio"].Value;
            this.DataBaixa = (DateTime) row["dataBaixa"].Value;
        }
    }
}
