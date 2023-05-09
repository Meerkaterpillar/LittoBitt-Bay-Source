using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryCanvas : UICanvas
{
    [SerializeField] InventoryItemButton itemButtonPrefab;
    [SerializeField] RectTransform itemButtonsContainer;

    public override void Start()
    {
        base.Start();
    }

    public override void Open()
    {
        base.Open();
        PopulatePanel();
    }

    public override void Close()
    {
        ClearPanel();
        base.Close();
    }

    void PopulatePanel()
    {
        ClearPanel();

        foreach(KeyValuePair<ItemInfo, int> _kvp in LocalPlayer.Instance.Inventory.Items)
        {
            InventoryItemButton _button = Instantiate(
                itemButtonPrefab,
                itemButtonsContainer
                );
            _button.Item = _kvp.Key;
            _button.Quantity = _kvp.Value;
        }
    }

    void ClearPanel()
    {
        foreach (InventoryItemButton _button in itemButtonsContainer.GetComponentsInChildren<InventoryItemButton>())
        {
            _button.transform.SetParent(null);
            Destroy(_button.gameObject);
        }
    }
}
