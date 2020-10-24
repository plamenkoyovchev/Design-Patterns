using System;

namespace FluentBuilder.Builders
{
    public interface IFurnitureInventoryBuilder
    {
        IFurnitureInventoryBuilder AddTitle();

        IFurnitureInventoryBuilder AddDimensions();

        IFurnitureInventoryBuilder AddLogistics(DateTime date);

        InventoryReport GetInventoryReport();
    }
}