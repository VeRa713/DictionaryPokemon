namespace DictionaryPokemon
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
            {                                                   -Dictionary<string, object> series
                “pokemon”: [                                    -List<object> pokemon
                    {                                           -Dictionary<string, object> characterInfo
                        “name”: “Pikachu”,                      
                        “type”: “Lightning”,
                        “moves”: [                              -List<object> moves
                            {
                                “name”: “Quick Attack”,
                                “power”: 20
                            },
                            {
                                “name”: “Thundershock”,
                                “power”: 40
                            },
                        ]
                    },
                    {
                        “name”: “Charmander”,
                        “type”: “Fire”,
                        “moves”: [
                            {
                                “name”: “Fly”,
                                “power”: 10
                            },
                            {
                                “name”: “Fireball”,
                                “power”: 50
                            },
                        ]
                    }
                ]
            }
            */

            Dictionary<string, object> series = new Dictionary<string, object>();

            List<object> pokemon = new List<object>();

            //========== PIKACHU ==========  
            //Create pikachu's moves
            Dictionary<string, object> pikachuQuickAttack = new Dictionary<string, object>();
            pikachuQuickAttack.Add("name", "Quick Attack");
            pikachuQuickAttack.Add("power", 20);

            Dictionary<string, object> pikachuThundershock = new Dictionary<string, object>();
            pikachuThundershock.Add("name", "Thundershock");
            pikachuThundershock.Add("power", 40);

            //add created moves to moves List
            List<object> pikachuMoves = new List<object>();
            pikachuMoves.Add(pikachuQuickAttack);
            pikachuMoves.Add(pikachuThundershock);

            //Add all pikachu's info
            Dictionary<string, object> pikachuInfo = new Dictionary<string, object>();
            pikachuInfo.Add("name", "Pikachu");
            pikachuInfo.Add("type", "Lightning");
            pikachuInfo.Add("moves", pikachuMoves);

            //add pikachu to pokemon list
            pokemon.Add(pikachuInfo);

            //========== CHARMANDER ==========  
            //Create charmander's moves
            Dictionary<string, object> charmanderFly = new Dictionary<string, object>();
            charmanderFly.Add("name", "Fly");
            charmanderFly.Add("power", 10);

            Dictionary<string, object> charmanderFireball = new Dictionary<string, object>();
            charmanderFireball.Add("name", "Fireball");
            charmanderFireball.Add("power", 50);

            //add created moves to moves List
            List<object> charmanderMoves = new List<object>();
            charmanderMoves.Add(charmanderFly);
            charmanderMoves.Add(charmanderFireball);

            //Add all charmander's info
            Dictionary<string, object> charmanderInfo = new Dictionary<string, object>();
            charmanderInfo.Add("name", "Charmander");
            charmanderInfo.Add("type", "Fire");
            charmanderInfo.Add("moves", charmanderMoves);

            //add charmander to pokemon list
            pokemon.Add(charmanderInfo);

            //add pokemon list to the series Dictionary
            series.Add("pokemon", pokemon);

            //============== OUTPUT ============== 

            //========== PRACTICE to output inner values ==========
            // List<object> seriesList = (List<object>)series["pokemon"];
            // Dictionary<string, object> firstPokemon = (Dictionary<string, object>)(seriesList[0]);
            // List<object> movesList = (List<object>)firstPokemon["moves"];
            // Dictionary<string, object> firstMove = (Dictionary<string, object>)(movesList[0]);

            // Console.WriteLine("Quick Attack: " + firstMove["power"]);
            // Console.WriteLine("Name: " + firstPokemon["name"]);

            //Display all pokemon and its information relative to the dictionary object
            Console.WriteLine("======== ALL POKEMON ========");

            List<object> seriesPokemon = (List<object>)series["pokemon"];

            foreach (object pokemonList in seriesPokemon)
            { //seriesList - "pokemon"
                Dictionary<string, object> characterInfo = (Dictionary<string, object>)pokemonList; //character dict in pokemon List

                Console.WriteLine("\n\n======== " + characterInfo["name"] + " ========");
                Console.WriteLine("\nPokemon Type: " + characterInfo["type"]);

                //display moves
                Console.WriteLine("\nMoves List:");

                List<object> movesList = (List<object>)characterInfo["moves"];

                foreach (object moves in movesList)
                {
                    Dictionary<string, object> move = (Dictionary<string, object>)moves;

                    Console.WriteLine("\n======== Attack name: " + move["name"]);
                    Console.WriteLine("======== Attack power: " + move["power"]);
                }
            }

            //======== HOW TO SUFFER 101 ======== 
            Console.WriteLine("\n\n");
            Console.WriteLine("Pokemon #1 Name: " + ((Dictionary<string, object>)(((List<object>)(series["pokemon"]))[0]))["name"]);
            Console.WriteLine("Pokemon #1 Type: " + ((Dictionary<string, object>)(((List<object>)(series["pokemon"]))[0]))["type"]);
            Console.WriteLine("Pokemon #1 | Move #1 Name: " + ((Dictionary<string, object>)(((List<object>)(((Dictionary<string, object>)(((List<object>)(series["pokemon"]))[0]))["moves"]))[0]))["name"]);
            Console.WriteLine("Pokemon #1 | Move #1 Power: " + ((Dictionary<string, object>)(((List<object>)(((Dictionary<string, object>)(((List<object>)(series["pokemon"]))[0]))["moves"]))[0]))["power"]);
            Console.WriteLine("Pokemon #1 | Move #2 Name: " + ((Dictionary<string, object>)(((List<object>)(((Dictionary<string, object>)(((List<object>)(series["pokemon"]))[0]))["moves"]))[1]))["name"]);
            Console.WriteLine("Pokemon #1 | Move #2 Power: " + ((Dictionary<string, object>)(((List<object>)(((Dictionary<string, object>)(((List<object>)(series["pokemon"]))[0]))["moves"]))[1]))["power"]);

            Console.WriteLine("\nPokemon #2 Name: " + ((Dictionary<string, object>)(((List<object>)(series["pokemon"]))[1]))["name"]);
            Console.WriteLine("Pokemon #2 Type: " + ((Dictionary<string, object>)(((List<object>)(series["pokemon"]))[1]))["type"]);
            Console.WriteLine("Pokemon #2 | Move #1 Name: " + ((Dictionary<string, object>)(((List<object>)(((Dictionary<string, object>)(((List<object>)(series["pokemon"]))[1]))["moves"]))[0]))["name"]);
            Console.WriteLine("Pokemon #2 | Move #1 Power: " + ((Dictionary<string, object>)(((List<object>)(((Dictionary<string, object>)(((List<object>)(series["pokemon"]))[1]))["moves"]))[0]))["power"]);
            Console.WriteLine("Pokemon #2 | Move #2 Name: " + ((Dictionary<string, object>)(((List<object>)(((Dictionary<string, object>)(((List<object>)(series["pokemon"]))[1]))["moves"]))[1]))["name"]);
            Console.WriteLine("Pokemon #2 | Move #1 Power: " + ((Dictionary<string, object>)(((List<object>)(((Dictionary<string, object>)(((List<object>)(series["pokemon"]))[1]))["moves"]))[1]))["power"]);
        }
    }
}