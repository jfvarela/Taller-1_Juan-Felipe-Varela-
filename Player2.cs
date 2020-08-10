using System;
using System.Collections.Generic;

class Player2 : Player
{
    int currentHp;

    public list <Critter> crittersP2 = new list<Critter>();

    void AddCritter ()
    {
        while (count < 3)
        {
            crittersP2.add (new Critter[currentHp = critterMaster.hp]);
            break;
        }

        foreach (Critter acritter in crittersP2)
        {
            currentHp -= Player1.critterMaster.damageValue;
            if(currentHp <= 0)
            {
                crittersP1.add (Critter);
                count+=1;
            }
        }
    }

    
}