using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPSGame
{
    public class PlayerInventory : MonoBehaviour, ICollectPotions
    {

        [SerializeField] PhysicsCasting PlayerCameraRoot;
        [SerializeField] PlayerHealth Capsule;

        //Stat for amount of Ammo players will have
        public int ammo = 50;
        //Stat for medkit shows amount of potions you have
        public int amountOfPotions = 0;

        public void CollectPotion()
        {
            amountOfPotions += 1;

            Debug.Log("POTION!");
        }

        public void CollectAmmo()
        {
            ammo += 50;

            Debug.Log("AMMO!");
        }

        public void ShootGun()
        {
            if (ammo >= 1)
            {
                Debug.Log("pew pew");
                PlayerCameraRoot.GetComponent<PhysicsCasting>().RayCast();
                ammo -= 1;
            }
            else
            {
                Debug.Log("You got no ammo");
            }
        }

        public void UsePotion()
        {
            if (amountOfPotions >= 1)
            {

                Debug.Log("Glug glug glug");
                Capsule.GetComponent<PlayerHealth>().RegenHealth();
                amountOfPotions -= 1;
            }
            else
            {
                Debug.Log("You got no potions");
            }
        }
    }
}