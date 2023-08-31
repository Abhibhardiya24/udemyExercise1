class udemyExercise1
{
    static void Main()
    {
        int i;
        int j;
        for (i = 1; i <= 3; i++)
        {
            for (j = 1; j <= 10; j++)
            {

                if (j == 5 || j == 6)
                {
                    continue;
                }
              System.Console.Write(j+" ");
            }
                System.Console.WriteLine();
        }
            for(i=1;i<=4;i++)
        {
            for(j=10;j>=1;j--)
            {
                if (i == 3)
                {
                    if (j == 2 || j == 1)
                    {
                        continue;
                    }
                }
                System.Console.Write(j+" ");
            }
            System.Console.WriteLine();
        }
            for(i=1;i<=1;i++)
        {
            for(j=1;j<=10;j++)
            {
                if(j==8)
                {
                    continue;
                }
                System.Console.Write(j+" ");
            }
            System.Console.WriteLine();
        }
        System.Console.ReadKey();
        
    }
}
