using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerSpike.Data {
    public class RowView {
        public string Header { get; set; }
        public int Height { get; set; }
        public List<CellView> Cells { get; } = new List<CellView>();
    }
}
