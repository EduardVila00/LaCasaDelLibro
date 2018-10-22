using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model {
    class CopiaDTO {
        public int Id { get; set; }
        public int ISBN { get; set; }
        public DateTime dataIntroduccio { get; set; }
        public DateTime dataDarreraModificacio { get; set; }
        public DateTime dataBaixa { get; set; }
        public int llibre_ISBN { get; set; }

        public CopiaDTO(int id, int isbn, DateTime dataintroduccio, DateTime datadarreramodificacio, DateTime databaixa, int llibre_isbn) {
            this.Id = id;
            this.ISBN = isbn;
            this.dataIntroduccio = dataintroduccio;
            this.dataDarreraModificacio = datadarreramodificacio;
            this.dataBaixa = databaixa;
            this.llibre_ISBN = llibre_isbn;
        }
        public CopiaDTO(Copias c) {
            this.Id = c.Id;
            this.ISBN = c.ISBN;
            this.dataIntroduccio = c.dataIntroduccio;
            this.dataDarreraModificacio = c.dataDarreraModificacio;
            this.dataBaixa = c.dataBaixa;
            this.llibre_ISBN = c.Llibre_ISBN;
        }
        public CopiaDTO(DataGridViewCellCollection row) {
            this.Id = (int) row["Id"].Value;
            this.ISBN = (int) row["ISBN"].Value;
            this.dataIntroduccio = (DateTime) row["dataIntroduccio"].Value;
            this.dataDarreraModificacio = (DateTime) row["dataDarreraModificacio"].Value;
            this.dataBaixa = (DateTime) row["dataBaixa"].Value;
            this.llibre_ISBN = (int) row["Llibre_ISBN"].Value;

        }
    }

    
}
