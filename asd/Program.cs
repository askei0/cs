//https://progalap.elte.hu/specifikacio/v1/?uuid=f9dab716-655b-44f4-ac0d-579f3e7d6cc4
//https://progalap.elte.hu/stuki/v1/?uuid=c7c60fb6-578e-43f9-9ed3-6f46fb9db378
using System;
using System.Collections.Generic;
using System.Linq;

public record BusStation(string Town, int Arrival, int Departure);

class Program
{
    static void Main()
    {
        if (!int.TryParse(Console.ReadLine(), out int p)) return;

        var stations = new List<BusStation>();

        for (int i = 0; i < p; i++)
        {
            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < 3) continue;

            int.TryParse(parts[1], out int arrival);
            int.TryParse(parts[2], out int departure);

            stations.Add(new BusStation(parts[0], arrival, departure));
        }

        bool exists = stations.Any(s => s.Town == "Szekszard" && s.Arrival == -1);

        Console.WriteLine(exists ? "YES" : "NO");
    }
}
