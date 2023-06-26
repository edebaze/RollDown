public class Character
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        public List<Origin> Origins { get; set; }
        public List<Trait> Traits { get; set; }

        public Character(string name, int cost, List<Origin> origins, List<Trait> traits)
        {
            Name = name;
            Cost = cost;
            Origins = origins;
            Traits = traits;
        }
    }