using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model {
    class LlistaEsperaDTO {
        public int Id { get; set; }
        public int posicio { get; set; }
        public int idLlibre { get; set; }

        public LlistaEsperaDTO(int id, int posicio, int idLlibre) {
            Id = id;
            this.posicio = posicio;
            this.idLlibre = idLlibre;
        }

        public LlistaEsperaDTO(LlistaEspera llistaEspera) {
            this.Id = llistaEspera.Id;
            this.posicio = llistaEspera.posicio;
            this.idLlibre = llistaEspera.idLlibre;
        }
        public LlistaEsperaDTO(DataGridViewCellCollection row) {
            this.Id = (int) row["Id"].Value;
            this.posicio = (int) row["posicio"].Value;
            this.idLlibre = (int) row["idLlibre"].Value;
        }
    }
}
