using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class ItemInfo : ScriptableObject
{
    public Sprite Icon;

    public IngredientInfo[] CraftingIngredients;
}

[System.Serializable]
public class IngredientInfo
{
    public ItemInfo Item;
    public int Quantity;

    public IngredientInfo()
    {
        Quantity = 1;
    }
}
