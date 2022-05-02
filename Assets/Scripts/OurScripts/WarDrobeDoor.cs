using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Subsystems;
using UnityEngine.XR.Interaction.Toolkit;

public class WarDrobeDoor :BaseInteractable

{
    
    private float _MaxAngleValu = 90;
    private float _MinAngleValue = 1;
    private float _ActualAngleValue;

    private float FindAngleForRotate;
    private bool _doorLinked = false;
    private Vector3 InteractorTransform;
    
    

    [SerializeField] private Transform PlacardTransformPivot;

    private void Update()
    {
        ApplyRotation();
    }

    private void ApplyRotation()
    {
        if (_doorLinked==true)
        {

            _ActualAngleValue = PlacardTransformPivot.transform.eulerAngles.y;

            if (_ActualAngleValue < _MaxAngleValu && _ActualAngleValue > _MinAngleValue)
            {
                
                FindAngleForRotate = Vector3.SignedAngle(PlacardTransformPivot.forward, InteractorTransform, PlacardTransformPivot.up);
                print(FindAngleForRotate);

                PlacardTransformPivot.Rotate(0f, FindAngleForRotate, 0f);

            }
        }
       
    }

    public void EnableLink(SelectEnterEventArgs args)
    {
        _doorLinked = true;
        InteractorTransform = args.interactorObject.transform.position;
    }

    public void DisableLink()
    {
        _doorLinked = false;
        InteractorTransform = Vector3.zero;
    }
}
