using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model {
    class LlistaEsperaDTO {
        public int Id { get; set; }
        public int idSoci { get; set; }
        public string LlibreIsbn { get; set; }

        public LlistaEsperaDTO(int id, int idSoci, string LlibreIsbn) {
            Id = id;
            this.idSoci = idSoci;
            this.LlibreIsbn = LlibreIsbn;
        }

        public LlistaEsperaDTO(LlistaEspera llistaEspera) {
            this.Id = llistaEspera.Id;
            this.idSoci = llistaEspera.idSoci;
            this.LlibreIsbn = llistaEspera.LlibreIsbn;
        }
        public LlistaEsperaDTO(DataGridViewCellCollection row) {
            this.Id = (int) row["Id"].Value;
            this.idSoci = (int) row["idSoci"].Value;
            this.LlibreIsbn = (string) row["LlibreIsbn"].Value;
        }
    }
}
