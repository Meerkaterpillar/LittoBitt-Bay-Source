using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    public static CanvasManager Instance;

    public InventoryCanvas InventoryCanvas;
    public DialogueCanvas DialogueCanvas;

    void Start()
    {
        if(CanvasManager.Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

}
