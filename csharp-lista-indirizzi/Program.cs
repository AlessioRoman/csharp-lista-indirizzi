using address;

List<Address> addresses = new();
try
{
    StreamReader file = File.OpenText("C:\\Users\\Utente\\source\\repos\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\addresses.csv");
    int lineCounter = 0;

    while (!file.EndOfStream)
    {
        string currentLine = file.ReadLine();
        lineCounter++;

        if (lineCounter > 1 && currentLine != null)
        {
            string[] processedInfo = currentLine.Split(',');
            if (processedInfo.Length != 6)
            {
                Console.WriteLine("La riga " + lineCounter + " non rispetta lo standard!");
            }
            else
            {
                try
                {
                    int zipCode = int.Parse(processedInfo[5]);
                    Address newAddress = new(processedInfo[0], processedInfo[1], processedInfo[2], processedInfo[3], processedInfo[4], zipCode);
                    addresses.Add(newAddress);
                } catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }

            }
        }
    }
}
catch (Exception e)
{
    Console.WriteLine($"Error: {e.Message}");
}



foreach (Address address in addresses)
{
    Console.WriteLine(address.ToString());
}