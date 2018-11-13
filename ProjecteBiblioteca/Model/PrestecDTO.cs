using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model {
    public class PrestecDTO {
        public int Id { get; set; }
        public int IdCopia { get; set; }
        public DateTime dataInici { get; set; }
        public DateTime dataFinal { get; set; }
        public DateTime? dataRetorn { get; set; }

        public PrestecDTO(int id, int idCopia, DateTime dataInici, DateTime dataFinal, DateTime? dataRetorn) {
            Id = id;
            IdCopia = idCopia;
            this.dataInici = dataInici;
            this.dataFinal = dataFinal;
            this.dataRetorn = dataRetorn;
        }

        public PrestecDTO(Prestec p) {
            this.Id = p.Id;
            this.IdCopia = p.CopiaId;
            this.dataInici = p.dataInici;
            this.dataFinal = p.dataFinal;
            this.dataRetorn = p.dataRetorn;
        }
        public PrestecDTO(DataGridViewCellCollection row) {
            this.Id = (int) row["Id"].Value;
            this.IdCopia = (int) row["IdCopia"].Value;
            this.dataInici = (DateTime) row["dataInici"].Value;
            this.dataFinal = (DateTime) row["dataFinal"].Value;
            this.dataRetorn = (DateTime) row["dataRetorn"].Value;

        }
    }
}
