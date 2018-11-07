using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model {
    public class AutorDTO {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Cognoms { get; set; }
        public DateTime dataIntroduccio { get; set; }
        public DateTime dataDarreraModificacio { get; set; }
        public DateTime? dataBaixa { get; set; }

        public AutorDTO(int id, string nom, string cognom, DateTime dataintroduccio, DateTime datadarreramodificacio) {
            this.Id = id;
            this.Nom = nom;
            this.Cognoms = cognom;
            this.dataIntroduccio = dataintroduccio;
            this.dataDarreraModificacio = datadarreramodificacio;
            this.dataBaixa = null;
        }
        public AutorDTO(Autor a) {
            this.Id = a.Id;
            this.Nom = a.nom;
            this.Cognoms = a.cognoms;
            this.dataIntroduccio = a.dataIntroduccio;
            this.dataDarreraModificacio = a.dataDarreraModificacio;
            dataBaixa = a.dataBaixa;

        }
        public AutorDTO(DataGridViewCellCollection row) {
            this.Id = (int) row["Id"].Value;
            this.Nom = (string) row["nom"].Value;
            this.Cognoms = (string) row["cognoms"].Value;
            this.dataIntroduccio = (DateTime) row["dataIntroduccio"].Value;
            this.dataDarreraModificacio = (DateTime) row["dataDarreraModificacio"].Value;
            this.dataBaixa = (DateTime?) row["dataBaixa"].Value;
        }
    }
}
