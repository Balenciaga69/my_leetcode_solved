namespace Csharp.Done
{
    public class S0733FloodFill
    {
        /// <summary>
        /// 運行.
        /// </summary>
        public void Run()
        {
            int[][] image = new int[][] { new int[] { 1, 1, 1 }, new int[] { 1, 1, 0 }, new int[] { 1, 0, 1 }, };
            var reslut = this.FloodFill(image, 1, 1, 2);
            Console.WriteLine(reslut);
        }

        public int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            int m = image.Length;
            int n = image[0].Length;
            int originalColor = image[sr][sc];

            var quque = new Queue<(int, int)>();
            var visited = new HashSet<(int, int)>();

            quque.Enqueue((sr, sc));
            visited.Add((sr, sc));

            while (quque.Count > 0)
            {
                var (x, y) = quque.Dequeue();
                image[x][y] = color;

                // 向右
                if (this.ShouldVisit(x + 1, y, m, n, originalColor, image, visited))
                {
                    quque.Enqueue((x + 1, y));
                    visited.Add((x + 1, y));
                }

                // 向左
                if (this.ShouldVisit(x - 1, y, m, n, originalColor, image, visited))
                {
                    quque.Enqueue((x - 1, y));
                    visited.Add((x - 1, y));
                }

                // 向上
                if (this.ShouldVisit(x, y - 1, m, n, originalColor, image, visited))
                {
                    quque.Enqueue((x, y - 1));
                    visited.Add((x, y - 1));
                }

                // 向下
                if (this.ShouldVisit(x, y + 1, m, n, originalColor, image, visited))
                {
                    quque.Enqueue((x, y + 1));
                    visited.Add((x, y + 1));
                }
            }

            return image;
        }

        // 判別是否該走訪該節點
        public bool ShouldVisit(int x, int y, int m, int n, int originalColor, int[][] image, HashSet<(int, int)> visited)
        {
            bool isInImage = x < m && y < n && x >= 0 && y >= 0;

            // 是否還在圖片內 且 尚未被走訪 且 是指定顏色
            return isInImage && !visited.Contains((x, y)) && image[x][y] == originalColor;
        }
    }
}
