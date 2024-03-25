namespace Прима
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> visited = new List<int>();
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] unvisited = new int[n, n];
            Console.WriteLine("Если ребро существует, то введите его вес,если нет,то 0");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Строка-" + (i + 1) + " " + "Столбец-" + (j + 1));
                    unvisited[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Random rnd = new Random();
            int value = rnd.Next(0, n);
            visited.Add(value);
            int result = 0;
            int min = 10000;
            int column = 0;
            while (visited.Count < n - 1)
            {
                for (int i = 0; i < visited.Count; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if ((unvisited[visited[i], j] < min) && (unvisited[visited[i], j] != 0) && !visited.Contains(j))
                        {
                            min = unvisited[value, j];
                            column = j;
                        }
                        unvisited[value, j] = 0;
                    }
                }
                result += min;
                visited.Add(column);
            }
            Console.WriteLine("Вес минимального остовного дерева:"+result);
            for (int i = 0; i < n; i++) 
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(unvisited[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
