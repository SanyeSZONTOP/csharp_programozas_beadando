using System;
using System.Collections.Generic;

namespace Beadandó_SnusszWebShop
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Snussz> inventory = new List<Snussz>()
            {
                #region Snusszok feltoltese
                
                new Snussz("Velo", "Freeze", 16),
                new Snussz("Velo", "Ice Cool", 14),
                new Snussz("Velo", "Berry Frost", 10),
                new Snussz("ZYN", "Cool Mint", 11), 
                new Snussz("ZYN", "Citrus", 9), 
                new Snussz("ZYN", "Espresso", 15),
                new Snussz("Siberia", "Red Extremely Strong", 43), 
                new Snussz("Siberia", "Brown", 43),
                new Snussz("Siberia", "Blue", 24),
                new Snussz("Pablo", "Ice Cold", 30), 
                new Snussz("Pablo", "Red", 30),
                new Snussz("Pablo", "Banana Ice", 30),
                new Snussz("Killa", "Cold Mint", 16), 
                new Snussz("Killa", "Melon", 16), 
                new Snussz("Killa", "Cola", 16),
                new Snussz("Lyft", "Mint", 14), 
                new Snussz("Lyft", "Winterchill", 16),
                new Snussz("Lyft", "Ruby Berry", 10),
                new Snussz("Oden's", "Cold Dry", 22),
                new Snussz("Oden's", "Double Mint", 22)
                #endregion
            };
            
        SnusszWebshop webshop = new SnusszWebshop(inventory);

        Console.WriteLine("--- WEBSHOP KÖZPONTI KATALÓGUS ---");
        
        foreach (var snus in webshop.Katalogus)
        {
            Console.WriteLine(snus.ToString());
        }

        Console.WriteLine("\n--- 6 Metódus/Tulajdonsághoz feladat megoldással ---");
        
        // 1. tulajdonság: Count használata
        Console.WriteLine($"1. A kínálatban összesen {webshop.Katalogus.Count} féle snüssz található.");
        
        // 2. tulajdonság: IsReadOnly használata
        Console.WriteLine($"2. A katalógus pontos típusa: {webshop.Katalogus.GetType().Name}");

        // 3. metódus: Indexer [] használata
        Snussz kivalasztottSnussz = webshop.Katalogus[6]; 
        Console.WriteLine($"3. A 7. elem a listában: {kivalasztottSnussz.Marka} {kivalasztottSnussz.Iz}");

        // 4. metódus: Contains használata
        bool vanSiberia = webshop.Katalogus.Contains(kivalasztottSnussz);
        Console.WriteLine($"4. A katalógus tartalmazza a lekérdezett terméket? {vanSiberia}");

        // 5. metódus: IndexOf használata
        int index = webshop.Katalogus.IndexOf(kivalasztottSnussz);
        Console.WriteLine($"5. A kiválasztott snüssz belső indexe: {index}");

        // 6. metódus: CopyTo használata
        Snussz[] bmTomb = new Snussz[webshop.Katalogus.Count];
        webshop.Katalogus.CopyTo(bmTomb, 0);
        Console.WriteLine($"6. Biztonsági mentés a tömbbe. Az utolsó elem: {bmTomb[19].Marka}");


        Console.WriteLine("\n--- ICloneable + ReadOnly használata ---");
        
        Snussz displayTermek = webshop.Katalogus[0]; 
        
        
        Snussz myfelbontottDoboz = (Snussz)displayTermek.Clone();
        
        myfelbontottDoboz.SnusszElvesz();
        myfelbontottDoboz.SnusszElvesz();
        myfelbontottDoboz.SnusszElvesz();

        Console.WriteLine("EREDETI , ahogy a webshop árulja : " + displayTermek.ToString());
        Console.WriteLine("KLÓNOZOTT , miután használtunk belőle: " + myfelbontottDoboz.ToString());
        }
    }
}