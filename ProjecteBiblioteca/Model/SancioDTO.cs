using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model {
    class SancioDTO {
        public int Id { get; set; }
        public DateTime dataSancio{ get; set; }
        public int idPrestec { get; set; }
        public int Copias_Id { get; set; }

        public SancioDTO(int id, DateTime dataSancio, int idPrestec, int copias_Id) {
            Id = id;
            this.dataSancio = dataSancio;
            this.idPrestec = idPrestec;
            Copias_Id = copias_Id;
        }

        public SancioDTO(Sancio s) {
            Id = s.Id;
            this.dataSancio = s.dataSancio;
            this.idPrestec = s.idPrestec;
            Copias_Id = s.Copias_Id;
        }

        public SancioDTO(DataGridViewCellCollection row) {
            this.Id = (int) row["Id"].Value;
            this.dataSancio = (DateTime) row["dataSancio"].Value;
            this.idPrestec = (int) row["idPrestec"].Value;
            this.Copias_Id = (int) row["Copias_Id"].Value;

        }
    }
}
