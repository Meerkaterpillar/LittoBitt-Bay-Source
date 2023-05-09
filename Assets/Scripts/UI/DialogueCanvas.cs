using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueCanvas : UICanvas
{
    [Space(5f)]
    [Header("Dialogue Canvas")]
    [SerializeField] TMP_Text titleLabel;
    [SerializeField] TMP_Text dialogueLabel;

    [SerializeField] RectTransform mapRect;
    [SerializeField] Vector2 mapOffset;

    public override void Start()
    {
        base.Start();
    }

    private void Update()
    {
        if (!base.IsOpen) return;

        if(Input.GetMouseButtonDown(0))
            AdvanceDialogue();
    }

    public void AdvanceDialogue()
    {
        Game.Instance.DialogueReader.GoToNextNode();
        if (Game.Instance.DialogueReader.GetCurrentNodeName() != "END")
        {
            dialogueLabel.text = Game.Instance.DialogueReader.GetNodeDialogue();
            Open();
        }
        else
            Close();
    }

    public LocationButton LocationButton
    {
        set
        {
            LocationInfo = value.LocationInfo;
            mapRect.anchoredPosition = -value.GetComponent<RectTransform>().anchoredPosition + mapOffset;
        }
    }

    public LocationInfo LocationInfo
    {
        set
        {
            titleLabel.text = value.name;
            Game.Instance.DialogueReader.SetTree(value.dialogueTree);
            Game.Instance.DialogueReader.StartTree(0);
            AdvanceDialogue();
            base.Open();
        }
    }

}
