using UnityEngine;

public class ApplyBurndGA : GameAction
{
    public int BurnDamage {  get; private set; }
    public CombatantView Target {  get; private set; }   
    public ApplyBurndGA(int burnDamage,CombatantView target)
    {
        BurnDamage = burnDamage;
        Target = target;
    }
}
