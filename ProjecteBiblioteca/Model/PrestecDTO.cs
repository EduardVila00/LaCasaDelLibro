using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model {
    class PrestecDTO {
        public int Id { get; set; }
        public int IdCopia { get; set; }
        public DateTime dataInici { get; set; }
        public int Sancios_Id { get; set; }

        public PrestecDTO(int id, int idCopia, DateTime dataInici, int sancios_Id) {
            Id = id;
            IdCopia = idCopia;
            this.dataInici = dataInici;
            Sancios_Id = sancios_Id;
        }

        public PrestecDTO(Prestec p) {
            this.Id = p.Id;
            this.IdCopia = p.IdCopia;
            this.dataInici = p.dataInici;
            this.Sancios_Id = p.Sancios_Id;
        }
        public PrestecDTO(DataGridViewCellCollection row) {
            this.Id = (int) row["Id"].Value;
            this.IdCopia = (int) row["IdCopia"].Value;
            this.dataInici = (DateTime) row["dataInici"].Value;
            this.Sancios_Id = (int) row["Sancios_Id"].Value;

        }
    }
}
