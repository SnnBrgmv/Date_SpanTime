namespace DateSpanTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            //try 
            //{
            //    string input = Console.ReadLine();
            //    DateTime date = DateTime.ParseExact(input, "dd | MM | yyyy", null);
            //    Console.WriteLine(date.ToString("dd.MM.yyyy"));
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex) 
            //{ 
            //    Console.WriteLine(ex.Message); 
            //}
            //finally
            //{ 
            //    Console.WriteLine("Execute the finally block..."); 
            //}

            // Task 2
            try
            {
                string input = Console.ReadLine();
                DateTime date = DateTime.ParseExact(input, "dd/MM/yyyy", null);
                date = date.AddDays(30).AddHours(6).AddMinutes(17);
                Console.WriteLine(date);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Execute the finally block...");
            }
        }
    }
}