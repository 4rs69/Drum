using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReversRotation : MonoBehaviour
{
    [SerializeField]
    private float _targetVelocity = -100f;
    
    private HingeJoint _hingeJoint;

    private void Awake()
    {
        _hingeJoint = GetComponent<HingeJoint>();
    }

    public void ReversRotationDrum()
    {
        
        var hingeJointMotor = _hingeJoint.motor;
        hingeJointMotor.targetVelocity = _targetVelocity;
        _hingeJoint.motor = hingeJointMotor;
        
    }
}
