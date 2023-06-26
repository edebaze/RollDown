namespace game_management {
    class GameManager: MonoBehavior {
        public static GameManager Instance;

        public Player Player;
        public Board Board;
        public Bench Bench;
        public Shop Shop;

        public void Start() {
            Shop.Refresh()
        }
    }
}