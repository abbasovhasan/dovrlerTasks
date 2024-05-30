/*namespace DovrlerTasks
{
    internal class Task1
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            DovrlerTasks.Task1.Task(num);
        }

        #region Task1
        public static void Task(int num)
        {
            int sum = 0;
            int counter = 0;
            int n = num;
            //123

            while (num > 0)
            {
                sum = sum + num % 10;
                num = num / 10;
                counter++;

            }
            Console.WriteLine("Ekrana yazilan ededin reqemlerinin cemi: " + sum + "-dir");
            Console.WriteLine("Ekrana yazilan eded " + counter + " reqemlidir");
        }

        #endregion
    }
}
*/