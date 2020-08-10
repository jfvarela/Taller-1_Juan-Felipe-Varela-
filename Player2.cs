using System;
using System.Collections.Generic;

class Player2 : Player
{
    int currentHp;

    public list <Critter> crittersP2 = new list<Critter>();

    void AddCritter ()
    {
        while (count == 0)
        {
            crittersP2.add (new Critter[currentHp = critterMaster.hp]);
            break;
        }

        foreach (Critter acritter in crittersP2)
        {
            currentHp -= Player1.critterMaster.damageValue;
            Console.WriteLine(currentHp);
            if(currentHp <= 0)
            {
                crittersP1.add (Critter);
                crittersP2.remove (acritter);
                count+=1;
            }
        }
        
        Console.WriteLine(crittersP2);

    }

    
}