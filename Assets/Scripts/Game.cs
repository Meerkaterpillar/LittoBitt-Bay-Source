using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public static Game Instance;

    public LayerMask GroundMask;

    EZPZ_Tree_Reader dialogueReader;

    // Start is called before the first frame update
    void Start()
    {
        if(Game.Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        dialogueReader = GetComponent<EZPZ_Tree_Reader>();
    }

    public EZPZ_Tree_Reader DialogueReader { get { return dialogueReader; } }

}
