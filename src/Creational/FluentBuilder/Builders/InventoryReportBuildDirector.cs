using System;

namespace FluentBuilder.Builders
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
            this.builder
                    .AddTitle()
                    .AddDimensions()
                    .AddLogistics(DateTime.Now);
        }
    }
}