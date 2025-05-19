using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieCollision : MonoBehaviour
{
    AudioManager audioManager;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Bullet")
        {
            Debug.Log("A Zombie has dead!");
            Destroy(this.gameObject, 0.5f);
            audioManager.PlaySFX(audioManager.death);
        }
    }
}
