using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICanvas : MonoBehaviour
{
    [SerializeField] bool isOpenOnStart;
    Canvas canvas;

    public virtual void Start()
    {
        canvas = GetComponent<Canvas>();

        if (!isOpenOnStart)
            Close();
        else
            Open();
    }

    public virtual void Open()
    {
        canvas.enabled = true;
    }

    public virtual void Close()
    {
        canvas.enabled = false;
    }

    public void Toggle()
    {
        if (IsOpen)
            Close();
        else
            Open();
    }

    public bool IsOpen { get { return canvas.enabled; } }
}
