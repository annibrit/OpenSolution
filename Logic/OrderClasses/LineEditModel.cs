using System;
using Open.Archetypes.OrderClasses;

namespace Open.Logic.OrderClasses
{
    public class LineEditModel
    {
        public LineEditModel() { }
        public LineEditModel(OrderLine line)
        {
            UniqueId = line.UniqueId;
            ExpectedDeliveryDate = line.Valid.From;
            NumberOrdered = line.NumberOrdered;
            Comment = line.Comment;
        }
        public LineEditModel(TaxOnLine line)
        {
            UniqueId = line.UniqueId;
            ExpectedDeliveryDate = line.Valid.From;
            Comment = line.Comment;
        }
        public LineEditModel(ChargeLine line)
        {
            UniqueId = line.UniqueId;
            ExpectedDeliveryDate = line.Valid.From;
            Comment = line.Comment;
        }

        public string UniqueId { get; set; } = string.Empty;
        public DateTime ExpectedDeliveryDate { get; set; }
        public int NumberOrdered { get; set; }
        public string Comment { get; set; } = string.Empty;

        public void Update(OrderLine line)
        {
            line.Comment = Comment;
            line.NumberOrdered = NumberOrdered;
            line.Valid.From = ExpectedDeliveryDate;
        }

        public void Update(ChargeLine line)
        {
            line.Comment = Comment;
            line.Valid.From = ExpectedDeliveryDate;
        }

        public void Update(TaxOnLine line)
        {
            line.Comment = Comment;
            line.Valid.From = ExpectedDeliveryDate;
        }
    }
}
