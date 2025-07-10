using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPSGame
{
    public class PlayerInventory : MonoBehaviour, ICollectPotions
    {

        //Stat for amount of Ammo players will have
        public int ammo = 0;
        //Stat for medkit shows amount of potions you have
        public int amountOfPotions = 0;

        public void CollectPotion()
        {
            amountOfPotions =+ 1;

            Debug.Log("POTION!");
        }

        public void CollectAmmo()
        {
            ammo =+ 50;

            Debug.Log("AMMO!");
        }

        public void ShootGun()
        {

        }
    }
}