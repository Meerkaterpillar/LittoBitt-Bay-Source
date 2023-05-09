using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalPlayer : MonoBehaviour
{
    public static LocalPlayer Instance;

    [SerializeField] FishingRod fishingRod;

    Character character;
    Inventory inventory;

    // Start is called before the first frame update
    void Start()
    {
        if(LocalPlayer.Instance != null)
            Destroy(LocalPlayer.Instance.gameObject);

        Instance = this;
        character = GetComponent<Character>();
        inventory = new Inventory();
        IsFishing = false;

        TempAddInventory();
    }

    // duct tape - temporary
    void TempAddInventory()
    {
        foreach (ItemInfo _item in Datasets.Instance.Items)
            inventory.Items.Add(_item, Random.Range(1, 5));

        Debug.Log(inventory.Items.Count);
    }

    public bool IsFishing
    {
        set
        {
            character.Motor.ReachedDestination();
            character.Anim.SetBool("Is Fishing", value);
            fishingRod.gameObject.SetActive(value);
            fishingRod.Anim.SetBool("Is Fishing", value);
        }
    }

    public Character Character { get { return character; } }

    public Inventory Inventory { get { return inventory; } }
}

[System.Serializable]
public class Inventory
{
    public Dictionary<ItemInfo, int> Items = new Dictionary<ItemInfo, int>();
}
