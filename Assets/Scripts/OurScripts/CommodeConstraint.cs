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

    private Vector3 InteractorLastPosition = new Vector3(0,0,0); 
    
    private float[] TiroirMinMaxValue = new[] {-1.17f, -0.608f};
    

    protected  override void Start()
    {
        base.Start();
        
        _tiroirBasePosition = tiroir.localPosition;
        _tiroirBaseRotation = tiroir.rotation; 
    }

    protected override void ActionContinious(Vector3 LocalInteractorVector3)
    {
        if (InteractorLastPosition.z ==  0)
        {
            InteractorLastPosition = LocalInteractorVector3;
        }

     
        base.ActionContinious(LocalInteractorVector3); // ???
     
        float movement = LocalInteractorVector3.z - InteractorLastPosition.z ;
      
    

        tiroir.rotation = _tiroirBaseRotation;
        tiroir.localPosition = new Vector3(_tiroirBasePosition.x, _tiroirBasePosition.y,
            math.clamp(tiroir.localPosition.z + movement, -1.17f, -0.608f)); 
        
        
        InteractorLastPosition = LocalInteractorVector3; 
        
    }
}
