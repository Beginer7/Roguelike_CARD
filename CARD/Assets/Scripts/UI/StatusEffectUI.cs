using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StatusEffectUI : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private TMP_Text statCountText;

    public void Set(Sprite sprite,int stackCount)
    {
        image.sprite = sprite;
        statCountText.text = stackCount.ToString();
    }

    //public static implicit operator StatusEffectUI(StatusEffectsUI v)
    //{
    //    throw new NotImplementedException();
    //}
}
