using UnityEngine;

public class CorrectTile : ISetColor
{
    public Color Color;
    public void SetColor(TileColor tileColor)
    {
        Color = tileColor.SuccesTileColor;
    }
}
