
using UnityEngine;


public class StopRotation : MonoBehaviour
{
    private HingeJoint _hingeJoint;



    private void Awake()
    {
        _hingeJoint = GetComponent<HingeJoint>();
    }

    public void StopRotationDrum()
    {
        var hingeJointMotor = _hingeJoint.motor;
        hingeJointMotor.targetVelocity = 0f;
        _hingeJoint.motor = hingeJointMotor;
    }


}
