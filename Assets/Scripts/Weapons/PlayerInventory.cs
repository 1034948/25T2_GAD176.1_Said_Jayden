using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class PlayerInventory : MonoBehaviour
    {

        //Stat for amount of Ammo players will have
        public int ammo = 0;
        //Stat for medkit shows amount of potions you have
        public int amountOfPotions = 0;

        public void CollectPotion()
        {
            amountOfPotions =+ 1;
        }

        public void CollectAmmo()
        {
            ammo = +1;
        }
    }