namespace _12
{
    static class Divider
    {
        
        public static void Divide(string x, string y)
        {
            try
            {
                int xint = Convert.ToInt32(x);
                int yint = Convert.ToInt32(y);
                int result = xint / yint;
                Console.WriteLine($"Результат:{result}");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("х не является числом");
            }
            catch (System.DivideByZeroException)
            {
                Console.WriteLine("Нельзя делить на ноль");
            }


         }
            

                
        }
    
}
