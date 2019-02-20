using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmeren
{
    class Lists
    {

        List<int> priemGetallen = new List<int>();
        List<string> Namen = new List<string>();
        List<string> Namen2 = new List<string>();
        List<GameEngines> Engines = new List<GameEngines>();

      public void opdr1()
        {
            priemGetallen.Add(3);
            priemGetallen.Add(5);
            priemGetallen.Add(17);
            priemGetallen.Add(2);
            priemGetallen.Add(31);

            foreach (int item in priemGetallen)
            {
                Console.WriteLine(item);    
            }
        }

      public void opdr2()
        {
            if (priemGetallen.Contains(3))
            {
                Console.WriteLine("true");
            }
        }

      public void opdr3()
        {
            priemGetallen.Sort();
            foreach  (int getal in priemGetallen)
            {
                Console.WriteLine(getal);
            }
        }

      public void opdr4()
        {
            priemGetallen.Sort();
            priemGetallen.Reverse();
            foreach (int getal in priemGetallen)
            {
                Console.WriteLine(getal);
            }
        }

      public void opdr5()
        {
            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine("Add Name Number " + i + " to the array");
                string naam = Console.ReadLine();
                Namen.Add(naam);
                
            }
        }

      public void opdr6()
        {
            Namen2.Add("Marc");
            Namen2.Add("Nic");
            Namen2.Add("Quinn");
        }

      public void opdr7()
        {
            Namen.AddRange(Namen2);

            foreach (string item in Namen)
            {
                Console.WriteLine(item);
            }
        }

      public void opdr8()
        {
            Random rnd = new Random();
            Namen.RemoveAt(rnd.Next(1, Namen.Count));
            Namen.RemoveAt(rnd.Next(1, Namen.Count));

            foreach (string item in Namen)
            {
                Console.WriteLine(item);
            }
        }

      public void opdr9()
        {
            Console.WriteLine("Er zijn nu: " + Namen.Count + " Namen.");
            foreach (string naam in Namen)
            {
                Console.WriteLine(naam);
            }
        }

      public void opdr10()
        {
            int naamDelta = Namen.Count - 3;

            Namen.RemoveRange(2, naamDelta);
            foreach (string item in Namen)
            {
                Console.WriteLine(item);
            }
        }

      public void opdr11()
        {
            Namen.Clear();
            foreach (string item in Namen)
            {
                Console.WriteLine("List Cleared");
                
            }
        }

      public  void opdr12()
        {

            //Add 10 Engines TODO add Forloop
            Engines.Add(new GameEngines("UnrealEngine", 4.22f, true));
            Engines.Add(new GameEngines("CryEngine", 5.5f, true));
            Engines.Add(new GameEngines("Unity", 2019.2f, false));
            Engines.Add(new GameEngines("Lumberyard", 1.17f, true));
            Engines.Add(new GameEngines("Godot", 3.06f, true));
            Engines.Add(new GameEngines("Clickteam Fusion", 2.5f, false));
            Engines.Add(new GameEngines("GameMaker Studio", 2f, false));
            Engines.Add(new GameEngines("Construct", 2f, false));
            Engines.Add(new GameEngines("FrostBite", 3f, false));
            Engines.Add(new GameEngines("LibGDX", 1.99f, true));

            //Sort by property
            Engines = Engines.OrderBy(engine => engine.versie).ToList();

            foreach (GameEngines Engine in Engines)
            {
                Console.WriteLine("Titel: " + Engine.naam + "Version: " + Engine.versie);
            }

        }
    
    }
}
