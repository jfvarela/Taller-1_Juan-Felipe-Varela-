using System;
using System.Collections.Generic;

class Player1 : Player
{
    int currentHp;

    public list <Critter> crittersP1 = new list<Critter>();

    void AddCritter ()
    {
        while (count = 0)
        {
            crittersP1.add (new Critter[currentHp = critterMaster.hp]);
            break;
        }

        foreach (Critter acritter in critters)
        {
            currentHp -= Player2.critterMaster.damageValue;
            Console.WriteLine(currentHp);
            if(currentHp <= 0)
            {
                crittersP2.add (acritter);
                crittersP1.remove (acritter);
                count+=1;
            }
        }
        Console.WriteLine(crittersP1);
    }

    
}