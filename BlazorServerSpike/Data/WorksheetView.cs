using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerSpike.Data {
    public class WorksheetView {
        public string Name { get; set; }
        public List<ColumnView> Columns { get; } = new List<ColumnView>();
        public List<RowView> Rows { get; } = new List<RowView>();
    }
}
