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
            var carBuilder = new ReadyCarBuilder();

            var director = new SportCarDirector(carBuilder);

            director.Construct();
            var car = carBuilder.GetCar();

            Console.WriteLine(car);
            Console.ReadLine();
        }
        
    }

    public class ReadyCar
    {
        public List<string> CarParts = new List<string>();
    }

    public interface ICarBuilder
    {
        void BuildA();
        void BuildB();
        void BuildC();
        ReadyCar GetCar();
    }

    public class ReadyCarBuilder : ICarBuilder
    {
        private ReadyCar Car = new ReadyCar();
        public void BuildA()
        {
            Car.CarParts.Add("Added A");
        }

        public void BuildB()
        {
            Car.CarParts.Add("Added B");
        }

        public void BuildC()
        {
            Car.CarParts.Add("Added C");
        }

        public ReadyCar GetCar()
        {
            return Car;
        }
    }

    public interface ICarDirector
    {
        void Construct();
    }
    
    public class SportCarDirector:ICarDirector
    {
        private ICarBuilder _builder { get; }
        public SportCarDirector(ICarBuilder builder)
        {
            _builder = builder;
        }
        public void Construct()
        {
                _builder.BuildC();
                _builder.BuildA();
                _builder.BuildB();
        }
    }

}
