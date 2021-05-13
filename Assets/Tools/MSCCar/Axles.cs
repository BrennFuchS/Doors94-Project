using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Axles : MonoBehaviour
{
	public Axle frontAxle = new Axle();
	public Axle rearAxle = new Axle();
	public Axle[] otherAxles = new Axle[0];
}

[Serializable]
public class Axle
{
    public Wheel leftWheel;
    public Wheel rightWheel;
    public bool powered;
    public float suspensionTravel = 0.2f;
    public float suspensionRate = 20000f;
    public float bumpRate = 4000f;
    public float reboundRate = 4000f;
    public float fastBumpFactor = 0.3f;
    public float fastReboundFactor = 0.3f;
    public float antiRollBarRate = 10000f;
    public float brakeFrictionTorque = 1500f;
    public float handbrakeFrictionTorque;
    public float maxSteeringAngle;
    public float forwardGripFactor = 1f;
    public float sidewaysGripFactor = 1f;
    public float camber;
    public float caster;
    public CarDynamics.Tires tires;
    public float tiresPressure = 200f;
    public float optimalTiresPressure = 200f;
}
