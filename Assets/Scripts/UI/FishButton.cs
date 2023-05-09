using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FishButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public void OnPointerDown(PointerEventData _data)
    {
        if (_data.button != PointerEventData.InputButton.Left) return;

        LocalPlayer.Instance.IsFishing = true;
    }

    public void OnPointerUp(PointerEventData _data)
    {
        if (_data.button != PointerEventData.InputButton.Left) return;

        LocalPlayer.Instance.IsFishing = false;
    }
}
