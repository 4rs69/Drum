using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReversRotation : MonoBehaviour
{
    private HingeJoint _hingeJoint;



    private void Awake()
    {
        _hingeJoint = GetComponent<HingeJoint>();
    }

    public void ReversRotationDrum()
    {
        
        var hingeJointMotor = _hingeJoint.motor;
        hingeJointMotor.targetVelocity = -100f;
        _hingeJoint.motor = hingeJointMotor;
        
    }
}
