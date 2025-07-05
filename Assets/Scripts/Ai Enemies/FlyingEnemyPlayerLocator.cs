using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Object flies around using physics based on target direction
/// </summary>
public class FlyingEnemyPlayerLocator : MonoBehaviour
{
    [Header("Core Properties")]
    [SerializeField] private Rigidbody sphere;

    [Header("AI Functionality")]
    [SerializeField] private bool isCurrentlyChasing;
    [SerializeField] private GameObject chaseTarget;


    private void FixedUpdate()
    {
        //AI chasing movement
        //We need a target
        //We want to move towards the target
        if (sphere.velocity.magnitude < 2.5)
        {
            //Need to know the DIRECTION from ME (the AI) to the TARGET (the PLAYER)
            //The Vector maths is
            //target.position - me.position
            sphere.AddForce(chaseTarget.transform.position - gameObject.transform.position);
        }
    }

}
