using System.IO.Pipes;
using System.Runtime.CompilerServices;
using klasser;

// Skapa en lista för att lagra bilobjekten
            List<bil> bilar = new List<bil>();

            // Skapa och lägg till första bilobjektet
            bil b = new bil();
            b.settillverkare("Saab");
            b.setmodel("Saab 9000 Aero");
            b.setår(1984);
            b.setvikt(1365);
            bilar.Add(b);

            // Skapa och lägg till andra bilobjektet
            bil p = new bil();
            p.settillverkare("Volvo");
            p.setmodel("Volvo 850 T-röd");
            p.setår(1996);
            p.setvikt(1590);
            bilar.Add(p);

            // Anropa metoden för att skriva ut attributen för alla bilobjekt i listan
            SkrivUtBilar(bilar);
        

        // Metod för att skriva ut attributen på alla bilobjekt i listan
        static void SkrivUtBilar(List<bil> bilar)
        {
            foreach (var bil in bilar)
            {
                Console.WriteLine("Tillverkare: " + bil.gettillverkare());
                Console.WriteLine("Model: " + bil.getmodel());
                Console.WriteLine("År: " + bil.getår());
                Console.WriteLine("Vikt: " + bil.getvikt() + " kg");
                Console.WriteLine(); // För att separera bilarna i utskriften
            }
        }
