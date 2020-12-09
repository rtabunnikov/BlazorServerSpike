using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerSpike.Data {
    public class RowView {
        public string Header { get; set; }
        public int Height { get; set; }
        public bool IsSelected { get; set; }
        public List<CellView> Cells { get; } = new List<CellView>();

        public string GetInlineStyle() => $"line-height: {Height}px";

        public string GetClassList() => IsSelected ? "row-header row-header-selected" : "row-header";
    }
}
