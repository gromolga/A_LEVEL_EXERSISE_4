using A_LEVEL_EXERSISE_4.CandyTypes;
using A_LEVEL_EXERSISE_4.CandyTypes.CandySubtypes.ForCaramelCandy;
using A_LEVEL_EXERSISE_4.CandyTypes.CandySubtypes.ForChockolateCandy.ForCandyWithAlcohol;
using System;
using System.Collections.Generic;
using System.Text;

namespace A_LEVEL_EXERSISE_4
{
    class Logic
    {
        public CandyList list = new CandyList();
        public void Run()
        {
            CandyBasic rafaello = new WithAlmond(20, "Rafaello", "Ferrero Roshe");
            CandyBasic barbaris = new Lollypop(20, "Barbaris", "Roshen");
            CandyBasic cow = new StuffedCandy(25, "Cow", "AVK");
            CandyBasic cherry = new WithCognac(30, "Cherry", "Bisquit Chockolate");
            CandyBasic rum = new WithRum(24, "Rum", "Roshen");
            CandyBasic squirell = new WithHazelnut(30, "Squirell", "Roshen");
            CandyBasic grennyFairyTails = new WithPeanut(28, "Grenny Fairytails", "AVK");
            CandyBasic toffi = new ToffyCandy(15, "Toffi", "Kharkivchanka");

            list.Add(rafaello);
            list.Add(barbaris);
            list.Add(cow);
            list.Add(cherry);
            list.Add(rum);
            list.Add(squirell);
            list.Add(grennyFairyTails);
            list.Add(toffi);

            int commonWeight = 0;
            CandyBasic[] candiesArray = list.ToArray();


            for (int i = 0; i < candiesArray.Length; i++)
            {
                int candyWeight = candiesArray[i].Weight;
                commonWeight += candyWeight;
               
            }
            Console.WriteLine(commonWeight);
        }


    }
}
