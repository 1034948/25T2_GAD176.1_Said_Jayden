using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleSwitch : MonoBehaviour
{
    public GameObject Reticle;

    [SerializeField] private bool ReticleSettingOn = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse2))
        {
            if (ReticleSettingOn == true)
            {
                ReticleSettingOn = false;

                Reticle.SetActive(false);
            }
            else
            {
                ReticleSettingOn = true;

                Reticle.SetActive(true);
            }
        }
    }
}
