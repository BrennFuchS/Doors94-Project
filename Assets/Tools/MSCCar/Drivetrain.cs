using System;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Axles))]
public class Drivetrain : MonoBehaviour
{
    public enum Transmissions { RWD, FWD, AWD, XWD }

    public float maxPower = 210f;
    public float maxPowerRPM = 5000f;
    public float maxTorque = 360f;
    public float maxTorqueRPM = 2500f;

    public float minRPM = 1000f;
    public float maxRPM = 6000f;
    public bool canStall;

    public bool revLimiter;
    public float revLimiterTime = 0.1f;

    public float engineInertia = 0.3f;
    public float drivetrainInertia = 0.02f;

    public float engineFrictionFactor = 0.25f;
    public Vector3 engineOrientation = Vector3.forward;
    public Transmissions transmission;

    public float[] gearRatios = new float[7] { -1f, 0f, 1f, 2f, 3f, 4f, 5f };

    public float finalDriveRatio = 6f;
    public float differentialLockCoefficient = 1f;
    public bool shifter;
    public bool automatic = true;
    public bool autoReverse = true;
    public float shiftDownRPM = 2000f;
    public float shiftUpRPM;
    public float shiftTime = 0.5f;
    public float clutchMaxTorque;
    public bool autoClutch = true;
    public float engageRPM = 1500f;
    public float disengageRPM = 1000f;
    public float _fuelConsumptionAtCostantSpeed = 4.3f;
    public float _fuelConsumptionSpeed = 130f;
    public float currentConsumption;

    public float clutchEngageSpeed;
	
    public int gear = 1;
    public float rpm;
}