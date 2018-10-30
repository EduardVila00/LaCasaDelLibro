using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model {
    class CopiaDTO {
        public int Id { get; set; }
        public bool disponible { get; set; }
        public DateTime dataIntroduccio { get; set; }
        public DateTime dataDarreraModificacio { get; set; }
        public DateTime? dataBaixa { get; set; }
        public string llibre_ISBN { get; set; }

        public CopiaDTO(int id, bool disponible, DateTime dataintroduccio, DateTime datadarreramodificacio, string llibre_isbn) {
            this.Id = id;
            this.disponible = disponible;
            this.dataIntroduccio = dataintroduccio;
            this.dataDarreraModificacio = datadarreramodificacio;
            this.dataBaixa = null;
            this.llibre_ISBN = llibre_isbn;
        }
        public CopiaDTO(Copia c) {
            this.Id = c.Id;
            this.disponible = c.disponible;
            this.dataIntroduccio = c.dataIntroduccio;
            this.dataDarreraModificacio = c.dataDarreraModificacio;
            this.dataBaixa = c.dataBaixa;
            this.llibre_ISBN = c.LlibreIsbn;
        }
        public CopiaDTO(DataGridViewCellCollection row) {
            this.Id = (int) row["Id"].Value;
            this.disponible = (bool) row["disponible"].Value;
            this.dataIntroduccio = (DateTime) row["dataIntroduccio"].Value;
            this.dataDarreraModificacio = (DateTime) row["dataDarreraModificacio"].Value;
            this.dataBaixa = (DateTime) row["dataBaixa"].Value;
            this.llibre_ISBN = (string) row["LlibreIsbn"].Value;

        }
    }


}
