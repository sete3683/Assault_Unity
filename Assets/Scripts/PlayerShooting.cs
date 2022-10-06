using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private ParticleSystem shootingParticle;
    private ParticleSystem.EmissionModule bulletEmission;
    private bool isShooting = false;

    private void Start()
    {
        bulletEmission = shootingParticle.emission;
    }

    void OnShoot(InputValue value)
    {
        isShooting = value.isPressed;
        bulletEmission.enabled = isShooting;
    }
}
