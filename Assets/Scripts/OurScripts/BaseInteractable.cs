using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class BaseInteractable : InteractableOver
{
  
    [SerializeField]protected bool actionInstantanee = true;
    protected bool InteractableIsSelected = false;  
    protected  Transform InteractorTransform;

 

    protected  override  void OnEnable()
    {
        base.OnEnable();
        
        Interactable.selectEntered.AddListener(StartSelect);
        Interactable.selectExited.AddListener(StopSelect);
    }

    protected override void OnDisable()
    {
        base.OnDisable();
        
        Interactable.selectEntered.RemoveListener(StartSelect);
        Interactable.selectExited.RemoveListener(StopSelect);
       
    }

    protected  void StartSelect(SelectEnterEventArgs args)
    {
        if (!actionInstantanee)
        {
            InteractorTransform = args.interactorObject.transform;
            InteractableIsSelected = true;
         
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
            InteractableIsSelected = false; 
            InteractorTransform = null;
         
        }
        
    }

    protected virtual void ActionInstant()
    {
        
    }
    
    
    protected virtual void ActionContinious(Vector3 LocalInteractorVector3)
    {
        
    }
    
    private void Update()
    {
        if(InteractableIsSelected)
        {
            ActionContinious(InteractorTransform.position);
        }
    }
    
    
}
