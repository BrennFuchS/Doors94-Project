using System;
using UnityEngine;

[RequireComponent(typeof(Axles))]
[RequireComponent(typeof(Rigidbody))]
public class CarDynamics : MonoBehaviour
{
    public enum Controller { axis, mouse, mobile, external }
    public enum SurfaceType { track, grass, sand, offroad, oil }
    public enum Tires {
        competition_front, competition_rear, supersport_front, supersport_rear, sport_front, sport_rear,
        touring_front, touring_rear, offroad_front, offroad_rear, truck_front, truck_rear
    }
	
    public Controller controller;
    public Transform centerOfMass;

    public float dampAbsRoadVelo = 8f;
    public float inertiaFactor = 1f;
    public float frontRearWeightRepartition = 0.5f;
    public float frontRearBrakeBalance = 0.65f;
    public float frontRearHandBrakeBalance;
    public bool enableForceFeedback;

    public Skidmarks skidmarks;
    public MyPhysicMaterial[] physicMaterials = new MyPhysicMaterial[4];
}

[Serializable]
public class MyPhysicMaterial
{
    public PhysicMaterial physicMaterial;
    public float grip = 1f;
    public float rollingFriction = 0.018f;
    public float staticFriction = 1f;
    public bool isSkidSmoke = true;
    public bool isSkidMark = true;
    public bool isDirty;
    public CarDynamics.SurfaceType surfaceType;
}