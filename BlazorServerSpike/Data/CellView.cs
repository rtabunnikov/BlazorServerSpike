using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerSpike.Data {
    public enum CellValueType {
        Empty,
        Number,
        Text,
        Bool,
        Error
    }

    public class CellView {
        static readonly CellView empty = new CellView() {
            ValueType = CellValueType.Empty,
            NumericValue = 0,
            TextValue = null
        };

        public CellValueType ValueType { get; set; }
        public double NumericValue { get; set; }
        public string TextValue { get; set; }

        public static CellView MakeText(string value) => new CellView() {
            ValueType = CellValueType.Text,
            NumericValue = 0,
            TextValue = value
        };

        public static CellView MakeNumeric(double value) => new CellView() {
            ValueType = CellValueType.Number,
            NumericValue = value,
            TextValue = null
        };

        public static CellView MakeBool(bool value) => new CellView() {
            ValueType = CellValueType.Bool,
            NumericValue = value ? 1 : 0,
            TextValue = null
        };

        public static CellView MakeError(string value) => new CellView() {
            ValueType = CellValueType.Error,
            NumericValue = 0,
            TextValue = value
        };

        public static CellView MakeEmpty() => empty;

        public string GetDisplayText() => ValueType switch {
            CellValueType.Number => NumericValue.ToString("G3"),
            CellValueType.Text => TextValue ?? string.Empty,
            CellValueType.Bool => NumericValue != 0 ? "TRUE" : "FALSE",
            CellValueType.Error => TextValue ?? string.Empty,
            _ => string.Empty
        };

        public string GetClassList() => ValueType switch {
            CellValueType.Number => "cell cell-right",
            CellValueType.Bool => "cell cell-ctr",
            CellValueType.Error => "cell cell-ctr",
            _ => "cell cell-left"
        };
    }
}
