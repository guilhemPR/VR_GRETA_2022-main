using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class CommodeConstraint : BaseInteractable
{
    public Transform tiroir; 
    
    private Vector3 _tiroirBasePosition;
    private Quaternion _tiroirBaseRotation;

    private Vector3 InteractorLastPosition; 
    
    private float[] TiroirMinMaxValue = new[] {-1.17f, -0.608f};

    private void Start()
    {
        _tiroirBasePosition = tiroir.position;
        _tiroirBaseRotation = tiroir.rotation; 
    }

    protected override void ActionContinious(Vector3 LocalInteractorVector3)
    {
     
        
        base.ActionContinious(LocalInteractorVector3); // ???

        float movement =LocalInteractorVector3.z - InteractorLastPosition.z ;

        tiroir.rotation = _tiroirBaseRotation;
        tiroir.position = new Vector3(_tiroirBasePosition.x, _tiroirBasePosition.y,
            math.clamp(movement, TiroirMinMaxValue[1], TiroirMinMaxValue[2])); 
        
        
        InteractorLastPosition = LocalInteractorVector3; 
        
    }
}
