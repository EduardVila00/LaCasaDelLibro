using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model {
    class SociDTO {
        public int Id { get; set; }
        public string nom { get; set; }
        public string cognom { get; set; }
        public DateTime dataIntroduccio { get; set; }
        public DateTime dataDarreraModificacio { get; set; }
        public DateTime? dataBaixa { get; set; }

        public SociDTO(int id, string nom, string cognom, DateTime dataIntroduccio, DateTime dataDarreraModificacio) {
            Id = id;
            this.nom = nom;
            this.cognom = cognom;
            this.dataIntroduccio = dataIntroduccio;
            this.dataDarreraModificacio = dataDarreraModificacio;
            this.dataBaixa = null;
        }

        public SociDTO(Soci s) {
            Id = s.Id;
            this.nom = s.nom;
            this.cognom = s.cognoms;
            this.dataIntroduccio = s.dataIntroduccio;
            this.dataDarreraModificacio = s.dataDarreraModificacio;
            this.dataBaixa = null;
        }

        public SociDTO(DataGridViewCellCollection row) {
            this.Id = (int) row["Id"].Value;
            this.nom = (string) row["nom"].Value;
            this.nom = (string) row["cognom"].Value;
            this.dataIntroduccio = (DateTime) row["dataIntroduccio"].Value;
            this.dataDarreraModificacio = (DateTime) row["dataDarreraModificacio"].Value;
            this.dataBaixa = (DateTime) row["dataBaixa"].Value;


        }
    }
}
