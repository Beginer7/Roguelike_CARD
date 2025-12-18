using System.Collections.Generic;
using UnityEngine;

public class AllEnemiesTM : TargetMode
{
    public override List<CombatantView> GetTarget()
    {
       return new(EnemySystem.Instance.Enemies);
    }
}
