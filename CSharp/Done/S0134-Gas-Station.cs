namespace Csharp.Done
{
    public class S0134_Gas_Station
    {
        public void Execute()
        {
            var gas = new int[] { 1, 2, 3, 4, 5 };
            var cost = new int[] { 3, 4, 5, 1, 2 };
            var xxx = this.CanCompleteCircuit(gas, cost);
            Console.WriteLine(xxx);
        }

        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            // 油耗大於加油量 直接 -1
            if (cost.Sum() > gas.Sum())
            {
                return -1;
            }

            for (int i = 0; i < gas.Length; i++)
            {
                var remainingGas = 0;
                var earnedGas = 0;
                var j = i;
                while (true)
                {
                    // 加油中
                    remainingGas += gas[j];
                    earnedGas += gas[j];

                    // 到達下一站
                    remainingGas -= cost[j];
                    j = j + 1 >= gas.Length ? 0 : j + 1;
                    if (remainingGas < 0) break;
                    if (earnedGas == gas.Sum()) return i;
                }
            }

            return -1;
        }
    }
}
