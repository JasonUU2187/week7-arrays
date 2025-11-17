List<string> months = new List<string>();
months.Add("January");
months.Add("February");
months.Add("March");
months.Add("April");
months.Add("May");
months.Add("June");
months.Add("July");
months.Add("August");
months.Add("October");
months.Add("December");

foreach (string month in months)
{
    Console.WriteLine(month);
}

string[] strings = months.ToArray();

Console.WriteLine(strings);