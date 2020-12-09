using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerSpike.Data {
    public class WorksheetViewService {
        public Task<WorksheetView> GetWorksheetViewAsync() {
            var result = new WorksheetView() { Name = "Sheet1" };
            CreateColumns(result);
            CreateRows(result);
            return Task.FromResult(result);
        }

        void CreateColumns(WorksheetView view) {
            view.Columns.Add(new ColumnView() { Header = "A", Width = 200 });
            view.Columns.Add(new ColumnView() { Header = "B" });
            view.Columns.Add(new ColumnView() { Header = "C", Width = 100 });
            view.Columns.Add(new ColumnView() { Header = "D" });
            view.Columns.Add(new ColumnView() { Header = "E" });
            view.Columns.Add(new ColumnView() { Header = "F", Width = 80 });
            view.Columns.Add(new ColumnView() { Header = "G", Width = 120 });
            view.Columns.Add(new ColumnView() { Header = "H" });
        }

        void CreateRows(WorksheetView view) {
            for (int i = 0; i < 30; i++) {
                var row = new RowView() { Header = $"{i + 1}" };
                row.Height = 20;
                row.Cells.Add(CellView.MakeText($"Sample { i + 1}")); // A
                row.Cells.Add(CellView.MakeNumeric(i + 1)); // B
                row.Cells.Add(CellView.MakeBool(i % 2 != 0)); // C
                row.Cells.Add(CellView.MakeNumeric(1.0 / (i + 1))); // D
                row.Cells.Add(CellView.MakeEmpty()); // E
                row.Cells.Add(CellView.MakeError(i % 2 != 0 ? "#REF!" : "#N/A")); // F
                row.Cells.Add(CellView.MakeText($"text { i + 1}")); // G
                row.Cells.Add(CellView.MakeEmpty()); // H
                view.Rows.Add(row);
            }
        }
    }
}
