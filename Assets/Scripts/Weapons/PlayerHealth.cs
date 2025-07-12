using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    //[SerializeField] PlayerInventory Inventory;
    [SerializeField] GameObject Player;

    public int playerHealth = 100;

    public void PlayerDamaged()
    {
        playerHealth -= 5;
    }

    public void PlayerRangedDamaged()
    {
        playerHealth -= 10;
    }

    public void RegenHealth()
    {
        if (playerHealth <= 100)
        {
            playerHealth += 10;
        }
    }

    void Update()
    {
        if (playerHealth == 0)
        {
            Debug.Log("Game Over");
            Destroy(Player);
        }
    }
}
