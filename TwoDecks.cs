namespace TwoDecksBlazor
{
    public class TwoDecks
    {
        private Deck leftDeck = new();
        private Deck rightDeck = new();

        public int LeftDeckCount { get { return leftDeck.Count; } }
        public int RightDeckCount { get { return rightDeck.Count; } }
        public int LeftCardSelected { get; set; }
        public int RightCardSelected { get; set; }

        public string LeftDeckCardName(int i)
        {
            return leftDeck[i].ToString();
        }
        public string RightDeckCardName(int i)
        {
            return rightDeck[i].ToString();
        }

        public void Sort()
        {
            rightDeck.Sort(new CardCompererByValue());
        }
        public void Clear()
        {
            rightDeck.Clear();
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
