using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private ParticleSystem crashParticle;
    [SerializeField] private int hp = 1;
    [SerializeField] private int score = 1;

    void OnParticleCollision()
    {
        if (--hp == 0)
        {
            Instantiate(crashParticle, transform.position, Quaternion.identity);
            ScoreManager.instance.AddScore(score);
            Destroy(gameObject);
        }
    }
}
