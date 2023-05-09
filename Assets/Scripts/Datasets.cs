using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Datasets : MonoBehaviour
{
    public static Datasets Instance;

    public ItemInfo[] Items;
    public Dictionary<ItemInfo, int> GetItemID = new Dictionary<ItemInfo, int>();

    public LocationInfo[] Locations;
    public Dictionary<LocationInfo, int> GetLocationID = new Dictionary<LocationInfo, int>();

    void Start()
    {
        if(Datasets.Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    public void OnAfterSerialization()
    {
        GetItemID = new Dictionary<ItemInfo, int>();
        for (int _i = 0; _i < Items.Length; _i++)
            GetItemID.Add(Items[_i], _i);

        GetLocationID = new Dictionary<LocationInfo, int>();
        for (int _i = 0; _i < Locations.Length; _i++)
            GetLocationID.Add(Locations[_i], _i);
    }

}
