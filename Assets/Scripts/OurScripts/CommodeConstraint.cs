using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class CommodeConstraint : MonoBehaviour
{
    private Vector3 _tiroirPosition;

    private void Start()
    {
        _tiroirPosition = transform.position;
    }

    void Update()
    {
        transform.position = new Vector3(_tiroirPosition.x, _tiroirPosition.y, math.clamp(transform.position.z,_tiroirPosition.z, -1f));

        
    }
}
