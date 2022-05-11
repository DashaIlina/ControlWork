public class task56
{
    static void Main(string[] args)
    {
        Console.WriteLine(" Введите количество элементов массива ");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] array = new string[n];
               
        

        FillArray(array);
        PrintArray(array);
        Console.WriteLine(" ");
        RewriteArray(array);
       

        void RewriteArray(string[] array)
        {
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                {
                    Console.Write(array[i]+ "\t");
                }
            }
            Console.WriteLine();
        }

        void FillArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToString(Console.ReadLine());
            }
            Console.WriteLine();
        }

        void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");

            }
            Console.WriteLine();
        }
    }
}
