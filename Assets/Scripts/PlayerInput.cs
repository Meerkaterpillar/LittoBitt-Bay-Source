using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
            RaycastGround();
    }

    void RaycastGround()
    {
        Ray _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit _hit;
        if(Physics.Raycast(
            _ray.origin,
            _ray.direction,
            out _hit, 
            500f,
            Game.Instance.GroundMask
            ))
        {
            LocalPlayer.Instance.Character.SetDestination(_hit.point);
        }
    }
}
