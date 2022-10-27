using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartRotation : MonoBehaviour
{
    private HingeJoint _hingeJoint;
    
    
    [SerializeField]
    private float _targetVelocity = 100f;



    private void Awake()
    {
        _hingeJoint = GetComponent<HingeJoint>();
    }

    public void StartRotationDrum()
    {
        
      
            var hingeJointMotor = _hingeJoint.motor;
            hingeJointMotor.targetVelocity = _targetVelocity;
            _hingeJoint.motor = hingeJointMotor;
       
        
    }
}
