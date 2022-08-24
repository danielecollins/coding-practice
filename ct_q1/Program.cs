using System;

public class BookSale
{
    public static int NthLowestSelling(int[] sales, int n)
    {
        Dictionary<int, int> numSales = new Dictionary<int, int>();
        bool dictEmpty = true;

        foreach (int id in sales)
        {
            if (dictEmpty)
            {
                numSales.Add(id, 1);
                dictEmpty = false; 
            }
            else
            {
                foreach (KeyValuePair<int, int> numSale in numSales)
                {
                    if (numSale.Key == id)
                    {
                        numSales[numSale.Key] = numSale.Value + 1;
                    }
                    else
                    {
                        numSales.Add(id, 1);
                    }
                }
            }  
        }

        
        return 0;
    }

    public static void Main(string[] args)
    {
        int x = NthLowestSelling(new int[] { 5, 4, 3, 2, 1, 5, 4, 3, 2, 5, 4, 3, 5, 4, 5 }, 2);
        Console.WriteLine(x);
    }
}