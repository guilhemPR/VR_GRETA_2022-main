using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSScript : BaseInteractable
{
    private bool LightState = false;
    public GameObject SpotLight;
    public Renderer Plafonier;

    protected override void ActionInstant()
    {
       fonctionTest();
    }

    public void fonctionTest()
    {
        
       Debug.Log("proute");
            LightState = !LightState;


            if (LightState == false)
            {
                SpotLight.SetActive(false);
                Plafonier.material.DisableKeyword("_EMISSION");
                
            }

            if (LightState)
            {
                SpotLight.SetActive(true);
                Plafonier.material.EnableKeyword("_EMISSION");
            }
        
       
    }
}
