using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model {
    public class DiaNoHabilDTO {
        public int Id { get; set; }
        public DateTime data { get; set; }

        public DiaNoHabilDTO(int id, DateTime data) {
            Id = id;
            this.data = data;
        }
        public DiaNoHabilDTO(DiaNoHabil d) {
            Id = d.Id;
            this.data = d.data;
        }public DiaNoHabilDTO(DataGridViewCellCollection row) {
            Id = (int) row["Id"].Value;
            this.data = (DateTime) row["data"].Value;
        }

    }
}

