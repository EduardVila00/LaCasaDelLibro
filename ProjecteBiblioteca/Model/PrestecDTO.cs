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

        public PrestecDTO(int id, int idCopia, DateTime dataInici) {
            Id = id;
            IdCopia = idCopia;
            this.dataInici = dataInici;
        }

        public PrestecDTO(Prestec p) {
            this.Id = p.Id;
            this.IdCopia = p.CopiaId;
            this.dataInici = p.dataInici;
        }
        public PrestecDTO(DataGridViewCellCollection row) {
            this.Id = (int) row["Id"].Value;
            this.IdCopia = (int) row["IdCopia"].Value;
            this.dataInici = (DateTime) row["dataInici"].Value;

        }
    }
}
