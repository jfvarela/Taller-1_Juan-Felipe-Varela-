using System;
using System.Collections.Generic;
class Critter 
{
    string name=null;
    protected string affinity=null;
    list <string> critters = new list<string>();
    protected int  baseAttack = 10;
    protected int  baseDefense = 10;
    protected int baseSpeed=10;
    protected int hp = 100;
    Player player;

    protected float damageValue =0f;

    float affinityMultiplier=0f;

    void Awake()
    {
        Creating();
    }
    protected void Creating ()
    {
        if (player!= null)
        {
        //nombre
        string[] names= {"Bulbasaur", "Ivysaur", "Venusaur", "Charmander", "Charmeleon", "Charizard", "Squirtle", "Wartortle"};
        Random randomNumberName= new Random.range(0,7);
        name= names[randomNumberName];

        //ataque
        Random randomNumberAttack= new Random.range(10,100);
        baseAttack = randomNumberAttack;

        //defensa
        Random randomNumberDefense= new Random.range(10,100);
        baseDefense= randomNumberDefense;

        //velocidad
        Random randomNumberSpeed= new Random.range(10,50);
        baseSpeed=randomNumberSpeed;

        //afinidad
        string[] affinitys= {"fire", "wind", "earth", "water", "dark", "light"};
        Random randomNumberAffinity= new Random.range(0,5);
        affinity= affinitys[randomNumberAffinity];
        } 

    }


    void affinityRelation()
    {

        switch (affinity == enemy.affinity)
        {
            case (true) : 
            affinityMultiplier= 0.5f;

            case (affinity=="fire" && enemy.affinity=="earth"):
            affinityMultiplier = 0;

            case ((affinity=="dark" && enemy.affinity=="light")||(affinity=="fire" && enemy.affinity=="water")||(affinity=="wind" && enemy.affinity=="water") || (affinity=="wind" && enemy.affinity=="earth")
            ||(affinity=="light" && enemy.affinity=="dark")||(affinity=="water" && enemy.affinity=="fire")||(affinity=="water" && enemy.affinity=="wind")||(affinity=="earth" && enemy.affinity=="wind")):
            affinityMultiplier = 2;

            case (false):
            affinityMultiplier = 1;
        }

    }
    void Damage()
    {
        damageValue = (baseAttack + skills.skillPower) * affinityMultiplier;
    }

}