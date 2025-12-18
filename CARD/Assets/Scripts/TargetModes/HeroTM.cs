using System.Collections.Generic;
using UnityEngine;

public class HeroTM : TargetMode
{
    public override List<CombatantView> GetTarget()
    {
        List<CombatantView> targets = new() 
        {
            HeroSystem.Instance.HeroView
        };
        return targets;
    }
}
