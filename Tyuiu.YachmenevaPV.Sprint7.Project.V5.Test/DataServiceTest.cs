using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.YachmenevaPV.Sprint7.Project.V5.Lib;

namespace Tyuiu.YachmenevaPV.Sprint7.Project.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateSum()
        {
            DataService ds = new DataService();
            double[] values = { 5, 10, 15, 20 };

            double wait = 50;
            double res = ds.CalculateSum(values);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckCalculateAverage()
        {
            DataService ds = new DataService();
            double[] values = { 10, 20, 30 };
            int visibleRowCount = 3;

            double wait = 20;
            double res = ds.CalculateAverage(values, visibleRowCount);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckMinimumValueCalculation()
        {
            DataService ds = new DataService();
            double[] values = { 3.5, 2.0, 5.1, 1.8, 4.9 };

            double wait = 1.8;
            double res = ds.FindMinimumValue(values);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckMaximumValueCalculation()
        {
            DataService ds = new DataService();
            double[] values = { 3.5, 2.0, 5.1, 1.8, 4.9 };

            double wait = 5.1;
            double res = ds.FindMaximumValue(values);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckLoadFromDataFile()
        {
            DataService ds = new DataService();

            string path = Path.GetTempFileName();

            File.WriteAllLines(path, new[]
            {
                "Код,Название,Цена",
                "1,Яблоки,120",
                "2,Груши,150"
            });

            string[,] result = ds.LoadFromDataFile(path);

            Assert.AreEqual(3, result.GetLength(0)); // строки
            Assert.AreEqual(3, result.GetLength(1)); // столбцы
            Assert.AreEqual("Яблоки", result[1, 1]);
        }
    }
}