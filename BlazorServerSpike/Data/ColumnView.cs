using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerSpike.Data {
    public class ColumnView {
        public string Header { get; set; }
        public int Width { get; set; } = 64;
        public bool IsSelected { get; set; }

        public string GetInlineStyle() => $"width: {Width}px";
        public string GetClassList() => IsSelected ? "column-header column-header-selected" : "column-header";
    }
}
