using System;

namespace Builder.Builders
{
    public class InventoryReportBuildDirector
    {
        private IFurnitureInventoryBuilder builder;

        public InventoryReportBuildDirector(IFurnitureInventoryBuilder concreteBuilder)
        {
            this.builder = concreteBuilder;
        }

        public void BuildReport()
        {
            this.builder.AddTitle();
            this.builder.AddDimensions();
            this.builder.AddLogistics(DateTime.Now);
        }
    }
}