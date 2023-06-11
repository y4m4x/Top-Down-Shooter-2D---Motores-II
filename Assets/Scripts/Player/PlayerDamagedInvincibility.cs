using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamagedInvincibility : MonoBehaviour
{
    [SerializeField]
    private float _invincibilityDuration;

    private Invincibility _invincibility;

    private void Awake()
    {
        _invincibility = GetComponent<Invincibility>();
    }

    public void StartInvincibility()
    {
        _invincibility.StartInvincibility(_invincibilityDuration);
    }
}

