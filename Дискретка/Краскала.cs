namespace Краскала
{
    internal class Program
    {
        class Kruskal
        {
            public int Weight;
            public int V1;
            public int V2;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> visited = new List<int>();
            List<Kruskal> unvisited = new List<Kruskal>();



            Console.WriteLine("Введите сначала веc, потом вершину 1, потом вершину 2:");
            string str = Console.ReadLine();


            while (str != "")
            {
                Kruskal kruskal = new Kruskal();
                kruskal.Weight = Convert.ToInt32(str);

                kruskal.V1 = Convert.ToInt32(Console.ReadLine());

                kruskal.V2 = Convert.ToInt32(Console.ReadLine());
                unvisited.Add(kruskal);

                str = Console.ReadLine();
            }
            unvisited.Sort();
            int result = 0;
            while (visited.Count < n - 1)
            {
                int min = 0;

                for (int i = 0; i < unvisited.Count; i++)
                {
                    if ((unvisited[i].Weight != 0) && (!visited.Contains(unvisited[i].V2) || !visited.Contains(unvisited[i].V1)))
                    {
                        if (visited.Contains(unvisited[i].V2))
                        {
                            visited.Add(unvisited[i].V1);
                        }
                        else if (visited.Contains(unvisited[i].V1))
                        {
                            visited.Add(unvisited[i].V2);
                        }
                        else
                        {
                            visited.Add(unvisited[i].V1);
                            visited.Add(unvisited[i].V2);
                        }
                        min = unvisited[i].Weight;

                    }
                    unvisited[i].Weight = 0;
                }
                result += min;

            }

            Console.WriteLine("Вес минимального остовного дерева: " + result);

            foreach (var edge in unvisited)
            {
                Console.WriteLine(edge.V1 + " " + edge.Weight + " " + edge.V2);
            }
        }
    }
}
