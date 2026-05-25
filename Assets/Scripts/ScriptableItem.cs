using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Scriptable Objects/Item")]
public class ScriptableItem : ScriptableObject
{
    public string itemName;

    public Sprite itemSprite;

    public string itemPrice;
}
