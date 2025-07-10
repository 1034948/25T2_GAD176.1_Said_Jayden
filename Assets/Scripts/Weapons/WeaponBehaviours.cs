using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPSGame
{
    public class WeaponBehaviours : MonoBehaviour
    {
        [SerializeField] PlayerInventory inventory;
        [SerializeField] PhysicsCasting Capsule;

        //Weapon Game Objects

        public GameObject Gun;
        public GameObject Blade;
        public GameObject Knife;
        public GameObject Potion;

        //Weapon selection squares

        public GameObject GunSelection;
        public GameObject BladeSelection;
        public GameObject KnifeSelection;
        public GameObject PotionSeletion;

        //Is Gun out??

        [SerializeField] private bool GunOut = false;
        [SerializeField] private bool PotionOut = false;

        void Start()
        {
            Gun.SetActive(true);
            Blade.SetActive(false);
            Knife.SetActive(false);
            Potion.SetActive(false);

            GunSelection.SetActive(true);
            BladeSelection.SetActive(false);
            KnifeSelection.SetActive(false);
            PotionSeletion.SetActive(false);

            GunOut = true;
            PotionOut = false;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                //Shows gun and removes other weapons

                Gun.SetActive(true);
                Blade.SetActive(false);
                Knife.SetActive(false);
                Potion.SetActive(false);

                GunSelection.SetActive(true);
                BladeSelection.SetActive(false);
                KnifeSelection.SetActive(false);
                PotionSeletion.SetActive(false);

                GunOut = true;
                PotionOut = false;

            }

            if (Input.GetKeyDown(KeyCode.Alpha3))
            {


                //Shows sword and removes other weapons

                Gun.SetActive(false);
                Blade.SetActive(true);
                Knife.SetActive(false);
                Potion.SetActive(false);

                GunSelection.SetActive(false);
                BladeSelection.SetActive(true);
                KnifeSelection.SetActive(false);
                PotionSeletion.SetActive(false);

                GunOut = false;
                PotionOut = false;

            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                //Shows knife and removes other weapons

                Gun.SetActive(false);
                Blade.SetActive(false);
                Knife.SetActive(true);
                Potion.SetActive(false);

                GunSelection.SetActive(false);
                BladeSelection.SetActive(false);
                KnifeSelection.SetActive(true);
                PotionSeletion.SetActive(false);

                GunOut = false;
                PotionOut = false;

            }

            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                //Shows potion and removes other weapons

                Gun.SetActive(false);
                Blade.SetActive(false);
                Knife.SetActive(false);
                Potion.SetActive(true);

                GunSelection.SetActive(false);
                BladeSelection.SetActive(false);
                KnifeSelection.SetActive(false);
                PotionSeletion.SetActive(true);

                GunOut = false;
                PotionOut = true;

            }

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (GunOut == true)
                {
                    Debug.Log("pew pew");
                    //GetComponent<PhysicsCasting>().RayCast();
                }
                else if (PotionOut == true)
                {
                    Debug.Log("Glug glug glug");
                }
                else
                {
                    Debug.Log("Slash");
                    
                }
            }

        }
    }

}