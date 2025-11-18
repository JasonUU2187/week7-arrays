internal class Program
{
    private static void Main(string[] args)
    {
        List<string> months = new List<string>();
        months.Add("January");
        months.Add("February");
        months.Add("March");
        months.Add("April");
        months.Add("May");
        months.Add("June");
        months.Add("July");
        months.Add("August");
        months.Add("September");
        months.Add("October");
        months.Add("November");
        months.Add("December");

        foreach (string month in months)
        {
            Console.WriteLine(month);
        }

        string[] strings = months.ToArray();

        Console.WriteLine($"There are " + months.Count + " in the year");

        for (int a = 0; a < months.Count; a++)
        {

            if (months[a] == "September" || months[a] == "November")
            {
                months.Remove(months[a]);
            }
        }
        Console.WriteLine($"There are " + months.Count + " in the year");

        string monthToFind = "December";
        int index = 0;
        for (int b = 0; b < months.Count; b++)
        {
            if(months[b] == monthToFind)
            {
                index = b;
                Console.WriteLine($"December is indexed at " + index + " in the array.");
                break;
            } else
            {
                index = -1;
            }
        }

        
    }
}