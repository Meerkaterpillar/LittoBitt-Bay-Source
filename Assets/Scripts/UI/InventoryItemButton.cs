using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryItemButton : MonoBehaviour
{
    [SerializeField] Image icon;
    [SerializeField] TMP_Text quantityLabel;

    void Start()
    {
        
    }

    public ItemInfo Item
    {
        set
        {
            icon.sprite = value.Icon;
        }
    }

    public int Quantity
    {
        set
        {
            quantityLabel.text = value.ToString("n0");
        }
    }

}
