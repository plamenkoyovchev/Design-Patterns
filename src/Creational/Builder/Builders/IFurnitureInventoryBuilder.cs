using System;

namespace Builder.Builders
{
    public interface IFurnitureInventoryBuilder
    {
        void AddTitle();

        void AddDimensions();

        void AddLogistics(DateTime date);

        InventoryReport GetInventoryReport();
    }
}