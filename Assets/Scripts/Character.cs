using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] float animSpeedDamping = 0.1f;

    Animator anim;
    CharacterMotor motor;
    float targetAnimSpeed;

    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        motor = GetComponent<CharacterMotor>();
    }

    private void Update()
    {
        float _currentAnimSpeed = Mathf.Lerp(
            anim.GetFloat("Speed"),
            targetAnimSpeed,
            Time.deltaTime / animSpeedDamping
            );
        anim.SetFloat("Speed", _currentAnimSpeed);
    }

    public void SetDestination(Vector3 _position)
    {
        targetAnimSpeed = 1f;
        motor.SetDestination(_position);
    }

    public void ReachedDestination()
    {
        targetAnimSpeed = 0f;
    }

    public Animator Anim { get { return anim; } }

    public CharacterMotor Motor { get { return motor; } }
}
