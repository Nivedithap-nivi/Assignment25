using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q17
{
    public class Computer
    {

        public string Processor { get; set; }
        public int RamSize { get; set; }
        public int HardDiskSize { get; set; }
        public int GraphicCard { get; set; }
    }

    public class Desktop : Computer
    {
        public int MonitorSize { get; set; }
        public int PowerSupplyVolt { get; set; }

        public double DesktopPriceCalculation()
        {
            int processorCost = GetProcessorCost(Processor);
            double desktopPrice = processorCost +
                                  (RamSize * 200) +
                                  (HardDiskSize * 1500) +
                                  (GraphicCard * 2500) +
                                  (MonitorSize * 250) +
                                  (PowerSupplyVolt * 20);

            return desktopPrice;
        }

        private int GetProcessorCost(string processor)
        {
            switch (processor)
            {
                case "i3": return 1500;
                case "i5": return 3000;
                case "i7": return 4500;
                default: return 0;
            }
        }
    }

    public class Laptop : Computer
    {
        public int DisplaySize { get; set; }
        public int BatteryVolt { get; set; }

        public double LaptopPriceCalculation()
        {
            int processorCost = GetProcessorCost(Processor);
            double laptopPrice = processorCost +
                                 (RamSize * 200) +
                                 (HardDiskSize * 1500) +
                                 (GraphicCard * 2500) +
                                 (DisplaySize * 250) +
                                 (BatteryVolt * 20);

            return laptopPrice;
        }

        private int GetProcessorCost(string processor)
        {
            switch (processor)
            {
                case "i3": return 2500;
                case "i5": return 5000;
                case "i7": return 6500;
                default: return 0;
            }
        }
    }
}

