using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject BladeHitBox;


    public int enemyHealth = 100;

    // Update is called once per frame
    void Update()
    {
        if (enemyHealth == 0)
        {
            Destroy(gameObject);
        }
    }

    public void EnemyHit()
    {
        enemyHealth -= 10;
    }

    public void EnemyMeleeHit()
    {
        enemyHealth -= 20;
        BladeHitBox.SetActive(false);
        Debug.Log("EnemyHit");
    }
}
