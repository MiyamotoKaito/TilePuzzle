using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class TileView : MonoBehaviour, IPointerClickHandler
{
    public event Action OnTileClicked;

    public void OnPointerClick(PointerEventData eventData)
    {
        OnTileClicked?.Invoke();
    }
}
