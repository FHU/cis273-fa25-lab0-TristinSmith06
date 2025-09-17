namespace Uno;

public class Player
{
    public string Name { get; set; }

    // public List<Card> Hand { get; set; }
    public List<Card> Hand { get; set; } = new List<Card>();


    public bool HasPlayableCard(Card card)
    {
        foreach (var iterate_card in Hand)
        {
            if (Card.PlaysOn(iterate_card, card))
            {
                return true;
            }
        }
        return false;
    }

    public Card GetFirstPlayableCard(Card card)
    {
        foreach (var iterate_card in Hand)
        {
            if (Card.PlaysOn(iterate_card, card))
            {
                return iterate_card;
            }
        }
        return null;
    }


    public Color MostCommonColor()
    {
        double red_count = 0;
        double blue_count = 0;
        double green_count = 0;
        double yellow_count = 0;
        double wild_count = 0;

        foreach (var card in Hand) //store the counts of the colors that appear
        {
            switch (card.Color)
            {
                case Color.Yellow:
                    yellow_count++;
                    break;
                case Color.Blue:
                    blue_count++;
                    break;
                case Color.Green:
                    green_count++;
                    break;
                case Color.Red:
                    red_count++;
                    break;
                case Color.Wild:
                    wild_count++;
                    break;
                default:
                    break;
            }
        }

        double[] sums = { red_count, yellow_count, blue_count, green_count, wild_count };
        double max_val = sums.Max();


        Dictionary<char, double> result = new Dictionary<char, double>() //put color counts into dictionary
        {
            ['r'] = red_count,
            ['y'] = yellow_count,
            ['b'] = blue_count,
            ['g'] = green_count,
            ['w'] = wild_count
        };

        List<char> keysToDelete = new List<char>();

        foreach (KeyValuePair<char, double> item in result) //delete all keys that aren't the max value
        {
            if (item.Value != max_val)
            {
                keysToDelete.Add(item.Key);
            }
        }

        foreach (var toDelete in keysToDelete)
        {
            result.Remove(toDelete);
        }


        if (result.ContainsKey('r')) //either one key remains or it's a tie, so the order of the elifs is the order in case of a tie
        {
            return Color.Red;
        }
        else if (result.ContainsKey('y'))
        {
            return Color.Yellow;
        }
        else if (result.ContainsKey('b'))
        {
            return Color.Blue;
        }
        else if (result.ContainsKey('g'))
        {
            return Color.Green;
        }
        else if (result.ContainsKey('w'))
        {
            return Color.Wild;
        }

        return Color.Red;
    }

}