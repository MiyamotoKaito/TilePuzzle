using UnityEngine;

public class TileEvent : MonoBehaviour
{
    public int CorrectTileCount => _correctTileCount;

    [SerializeField] private int _correctTileCount;
}
