using System;
using System.Collections;

namespace Town_Idea_Generator_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Adjectives = { "adorable", "adventurous", "aggressive", "agreeable", "alert", "alive", "amused", "angry", "annoyed", "annoying", "anxious", "arrogant", "ashamed", "attractive", "average", "awful", "bad", "beautiful", "better", "bewildered", "black", "bloody", "blue", "blushing", "bored", "brainy", "brave", "breakable", "bright", "busy", "calm", "careful", "cautious", "charming", "cheerful", "clean", "clear", "clever", "cloudy", "clumsy", "colorful", "combative", "comfortable", "concerned", "condemned", "confused", "cooperative", "courageous", "crazy", "creepy", "crowded", "cruel", "curious", "cute", "dangerous", "dark", "dead", "defeated", "defiant", "delightful", "depressed", "determined", "different", "difficult", "disgusted", "distinct", "disturbed", "dizzy", "doubtful", "drab", "dull", "eager", "easy", "elated", "elegant", "embarrassed", "enchanting", "encouraging", "energetic", "enthusiastic", "envious", "evil", "excited", "expensive", "exuberant", "fair", "faithful", "famous", "fancy", "fantastic", "fierce", "filthy", "fine", "foolish", "fragile", "frail", "frantic", "friendly", "frightened", "funny", "gentle", "gifted", "glamorous", "gleaming", "glorious", "good", "gorgeous", "graceful", "grieving", "grotesque", "grumpy", "handsome", "happy", "healthy", "helpful", "helpless", "hilarious", "homeless", "homely", "horrible", "hungry", "hurt", "ill", "important", "impossible", "inexpensive", "innocent", "inquisitive", "itchy", "jealous", "jittery", "jolly", "joyous", "kind", "lazy", "light", "lively", "lonely", "long", "lovely", "lucky", "magnificent", "misty", "modern", "motionless", "muddy", "mushy", "mysterious", "nasty", "naughty", "nervous", "nice", "nutty", "obedient", "obnoxious", "odd", "old fashioned", "open", "outrageous", "outstanding", "panicky", "perfect", "plain", "pleasant", "poised", "poor", "powerful", "precious", "prickly", "proud", "putrid", "puzzled", "quaint", "real", "relieved", "repulsive", "rich", "scary", "selfish", "shiny", "shy", "silly", "sleepy", "smiling", "smoggy", "sore", "sparkling", "splendid", "spotless", "stormy", "strange", "stupid", "successful", "super", "talented", "tame", "tasty", "tender", "tense", "terrible", "thankful", "thoughtful", "thoughtless", "tired", "tough", "troubled", "ugliest", "ugly", "uninterested", "unsightly", "unusual", "upset", "uptight", "vast", "victorious", "vivacious", "wandering", "weary", "wicked", "wide", "wild", "witty", "worried", "worrisome", "wrong", "zany", "zealous" };
            string[] Buildings = { "bungalow", "central", "chattel house", "cottage", "courtyard", "konak", "log house", "housebarn", "split level home", "duplex", "quadplex", "triplex", "town house", "garden", "retirement home", "nursing home", "dormitory", "prison", "super market", "shopping center", "hotel", "motel", "resort", "casino", "self storage", "car wash", "amusement park", "bowling alley", "marina", "theater", "funeral home", "warehouse", "office building", "lab", "data center", "call center", "showroom", "composting facility", "desalination plant", "waste transfer centre", "power plant", "fossil fuel power station", "nuclear power plant", "geothermal power", "biomass fuelled power plant", "waste heat power plant", "renewable energy power station", "power distribution", "substation building", "converter hall", "rotary converter plant", "transmitter building", "abattoir", "barn", "chicken coop", "shed", "farmhouse", "granary", "greenhouse", "hayloft", "pigpen", "root cellar", "silo", "slaughterhouse", "stable", "storm cellar", "well", "crib", "windmill", "specialty", "srchive", "college", "school", "university", "nursery school", "civic", "arena", "library", "museum", "community hall", "church", "basilica", "cathedral", "duomo", "chapel", "oratory", "martyrium", "imambargah", "monastery", "mithraeum", "shrine", "synagogue", "temple", "pagoda", "gurdwara", "mosque", "city hall", "consulate", "courthouse", "embassy", "fire station", "meeting house", "moot hall", "parliament house", "police station", "post office", "assembly", "arsenal", "barracks", "bunker", "blockhouse", "itadel", "missile launch facility", "transport", "airport", "bus station", "metro station", "taxi station", "railway station", "signal box", "lighthouse", "shipyard", "space port", "hovercraft", "ferry terminal", "cruise terminal", "boathouse", "parking garage", "hangar", "aul", "bathhouse", "film studio", "folly", "gym" };

            Generate:

            Random ranAdj = new Random();
            Random ranBuil = new Random();

            int index = ranAdj.Next(Adjectives.Length);
            int index2 = ranAdj.Next(Buildings.Length);

            Console.WriteLine(Adjectives[index] + ", " + Buildings[index2] + ".");
            Console.WriteLine();
            Console.WriteLine("Press 'enter' for a new idea!");
            Console.ReadKey();
            Console.Clear();
            goto Generate;
        }
    }
}
