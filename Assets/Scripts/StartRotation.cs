using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartRotation : MonoBehaviour
{
    private HingeJoint _hingeJoint;



    private void Awake()
    {
        _hingeJoint = GetComponent<HingeJoint>();
    }

    public void StartRotationDrum()
    {
        
      
            var hingeJointMotor = _hingeJoint.motor;
            hingeJointMotor.targetVelocity = 100f;
            _hingeJoint.motor = hingeJointMotor;
       
        
    }
}
