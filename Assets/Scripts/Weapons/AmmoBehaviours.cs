using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPSGame
{
    public class AmmoBehaviours : MonoBehaviour
    {
        [SerializeField] PlayerInventory inventory;

        public void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player") == true)
            {
                Debug.Log("Ammo accquired");
                Destroy(gameObject);
                other.GetComponent<PlayerInventory>().CollectAmmo();
            }
        }
    }
}