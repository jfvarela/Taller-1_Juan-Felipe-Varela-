using System;
using System.Collections.Generic;

class skills
{
    protected string skillName = null;
    string affinity = null;
    Critter critter;
    int skillType=0; //  0=defense       1=attack
    string skillTypeName= null;

    string supportSkill;

    protected int skillPower=0;
    int count =0;
    Player2 enemy;

    void Start()
    {
        affinity=critter.affinity;
        skillName = critter.affinity +"skill"; //nombre de la skill

        //tipo de skill
        Random randomNumberSkill= new Random.range(0,1);
        skillType=randomNumberSkill;
        if (skillType == 1)
        {
            skillTypeName = "attack";
            Random randomPowerAttack= new Random.range(1,100);
            skillPower = randomPowerAttack;
        }
        else
        {
            if (count < 3)
            {
            skillTypeName = "defense";
            string[] supportSkills= {"AtkUp","DefUp","SpdDwn"};
            Random randomNumberSupport= new Random.range(0,2);
            supportSkill= names[randomNumberSupport];
            }
            else
            {
                Console.WriteLine("support skills full")
            }
        }

        if (supportSkill == "AtkUp")
        {
            skillPower += critter.baseAttack * 0.2;
            count +=1;
        }

         if (supportSkill == "DefUp")
        {
            skillPower += critter.baseDefense * 0.2;
            count +=1;
        }

        if (supportSkill == "SpdDwn")
        {
            skillPower -= enemy.critter.baseSpeed*0.3;
            count +=1;
        }

    }
}