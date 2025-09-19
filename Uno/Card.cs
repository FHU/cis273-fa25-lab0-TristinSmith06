namespace Uno;

public enum CardType
{
    Number, Wild, Draw2, WildDraw4, Skip, Reverse
}

public enum Color
{
    Red, Yellow, Blue, Green, Wild
}

public class Card
{
    public CardType Type { get; set; }
    public Color Color { get; set; }
    public int? Number { get; set; }


    private bool IsWild()
    {
        return Type == CardType.Wild || Type == CardType.WildDraw4;
    }

    private static bool CardsHaveType(Card card1, Card card2, CardType type)
    {
        return card1.Type == type && card2.Type == type;
    }

    public static bool PlaysOn(Card card1, Card card2)
    {
        if (card1.IsWild() || card2.IsWild()) //Wild cards play on anything and can have anything played on them
        {
            return true;
        }
        else if (card1.Color == card2.Color) //Same color card
        {
            return true;
        }
        else if (card1.Number == card2.Number && CardsHaveType(card1, card2, CardType.Number))
        { // card number only matters if both cards are numbered, prevents different type cards from being played when their numbers are technically the same
            return true;
        }
        else if (card1.Type == card2.Type  && !CardsHaveType(card1, card2, CardType.Number)) // if the two cards are the same type, but not numbered cards
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    public override string ToString()
    {
        switch (Type)
        {
            case CardType.Wild:
                return "Wild";
            case CardType.WildDraw4:
                return "WildDraw4";
            case CardType.Number:
                return $"{Color} {Number}";
            case CardType.Draw2:
                return $"{Color} Draw 2";
            case CardType.Skip:
                return $"{Color} Skip";
            case CardType.Reverse:
                return $"{Color} Reverse";
            default:
                return "Failed to get card name";
        }

    }

}