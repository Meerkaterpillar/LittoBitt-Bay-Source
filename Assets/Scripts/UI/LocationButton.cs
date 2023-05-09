using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LocationButton : MonoBehaviour
{
    [SerializeField] LocationInfo locationInfo;

    Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(() => OnClicked());
    }

    void OnClicked()
    {
        CanvasManager.Instance.DialogueCanvas.LocationButton = this;
    }

    public LocationInfo LocationInfo { get { return locationInfo; } }
}
