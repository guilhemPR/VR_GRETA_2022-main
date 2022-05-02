using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class BaseInteractable : MonoBehaviour
{
    public XRSimpleInteractable Interactable;
    [SerializeField]private bool actionInstantanee = true;
    protected bool InteractableIsSelected = false;  
    protected  Vector3 InteractorVector3;
    
    private void OnEnable()
    {
        Interactable.selectEntered.AddListener(StartSelect);
        Interactable.selectExited.AddListener(StopSelect);
    }

    private void OnDisable()
    {
        Interactable.selectEntered.RemoveListener(StartSelect);
        Interactable.selectExited.RemoveListener(StopSelect);
       
    }

    protected  void StartSelect(SelectEnterEventArgs args)
    {
        if (!actionInstantanee)
        {
            InteractorVector3 = args.interactorObject.transform.position;
            InteractableIsSelected = true;
            ActionContinious(InteractorVector3);
        }
        else
        {
            ActionInstant();
        }
    }

    protected void StopSelect(SelectExitEventArgs args)
    {
        if (!actionInstantanee)
        {
            InteractorVector3 = Vector3.zero;
            InteractableIsSelected = false; 
        }
        
    }

    protected virtual void ActionInstant()
    {
        
    }
    
    
    protected virtual void ActionContinious(Vector3 LocalInteractorVector3)
    {
        
    }
    
    
}
