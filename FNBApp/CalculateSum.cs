using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FNBApp
{
    public class CalculateSum : Calculator
    {
        //Data members
        public int num3 { get; set; }

        //Constructor
        public CalculateSum(int x, int y, int z) : base(x, y)
        {
            this.num3 = z;
        }

        //override
        public int calculateThreeNum()
        {
            return base.calculateSum() + num3;
        }

        //Write to file input/output(IO)

        public void writeToFile(string path, string data)
        {
            path = @"E:\Banking\info.txt";
            data = num1 + " " + num2 + " " + num3 + " " + calculateThreeNum();
            File.AppendAllText(path, data + "\n");
        }
    }
}
