using System.Collections.Generic;
using UnityEngine;

public class Perk
{ 
    public Sprite Image => data.Image; 

    private readonly PerkData data;

    private readonly PerkCondition condition;
    private readonly AutoTargetEffect effect;

    public Perk(PerkData perkData)
    {
        data = perkData;
        condition = data.PerkCondition;
        effect = data.AutoTargetEffect;
    }

    public void OnAdd()
    {
        condition.SubscribeCondition(Reaction);
    }

    public void ReMove()
    {
        condition.UnsubscribeCondition(Reaction);
    }

    private void Reaction(GameAction gameAction)
    {
        if (condition.SubConditionIsMet(gameAction))
        {
            List<CombatantView> target = new();
            if(data.UseActionCasterAsTarget && gameAction is IHaveCaster haveCaster)
            {
                target.Add(haveCaster.Caster);
            }
            if (data.UseAutoTarget)
            {
                target.AddRange(effect.TargetMode.GetTarget());
            }
            GameAction perkEffectAction = effect.Effect.GetGameAction(target, HeroSystem.Instance.HeroView);
            ActionSystem.Instance.AddReaction(perkEffectAction);

        }
    }
}
