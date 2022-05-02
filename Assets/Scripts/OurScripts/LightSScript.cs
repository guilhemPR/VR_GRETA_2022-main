using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSScript : MonoBehaviour
{
    private bool LightState = false;
    public GameObject SpotLight;
    public Renderer Plafonier; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
