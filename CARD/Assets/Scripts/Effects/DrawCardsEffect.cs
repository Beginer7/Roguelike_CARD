using System.Collections.Generic;
using UnityEngine;

public class DrawCardsEffect : Effect
{
    [SerializeField] private int drawAmout;
    public override GameAction GetGameAction(List<CombatantView> targets,CombatantView caster)
    {
        DrawCardsGA drawCardsGA = new(drawAmout);
        return drawCardsGA;
    }
}
