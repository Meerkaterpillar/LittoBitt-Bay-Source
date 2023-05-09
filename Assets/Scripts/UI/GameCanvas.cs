using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameCanvas : UICanvas
{
    [SerializeField] Button inventoryButton;

    public override void Start()
    {
        base.Start();
        inventoryButton.onClick.AddListener(() => CanvasManager.Instance.InventoryCanvas.Toggle());
    }
}
