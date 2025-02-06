/**
* @author @GameLord2011
*/

using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

Console.WriteLine("What's your name?");
string name = Console.ReadLine();
string[] swords = {};
string[] shields = {};
string[] items = {};
int health = 100;
try{
    string capitalizedString = char.ToUpper(name[0]) + name.Substring(1);// capitalize
    if (capitalizedString == "Reid" || capitalizedString == "Rory" || capitalizedString == "Ramsey" || capitalizedString == "Riggins" || capitalizedString == "Rhodes" || capitalizedString == "Reagan" || capitalizedString == "Leah" || capitalizedString == "Andrew"){
        if (capitalizedString != "Leah"){
            Console.Write("Ah, " + capitalizedString + ", our king, we have been waiting for you. \n");
        }
        else{
            Console.Write("Ah, " + capitalizedString + ", our queen, we have been waiting for you. \n");
        }
        swords.Append("Sword X");
        shields.Append("Shield X");
        items.Append("Final Boss Key");
        health = 100000;
        Final_boss(capitalizedString, health, swords, shields, items);
    }
    else if (capitalizedString == "Creditsplz"){
        Creditsplz();
    }
    else{
        Level_1(capitalizedString, health, swords, shields, items);//Carry Name, Health, Swords, Shields, and Items over.
    }
}
catch(IndexOutOfRangeException){
    Console.WriteLine("That is not a valid option");
    Console.ReadKey();
}
static void Level_1(string capitalizedString, int health, string[] swords, string[] shields, string[] items){
    Console.Write("We start our journey in a humble tavern");
    int milliseconds = 2500;
    Thread.Sleep(milliseconds - 1500);
    Console.Write(".");
    Thread.Sleep(milliseconds- 1500);
    Console.Write(".");
    Thread.Sleep(milliseconds- 1500);
    Console.Write(".\n");
    Console.Write("It is a normal tuesday at \"The Tavern of Tales,\" and you just came in to get soup.\nSuddenly an old man you don't know calls \"Hey, " + capitalizedString + " come over here!\"\n");
    Console.WriteLine("You go over to the old man, confused how he knows your name.");
    Thread.Sleep(milliseconds);
    Console.WriteLine("When you get there the old man says \"Oh great " + capitalizedString + " the kindom needs you.\"");
    Thread.Sleep(milliseconds);
    Console.WriteLine("\"What?!?\" You say confused of what is going on.");
    Thread.Sleep(milliseconds);
    Console.WriteLine("\"You...\" The old man tries to repeat, but you interrupt him.");
    Thread.Sleep(milliseconds);
    Console.WriteLine("\"I know what you said I just don't get it!\" you say in a shocked voice.");
    Thread.Sleep(milliseconds);
    Console.WriteLine("\"Let's go for a walk, " + capitalizedString + "\" the old man says.");
    Thread.Sleep(milliseconds);
    Console.WriteLine("You go outside. You can see the old man better now, he kinda looks like Gandalf from Lord of The Rings.");   //@GameLord2011's note, @USD4CE2014 suggested King Roham Bosporas form BOTW
    Thread.Sleep(milliseconds);
    //Console.WriteLine("\"Spilleth it, WHATETH THE FUDGETH IS GOINGETH ON MAN?!?\" You say in an angry tone.");  //@GameLord2011's note, @USD4CE2013 said "make it medivaly"
    Console.WriteLine("Spill it, WHAT'S GOING ON MAN?!?");
    Thread.Sleep(milliseconds);
    Console.WriteLine("\"There is an ainchent profecy that says you, " + capitalizedString + " will save us from\"");
    Thread.Sleep(milliseconds);
    Console.WriteLine("Thunk, suddenly you notice an arrow in the old man's back.");
    Thread.Sleep(milliseconds);
    Console.WriteLine("\"You must save us, take these oh great, " + capitalizedString + "\"");
    Thread.Sleep(milliseconds);
    items.Append("Magic Map");
    swords.Append("Dagger");
    Console.WriteLine("You gained the Magic Map and a Dagger");
    Thread.Sleep(milliseconds);
    Console.Write("Suddenly");
    Thread.Sleep(milliseconds - 1500);
    Console.Write(".");
    Thread.Sleep(milliseconds - 1500);
    Console.Write(".");
    Thread.Sleep(milliseconds - 1500);
    Console.Write(".\n");
    Thread.Sleep(milliseconds);
    Console.WriteLine("You are attacked!");
    int gobhth = 100;
    while(gobhth > 0 && health > 0){
        Console.WriteLine("Choose your attack: \n1. Dagger \n2. nothing \n");
        string attack = Console.ReadLine();
        switch(attack) {
            case "1":
            gobhth -= 10;
            Console.WriteLine("You did 10 damage!");
            var rand = new Random();
            var gatc = rand.Next(0, 15);
            if(gatc >= 13){
                Console.WriteLine("The Goblin has done a Critical hit (10 damage)!");
                health -= 10;
            }
            else{
                Console.WriteLine("The goblin has hit you with his club (5 damage).");
                health -= 5;
            }
            break;
            case "2":
            Console.WriteLine("You do nothing.");
            Console.WriteLine("The Goblin has attacked (5 damage).");
            health -= 5;
            break;
            default:
            Console.WriteLine("You do nothing.");
            Console.WriteLine("The Goblin has attacked (5 damage).");
            health -= 5;
            break;
        }
    }
    if (gobhth <= 0){
        Console.WriteLine("You Won!");
        Thread.Sleep(milliseconds);
    }
    else if(health <= 0 && gobhth <= 0){
        Console.WriteLine("You and the goblin someltanisly destroy each other.");
        Thread.Sleep(milliseconds);
        Environment.Exit(0);
    }
    else{
        Console.WriteLine("Sadly, Your journey ends here.");
        Thread.Sleep(milliseconds);
        Environment.Exit(0);
    }
    health = 100;
    Console.WriteLine("You look back, and find that the old man is gone!");
    Thread.Sleep(milliseconds);
    Console.WriteLine("You see that there is an old shield on the ground, and pick it up.");
    shields.Append("old_shield");
    Thread.Sleep(milliseconds);
    Console.WriteLine("You gained the old shield!");
    Thread.Sleep(milliseconds);
    Console.WriteLine("Then suddenly, the magic map starts talking?!?");
    Thread.Sleep(milliseconds);
    Console.WriteLine("\"Hello, " + capitalizedString + " as the pofecy dictated, you must go east, to the DARKLANDS!\"");
    Thread.Sleep(milliseconds);
    Console.Write("Then, you go off to the DARKLANDS");
    Thread.Sleep(milliseconds - 1500);
    Console.Write(".");
    Thread.Sleep(milliseconds - 1500);
    Console.Write(".");
    Thread.Sleep(milliseconds - 1500);
    Console.Write(".\n");
    Level_2(capitalizedString, health, swords, shields, items);
}
static void Level_2(string capitalizedString, int health, string[] swords, string[] shields, string[] items) {
    int milliseconds = 2500;
    Console.WriteLine("You enter the darklands and then get ambushed by a dark goblin!");
    Thread.Sleep(milliseconds);
    int dkgob1hth = 100;
    while(dkgob1hth > 0 && health > 0){
        Console.WriteLine("Choose your attack: \n1. Dagger \n2. nothing \n");
        string attack = Console.ReadLine();
        switch(attack) {
            case "1":
            dkgob1hth -= 10;
            Console.WriteLine("You did 10 damage!");
            var rand = new Random();
            var gatc = rand.Next(0, 15);
            if(gatc >= 13){
                Console.WriteLine("The Dark Goblin has done a Critical hit (10 damage)!");
                health -= 10;
            }
            else{
                Console.WriteLine("The dark goblin has hit you with his club (5 damage).");
                health -= 5;
            }
            break;
            case "2":
            Console.WriteLine("You do nothing.");
            Console.WriteLine("The Dark Goblin has attacked (5 damage).");
            health -= 5;
            break;
            default:
            Console.WriteLine("You do nothing.");
            Console.WriteLine("The Dark Goblin has attacked (5 damage).");
            health -= 5;
            break;
        }
    }
    if (dkgob1hth <= 0){
        Console.WriteLine("You Won!");
        Thread.Sleep(milliseconds);
    }
    else if(health <= 0 && dkgob1hth <= 0){
        Console.WriteLine("You and the dark goblin someltanisly destroy each other.");
        Thread.Sleep(milliseconds);
        Environment.Exit(0);
    }
    else{
        Console.WriteLine("Sadly, Your journey ends here.");
        Thread.Sleep(milliseconds);
        Environment.Exit(0);
    }
    Console.WriteLine("You see the goblin dropped a health elixer, you drink it.");
    health = 115;
    Thread.Sleep(milliseconds);
    Console.WriteLine("You now have 115 hp");
    Thread.Sleep(milliseconds);
    Console.WriteLine("You enter the dungeon.");
    Thread.Sleep(milliseconds);
    Console.WriteLine("After hours of exploring you find an ogre.");
    Thread.Sleep(milliseconds);
    int og1hth = 100;
    while(og1hth > 0 && health > 0){
        Console.WriteLine("Choose your attack: \n1. Dagger \n2. nothing \n");
        string attack = Console.ReadLine();
        switch(attack) {
            case "1":
            og1hth -= 10;
            Console.WriteLine("You did 10 damage!");
            var rand = new Random();
            var gatc = rand.Next(0, 15);
            if(gatc >= 13){
                Console.WriteLine("The ogre has done a Critical hit (10 damage)!");
                health -= 10;
            }
            else{
                Console.WriteLine("The ogre has hit you with his club (5 damage).");
                health -= 5;
            }
            break;
            case "2":
            Console.WriteLine("You do nothing.");
            Console.WriteLine("The ogre has attacked (5 damage).");
            health -= 5;
            break;
            default:
            Console.WriteLine("You do nothing.");
            Console.WriteLine("The ogre has attacked (5 damage).");
            health -= 5;
            break;
        }
    }
    if (og1hth <= 0){
        Console.WriteLine("You Won!");
        Thread.Sleep(milliseconds);
    }
    else if(health <= 0 && og1hth <= 0){
        Console.WriteLine("You and the ogre someltanisly destroy each other.");
        Thread.Sleep(milliseconds);
        Environment.Exit(0);
    }
    else{
        Console.WriteLine("Sadly, Your journey ends here.");
        Thread.Sleep(milliseconds);
        Environment.Exit(0);
    }
    health = 115;
    Console.WriteLine("Suddenly, your dagger turns into a sword!");
    Level_3(capitalizedString, health, swords, shields ,items);
}
static void Level_3(string capitalizedString, int health, string[] swords, string[] shields, string[] items) {
    int milliseconds = 2500;
    health = 115;
    Console.WriteLine("Suddenly, the magic map says \"Hey, " + capitalizedString + " were almost at the dragon!\"");
    Thread.Sleep(milliseconds);
    Console.Write("D-");
    Thread.Sleep(milliseconds-1500);
    Console.Write("did you say d-");
    Thread.Sleep(milliseconds-1500);
    Console.Write("d-");
    Thread.Sleep(milliseconds-1500);
    Console.Write("DRAGON?!?\n");
    Thread.Sleep(milliseconds);
    Console.WriteLine("\"Yes dragon, what did you think would be at the end of this quest? A little girl?\" the map says in an exasperated tone");
    Thread.Sleep(milliseconds);
    Console.WriteLine("Suddenly, out of the corner of your eye you see a small glint.");
    Thread.Sleep(milliseconds);
    Console.WriteLine("You go over to it and see a large shield, you pick it up.");
    Thread.Sleep(milliseconds);
    shields.Append("large shield");
    Console.WriteLine("Then you see a goblin!");
    int gob2hth = 100;
    while(gob2hth > 0 && health > 0){
        Console.WriteLine("Choose your attack: \n1. Sword \n2. nothing \n");
        string attack = Console.ReadLine();
        switch(attack) {
            case "1":
            gob2hth -= 15;
            Console.WriteLine("You did 15 damage!");
            var rand = new Random();
            var gatc = rand.Next(0, 15);
            if(gatc >= 13){
                Console.WriteLine("The Goblin has done a Critical hit (3 damage)!");
                health -= 3;
            }
            else{
                Console.WriteLine("The goblin has hit you with his club (2 damage).");
                health -= 2;
            }
            break;
            case "2":
            Console.WriteLine("You do nothing.");
            Console.WriteLine("The Goblin has attacked (2 damage).");
            health -= 2;
            break;
            default:
            Console.WriteLine("You do nothing.");
            Console.WriteLine("The Goblin has attacked (2 damage).");
            health -= 2;
            break;
        }
    }
    if (gob2hth <= 0){
        Console.WriteLine("You Won!");
        Thread.Sleep(milliseconds);
    }
    else if(health <= 0 && gob2hth <= 0){
        Console.WriteLine("You and the goblin someltanisly destroy each other.");
        Thread.Sleep(milliseconds);
        Environment.Exit(0);
    }
    else{
        Console.WriteLine("Sadly, Your journey ends here.");
        Thread.Sleep(milliseconds);
        Environment.Exit(0);
    }
    health = 115;
    Thread.Sleep(milliseconds);
    Console.WriteLine("Then the wall in front of you crumbles, revealing cave!");
    Thread.Sleep(milliseconds);
    Console.WriteLine("You see a healhth booster!");
    Thread.Sleep(milliseconds);
    Console.WriteLine("You drink it, and gain 200 hp!");
    health = 315;
    Console.WriteLine("Then, you look left and see the dragon.");
    Thread.Sleep(milliseconds);
    Final_boss(capitalizedString, health, swords, shields, items);
}
static void Final_boss(string capitalizedString, int health, string[] swords, string[] shields, string[] items) {
    int milliseconds = 2500;
    int drgnhth = 250;
    if (capitalizedString == "Reid" || capitalizedString == "Rory" || capitalizedString == "Ramsey" || capitalizedString == "Riggins" || capitalizedString == "Rhodes" || capitalizedString == "Reagan" || capitalizedString == "Leah" || capitalizedString == "Andrew"){
        Console.WriteLine("You strike the dragon with sword x and one hit it!");
        Thread.Sleep(milliseconds);
        Creditsplz();
        Environment.Exit(0);
    }
    else{
        while(drgnhth > 0 && health > 0){
        Console.WriteLine("Choose your attack: \n1. Sword \n2. nothing \n");
        string attack = Console.ReadLine();
        switch(attack) {
            case "1":
            drgnhth -= 15;
            Console.WriteLine("You did 15 damage!");
            var rand = new Random();
            var gatc = rand.Next(0, 15);
            if(gatc >= 13){
                Console.WriteLine("The dragon has done a Critical hit (20 damage)!");
                health -= 20;
            }
            else{
                Console.WriteLine("The dragon has clawed you (10 damage).");
                health -= 10;
            }
            break;
            case "2":
            Console.WriteLine("You do nothing.");
            Console.WriteLine("The dragon has attacked (10 damage).");
            health -= 10;
            break;
            default:
            Console.WriteLine("You do nothing.");
            Console.WriteLine("The dragon has attacked (10 damage).");
            health -= 10;
            break;
            }
        }
    }
    if(health <= 0){
        Console.WriteLine("sadly, your journey ends here");
        Thread.Sleep(milliseconds);
        Environment.Exit(0);
    }
    if (drgnhth <= 0 && health <= 0){
        Console.WriteLine("you and the dragon simeltaneously destroy each other");
        Thread.Sleep(milliseconds);
        Environment.Exit(0);
    }
    else{
        Console.WriteLine("You have saved the kingdom, " + capitalizedString + "!");
        Thread.Sleep(milliseconds);
        Creditsplz();
    }
}
static void Creditsplz(){
    int milliseconds = 1000;
    Console.WriteLine("");
    Console.WriteLine("+----------------------+");
    Thread.Sleep(milliseconds);
    Console.WriteLine("| An RPG               |");
    Thread.Sleep(milliseconds);
    Console.WriteLine("| Programmers:         |");
    Thread.Sleep(milliseconds);
    Console.WriteLine("|   @GameLord2011      |");
    Thread.Sleep(milliseconds);
    Console.WriteLine("| Story:               |");
    Thread.Sleep(milliseconds);
    Console.WriteLine("|   @USD4CE2013        |");
    Thread.Sleep(milliseconds);
    Console.WriteLine("|                      |");
    Thread.Sleep(milliseconds);
    Console.WriteLine("|  The Legend of:      |");
    Thread.Sleep(milliseconds);
    Console.WriteLine("|  capitalizedString   |");
    Thread.Sleep(milliseconds);
    Console.WriteLine("+----------------------+");
    Thread.Sleep(milliseconds * 3);
}
