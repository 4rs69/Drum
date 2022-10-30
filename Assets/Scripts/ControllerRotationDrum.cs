using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ControllerRotationDrum : MonoBehaviour
{ 
   [SerializeField]
   private float targetVelocitySpeed = 100f;
   
   private HingeJoint _hingeJoint;

   public void Awake()
   {
      _hingeJoint = GetComponent<HingeJoint>();
   }

   public void StartMove()
   {
      var motor = Motor();

      motor.targetVelocity = targetVelocitySpeed;
      
      NewMotor(motor);
      
      
   }

   public void StopMove()
   {
      var motor = Motor();

      motor.targetVelocity = 0f;
      
      NewMotor(motor);
   }

   public void ReversMove()
   {

      var motor = Motor();
      motor.targetVelocity = -targetVelocitySpeed;
      NewMotor(motor);

      targetVelocitySpeed = -targetVelocitySpeed;

   }

   public JointMotor Motor()
   {
      return _hingeJoint.motor;
   }

   private void NewMotor(JointMotor motor)
   {
      _hingeJoint.motor = motor;
   }
   
   
}
