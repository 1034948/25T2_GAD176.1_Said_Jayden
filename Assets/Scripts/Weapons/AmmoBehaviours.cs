using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBehaviours : MonoBehaviour
{
    [SerializeField] PlayerInventory inventory;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") == true)
        {
            Debug.Log("Ammo accquired");
            Destroy(gameObject);
            //other.GetComponent<PlayerInventory> ColletAmmo();
        }
    }
}
