using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class InteractableOver : MonoBehaviour
{
    public Renderer _objectRender; 
    public XRSimpleInteractable Interactable;




    protected virtual void OnEnable()
    {
        Interactable.hoverEntered.AddListener(StartHover);
        Interactable.hoverExited.AddListener(StopHover);
    }

    protected  virtual void OnDisable()
    {
        Interactable.hoverEntered.RemoveListener(StartHover);
        Interactable.hoverExited.RemoveListener(StopHover);
            
       
    }

    protected virtual void  Start()
    {
        _objectRender = gameObject.GetComponent<Renderer>(); 
    }
    

    protected void StartHover(HoverEnterEventArgs args)
    {
          
         
            _objectRender.material.EnableKeyword("_EMISSION");
            _objectRender.material.SetColor("_EmissionColor", Color.magenta);
    }
    
    protected void StopHover(HoverExitEventArgs args)
    {
        
         
        _objectRender.material.DisableKeyword("_EMISSION");
        _objectRender.material.SetColor("_EmissionColor", Color.black);
       
        
    }

 
    
    


}
