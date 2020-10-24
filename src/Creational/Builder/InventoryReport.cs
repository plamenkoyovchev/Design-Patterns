using System.Text;

namespace Builder
{
    public class InventoryReport
    {
        public string TitleSection { get; set; }

        public string DimensionSection { get; set; }

        public string LogisticSection { get; set; }

        public string Debug()
        {
            return new StringBuilder()
                        .AppendLine(TitleSection)
                        .AppendLine(DimensionSection)
                        .AppendLine(LogisticSection)
                        .ToString();
        }
    }
}