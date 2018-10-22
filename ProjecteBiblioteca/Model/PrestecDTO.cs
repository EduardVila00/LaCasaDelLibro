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
        public DateTime dataFinal { get; set; }
        public DateTime dataReal { get; set; }

        public PrestecDTO(int id, int idCopia, DateTime dataInici, int sancios_Id, DateTime dataFinal, DateTime dataReal) {
            Id = id;
            IdCopia = idCopia;
            this.dataInici = dataInici;
            this.dataFinal = dataFinal;
            this.dataReal = dataReal;
            Sancios_Id = sancios_Id;
        }

        public PrestecDTO(Prestecs p) {
            this.Id = p.Id;
            this.IdCopia = p.IdCopia;
            this.dataInici = p.dataInici;
            this.Sancios_Id = p.Sancios_Id;
            this.dataFinal = p.dataFinal;
            this.dataReal = p.dataReal;
        }
        public PrestecDTO(DataGridViewCellCollection row) {
            this.Id = (int) row["Id"].Value;
            this.IdCopia = (int) row["IdCopia"].Value;
            this.dataInici = (DateTime) row["dataInici"].Value;
            this.Sancios_Id = (int) row["Sancios_Id"].Value;
            this.dataReal = (DateTime) row["dataReal"].Value;
            this.dataFinal = (DateTime) row["dataFinal"].Value;

        }
    }
}
