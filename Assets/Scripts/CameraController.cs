using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float positionDamping = 0.1f;

    Vector3 refVelocity;

    void Start()
    {
        
    }

    void LateUpdate()
    {
        if (target == null) return;

        transform.position = Vector3.SmoothDamp(
            transform.position,
            target.position,
            ref refVelocity,
            positionDamping
            );
    }
}
