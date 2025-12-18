using System.Collections.Generic;
using UnityEngine;

public class NoTM : TargetMode
{
    public override List<CombatantView> GetTarget()
    {
        return null;
    }
}
