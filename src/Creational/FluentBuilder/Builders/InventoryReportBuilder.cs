using System;
using System.Collections.Generic;
using System.Linq;

namespace FluentBuilder.Builders
{
    public class InventoryReportBuilder : IFurnitureInventoryBuilder
    {
        private InventoryReport report;

        public InventoryReportBuilder(IEnumerable<FurnitureItem> items)
        {
            this.Reset();
            this.Items = items;
        }

        IEnumerable<FurnitureItem> Items { get; }

        public IFurnitureInventoryBuilder AddDimensions()
        {
            var dimensions = string.Join(Environment.NewLine, Items.Select(i =>
            $"Product: {i.Name} \n Price: ${i.Price} \n Wd|H|Wg: {i.Width}|{i.Height}|{i.Weight}"));

            this.report.DimensionSection = dimensions;

            return this;
        }

        public IFurnitureInventoryBuilder AddLogistics(DateTime date)
        {
            this.report.LogisticSection = $"Here is the Logistics stuff, generated on {date}";

            return this;
        }

        public IFurnitureInventoryBuilder AddTitle()
        {
            this.report.TitleSection = "Report Title";

            return this;
        }

        public InventoryReport GetInventoryReport()
        {
            var finishedReport = this.report;
            this.report.Debug();

            this.Reset();

            return finishedReport;
        }

        public void Reset()
        {
            this.report = new InventoryReport();
        }
    }
}