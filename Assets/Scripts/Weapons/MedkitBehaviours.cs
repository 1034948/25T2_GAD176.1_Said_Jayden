using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedkitBehaviours : MonoBehaviour
{
    [SerializeField] PlayerInventory inventory;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") == true)
        {
            Debug.Log("Potion accquired");
            Destroy(gameObject);
            //other.GetComponent<PlayerInventory> CollectPotion();
        }
    }
}
