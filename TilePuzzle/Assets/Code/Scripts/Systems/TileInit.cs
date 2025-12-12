using UnityEngine;

public class TileEvent : MonoBehaviour
{
    public int CorrectTileCount => _correctTileCount;

    [SerializeField] private int _correctTileCount;
    [SerializeField] private int _height;
    [SerializeField] private int _width;

    async void Start()
    {
    }
    
    void InstanciateTile()
    {

    }
}
