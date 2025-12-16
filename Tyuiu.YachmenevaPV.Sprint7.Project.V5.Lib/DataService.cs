namespace Tyuiu.YachmenevaPV.Sprint7.Project.V5.Lib
{
    public class DataService
    {
        public string[,] LoadFromDataFile(string path)
        {
            string[] lines = File.ReadAllLines(path);

            if (lines.Length == 0)
                return new string[0, 0];

            char separator = lines[0].Contains(';') ? ';' : ',';

            int columns = lines[0].Split(separator).Length;
            int rows = lines.Length;

            string[,] matrix = new string[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] parts = lines[i].Split(separator);

                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = j < parts.Length ? parts[j] : string.Empty;
                }
            }

            return matrix;
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
