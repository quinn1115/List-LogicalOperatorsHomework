using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmeren
{
    class GameEngines
    {
      public string naam;
      public float versie;
      public bool openSource;


        public GameEngines(string naam, float versie, bool openSource)
        {
            this.naam = naam;
            this.versie = versie;
            this.openSource = openSource;
        }



    }
}
