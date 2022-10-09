using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private GameObject CrashParticle;
    private bool isCrashed = false;

    void OnTriggerEnter(Collider other)
    {
        if (!isCrashed && other.tag == "Obstacle")
        {
            StartCoroutine(Crash());
        }
    }

    IEnumerator Crash()
    {
        isCrashed = true;

        GetComponentInParent<Animator>().enabled = false;
        GetComponent<PlayerMovement>().enabled = false;
        GetComponent<PlayerShooting>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = false;
        CrashParticle.SetActive(true);

        yield return new WaitForSeconds(3);

        SceneHandler.ReloadScene();
    }
}
