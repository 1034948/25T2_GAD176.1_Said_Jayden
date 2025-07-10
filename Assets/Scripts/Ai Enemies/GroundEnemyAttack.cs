using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundEnemyAttack : MonoBehaviour
{
    [SerializeField] PlayerHealth Capsule;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") == true)
        {
            Debug.Log("Drone spots Player, ATTACK!");
            Capsule.GetComponent<PlayerHealth>().PlayerDamaged();
        }
    }
}
