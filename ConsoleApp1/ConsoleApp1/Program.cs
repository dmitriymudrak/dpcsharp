using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var modernStyleFactory = new ModernStyleFactory();
            var resultChair = modernStyleFactory.CreateChair();
            var resultTable = modernStyleFactory.CreateTable();
        }
        
    }
    public abstract class Chair
    {

    }

    public class ModernStyleChair : Chair
    {

    }

    public class VictorianStyleChair : Chair
    {

    }

    public abstract class Table
    {

    }

    public class ModernStyleTable : Table
    {

    }

    public class VictorianStyleTable : Table
    {

    }
    
    public abstract class FurnitureFactory
    {
        public abstract Chair CreateChair();
        public abstract Table CreateTable();
    }

    public class ModernStyleFactory : FurnitureFactory
    {
        public override Chair CreateChair()
        {
            return new ModernStyleChair();
        }

        public override Table CreateTable()
        {
            return new ModernStyleTable();
        }
    }

    public class VictorianStyleFactory : FurnitureFactory
    {
        public override Chair CreateChair()
        {
            return new VictorianStyleChair();
        }

        public override Table CreateTable()
        {
            return new VictorianStyleTable();
        }
    }


}
