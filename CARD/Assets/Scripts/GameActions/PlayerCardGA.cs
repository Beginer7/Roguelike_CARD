using UnityEngine;

public class PlayerCardGA : GameAction
{
    public EnemyView ManualTarget {  get; private set; }
    public Card Card {  get; private set; }

    public PlayerCardGA(Card card)
    {
        Card = card;
    }

    public PlayerCardGA(Card card,EnemyView target)
    {
        Card= card;
        ManualTarget = target;
    }
}
