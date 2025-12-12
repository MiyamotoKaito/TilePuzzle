using UnityEngine;
using System.Threading.Tasks;

public class TileInit : MonoBehaviour
{
    public int CorrectTileCount => _correctTileCount;

    [SerializeField] private int _correctTileCount;
    [SerializeField] private int _height;
    [SerializeField] private int _width;
    
    void InstanciateTile()
    {

    }
}
