using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFlying : MonoBehaviour
{
    public int flyingEnemyHealth = 150;

    // Update is called once per frame
    void Update()
    {
        if (flyingEnemyHealth == 0)
        {
            Destroy(gameObject);
        }
    }

    public void FlyingEnemyHit()
    {
        flyingEnemyHealth -= 10;
    }
}
