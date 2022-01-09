using UnityEngine;

[CreateAssetMenu]
public class CardData : ScriptableObject
{
    public string Name;

    public uint Water;

    [TextArea(3, 7)]
    public string Detail;

    public Sprite Image;
}
