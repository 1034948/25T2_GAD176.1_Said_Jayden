using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsCasting : MonoBehaviour
{
    public float raycastDistance = 10;

    void Update()
    {
        RayCast();
    }

    public void RayCast()
    {
        Debug.DrawRay(transform.position, transform.forward);

        RaycastHit hit; //Store the thing I hit

        if (Physics.Raycast(transform.position, transform.forward, out hit, raycastDistance))
        {
            if (hit.transform.GetComponent<Enemy>())
            Debug.Log("You hit something");
        }
    }
}
