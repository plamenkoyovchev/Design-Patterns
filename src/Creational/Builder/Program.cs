﻿using System;
using System.Collections.Generic;
using Builder.Builders;

namespace Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            var furnitureItems = new List<FurnitureItem>()
            {
                new FurnitureItem("Couch", 55.5m, 22.4, 20, 35),
                new FurnitureItem("Nightstand", 25m, 12.4, 20, 10),
                new FurnitureItem("Wardrobe", 60m, 100, 65, 20)
            };

            var inventoryBuilder = new InventoryReportBuilder(furnitureItems);
            var director = new InventoryReportBuildDirector(inventoryBuilder);

            director.BuildReport();
            var inventoryReport = inventoryBuilder.GetInventoryReport();

            Console.WriteLine(inventoryReport.Debug());
        }
    }
}
