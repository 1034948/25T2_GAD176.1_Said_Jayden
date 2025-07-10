using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPSGame
{
    public class MedkitBehaviours : MonoBehaviour
    {
        [SerializeField] PlayerInventory inventory;

        public void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player") == true)
            {
                Debug.Log("Potion accquired");
                Destroy(gameObject);
                inventory.GetComponent<PlayerInventory>().CollectPotion();
            }
        }
    }
}