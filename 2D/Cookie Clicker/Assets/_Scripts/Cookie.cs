using System;
using UnityEngine;
using UnityEngine.EventSystems;

public sealed class Cookie : MonoBehaviour, IPointerClickHandler
{
    public event Action Clicked;

    public void OnPointerClick(PointerEventData eventData) => Clicked?.Invoke();
}
