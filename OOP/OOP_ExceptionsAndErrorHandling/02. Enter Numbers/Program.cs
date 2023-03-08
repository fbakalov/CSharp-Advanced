Console.WriteLine(string.Join(", ", ReadNumber(1, 100))); 

List<int> ReadNumber(int start, int end)
{
    List<int> result = new();
    int count = 0;
	while (count != 10)
	{
		try
		{
            int currentNum = int.Parse(Console.ReadLine());

            if (currentNum <= start || currentNum >= end)
            {
                throw new ArgumentException($"Your number is not in range ({currentNum} - {end}!)");
            }
            else
            {
                result.Add(currentNum);
                count++;
            }    
        }
		catch (FormatException ex)
		{
			Console.WriteLine("Invalid Number!");
		}
        catch(ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
	}

    return result;
}