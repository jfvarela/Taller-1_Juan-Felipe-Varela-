public class Critter : MonoBehavior
{
    string name=null;
    string affinity=null;
    list <string> critters = new list<string>();
    protected int  baseAttack = 10;
    protected int  baseDefense = 10;
    protected int baseSpeed=10;
    protected int hp = 100;

    Player player;
    

    void Awake()
    {
        Creating();
    }
    void Creating ()
    {
        if (player!= null)
        {
        //nombre
        string[] names= {Bulbasaur, Ivysaur, Venusaur, Charmander, Charmeleon, Charizard, Squirtle, Wartortle};
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
        string[] affinitys= {fire, wind, earth, water, dark, light};
        Random randomNumberAffinity= new Random.range(0,5);
        affinity= affinitys[randomNumberAffinity];
        }
        


        

    }



}