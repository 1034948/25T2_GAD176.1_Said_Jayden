using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsCasting : MonoBehaviour
{
    [SerializeField] Enemy Enemy;
    [SerializeField] EnemyFlying FlyingEnemy;


    public float raycastDistance = 50;

    void Update()
    {
        //RayCast();
    }

    public void RayCast()
    {
        Debug.DrawRay(transform.position, transform.forward);

        RaycastHit hit; //Store the thing I hit

        if (Physics.Raycast(transform.position, transform.forward, out hit, raycastDistance))
        {
            Debug.Log("You hit something");


            if (hit.transform.GetComponent<Enemy>())
            {
                Debug.Log("You hit an enemy");
                Enemy.GetComponent<Enemy>().EnemyHit();
            }

            if (hit.transform.GetComponent<EnemyFlying>())
            {
                Debug.Log("You hit a drone");
                FlyingEnemy.GetComponent<EnemyFlying>().FlyingEnemyHit();
            }
        }
    }
}
