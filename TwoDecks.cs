namespace TwoDecksBlazor
{
    public class TwoDecks
    {
        private Deck leftDeck = new Deck();

        private int LeftDeckCount { get { return leftDeck.Count; } }
        public int LeftCardSelected { get; set; }

        public string LeftDeckCardName(int i)
        {
            return leftDeck.ToString();
        }

        public void Shuffle()
        {
            leftDeck.Shuffle();
        }

        public void Reset()
        {
            leftDeck = new Deck();
        }
    }
}
