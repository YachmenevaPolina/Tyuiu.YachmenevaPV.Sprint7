using System.Text;

namespace Tyuiu.YachmenevaPV.Sprint7.Project.V5.Lib
{
    public class DataService
    {
        public string[,] LoadFromDataFile(string path)
        {
            string[] lines;

            //кодировка
            try
            {
                lines = File.ReadAllLines(path, Encoding.UTF8);

                if (lines.Any(l => l.Contains("�")))
                    throw new Exception();
            }
            catch
            {
                lines = File.ReadAllLines(path, Encoding.GetEncoding(1251));
            }

            // разделитель
            char separator = lines[0].Contains(';') ? ';' : ',';

            int rows = lines.Length;
            int columns = lines[0].Split(separator).Length;

            string[,] data = new string[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(separator);

                for (int j = 0; j < columns; j++)
                {
                    data[i, j] = values[j];
                }
            }

            return data;
        }

        public double CalculateSum(double[] values)
        {
            return Math.Round(values.Sum(), 2);
        }

        public double CalculateAverage(double[] values, int visibleRowCount)
        {
            if (visibleRowCount == 0) return 0;
            return Math.Round(values.Sum() / visibleRowCount, 2);
        }

        public double FindMinimumValue(double[] values)
        {
            return values.Min();
        }

        public double FindMaximumValue(double[] values)
        {
            return values.Max();
        }
    }
}

