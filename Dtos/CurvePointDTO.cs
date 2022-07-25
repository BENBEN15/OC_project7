using System;

namespace WebApi.Dtos
{
    public class CurvePointDTO
    {
        // TODO: Map columns in data table CURVEPOINT with corresponding fields
        public int CurvePointId { get; set; }
        public byte? CurveId { get; set; }
        public DateTime? AsOfDate { get; set; }
        public double? Term { get; set; }
        public double? Value { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}