using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingRod : MonoBehaviour
{
    Animator anim;
    SkinnedMeshRenderer[] rends;

    void Awake()
    {
        anim = GetComponent<Animator>();
        rends = GetComponentsInChildren<SkinnedMeshRenderer>();
    }

    public Animator Anim { get { return anim; } }
}
