using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSScript : BaseInteractable
{
    public bool LightState = true;
    public GameObject SpotLight;
    public Renderer Plafonier;

    protected override void ActionInstant()
    {
       fonctionTest();
    }

    public void fonctionTest()
    {
        
      
            LightState = !LightState;


            if (!LightState)
            {
              Debug.Log("ça marche");
                SpotLight.SetActive(false);
                Plafonier.material.DisableKeyword("_EMISSION");
                
            }

            if (LightState)
            {
                Debug.Log("ça s'eteint");
                SpotLight.SetActive(true);
                Plafonier.material.EnableKeyword("_EMISSION");
            }
        
       
    }
}
