namespace _3_by_3_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,,] myArray = new int[3, 3, 3]
            {
                { {3,0,1}, {0,1,6}, {1,5,0} },
                { {0,7,1}, {4,1,0}, {1,0,9} },
                { {0,8,1}, {0,1,0}, {1,2,0} }
            };

            int[,,] arrayTwo = new int[3, 3, 3]
            {
                { {4,0,1}, {5,1,0}, {1,4,0} },
                { {1,0,1}, {9,1,0}, {1,7,0} },
                { {0,2,1}, {7,1,0}, {1,6,2} }

            };
            int[,,] result = new int[3, 3, 3];

            for (int a = 0; a < myArray.GetLength(0); a++)
            {
                for (int b = 0; b < myArray.GetLength(1); b++)
                {
                    for (int c = 0; c < myArray.GetLength(2); c++)
                    {
                        result[a, b, c] += myArray[a, b, c] * arrayTwo[a,b, c];
                        Console.WriteLine(result[a, b, c]);
                    }
                }
            }


            Console.WriteLine("Hello, World");

        }
    }
}

        
    
