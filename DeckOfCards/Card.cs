namespace DeckOfCards
{
    public class Card
    {
        public string Name { get; set; }

        public Card(string cardName, string suite)
        {
            Name = $"{cardName} of {suite}";
        }
    }
}