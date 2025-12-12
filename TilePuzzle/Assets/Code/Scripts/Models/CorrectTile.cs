using UnityEngine;

public class CorrectTile
{
    public Color Color;
    public void SetColor(TileColor tileColor)
    {
       Color = tileColor.SuccesTileColor;
    }
}
