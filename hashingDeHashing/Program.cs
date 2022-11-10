bool run = true;
while (run)
{
    Console.WriteLine("Vælg funktion: | 1 = Compute MAC | 2 = Verify MAC| 0 = Exit");
    string function = Console.ReadLine();

    if (function == "1")
    {
        Console.WriteLine("Vælg algoritme: | 1 = SHA 1 (CSP) | 2 = SHA 1 - (Managed) | 3 = SHA MD5 (CSP) | 4 = SHA MD5 (Managed) | 5 = SHA 256 (CSP) | 6 = SHA 256 (Managed) | 7 = SHA 384 (CSP) | 8 =SHA 384 (Managed) | 9 = SHA 512 (CSP) | 10 = SHA 512 (Managed) |");
        string? algo = Console.ReadLine();
        Console.WriteLine("Indtast den hemmelige nøgle");
        string? key = Console.ReadLine();
        Console.WriteLine("Indtast den hemmelige tekst som skal hashes");
        string? message = Console.ReadLine();
        Console.WriteLine("MAC hex:");
        Console.WriteLine(hashingDeHashing.Computer.ComputeMACHex(algo, key, message));
        Console.WriteLine("MAC ASCII:");
        Console.WriteLine(hashingDeHashing.Computer.ComputeASCII(algo, key, message));
        Console.WriteLine();
        Console.WriteLine("Tryk på en tast for at fortsætte");
        Console.ReadKey();
        Console.Clear();
    }
    if (function == "2")
    {
        Console.WriteLine("Vælg algoritme: | 1 = SHA 1 (CSP) | 2 = SHA 1 - (Managed) | 3 = SHA MD5 (CSP) | 4 = SHA MD5 (Managed) | 5 = SHA 256 (CSP) | 6 = SHA 256 (Managed) | 7 = SHA 384 (CSP) | 8 =SHA 384 (Managed) | 9 = SHA 512 (CSP) | 10 = SHA 512 (Managed) |");
        string? algo = Console.ReadLine();
        Console.WriteLine("Indtast den hemmelige nøgle");
        string? key = Console.ReadLine();
        Console.WriteLine("Indtast den hemmelige tekst som skal verificeres");
        string? message = Console.ReadLine();
        Console.WriteLine("Indtast Hash");
        string? hashInput = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine(hashingDeHashing.Verifier.VerifyMAC(algo, key, message, hashInput));
        Console.WriteLine();
        Console.WriteLine("Tryk på en tast for at fortsætte");
        Console.ReadKey();
        Console.Clear();
    }

}


