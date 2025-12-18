using System.Collections;
using UnityEngine;

public class BurndSystem : MonoBehaviour
{
    [SerializeField] private GameObject burndVFX;
    private void OnEnable()
    {
        ActionSystem.AttachPerformer<ApplyBurndGA>(ApplyBurnPerformer);
    }
    private void OnDisable()
    {
        ActionSystem.DetachPerformer<ApplyBurndGA>();
    }

    private IEnumerator ApplyBurnPerformer(ApplyBurndGA applyBurndGA)
    {
        CombatantView target = applyBurndGA.Target;
        Instantiate(burndVFX, target.transform.position, Quaternion.identity);
        target.Damage(applyBurndGA.BurnDamage);
        target.RemoveStatusEffect(StatusEffectType.BURN, 1);
        yield return new WaitForSeconds(1f);
    }
}
