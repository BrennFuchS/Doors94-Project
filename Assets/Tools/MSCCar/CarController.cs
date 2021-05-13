using UnityEngine;

[RequireComponent(typeof(Axles))]
public abstract class CarController : MonoBehaviour
{
    public float brake;
    public float throttle;
    public float steering;

    public bool smoothInput = true;
    public float throttleTime = 0.1f;
    public float throttleReleaseTime = 0.1f;
    public float maxThrottleInReverse = 1f;
    public float brakesTime = 0.1f;
    public float brakesReleaseTime = 0.1f;
    public float steerTime = 0.1f;
    public float steerReleaseTime = 0.1f;
    public float veloSteerTime = 0.05f;
    public float veloSteerReleaseTime = 0.05f;
    public float steerCorrectionFactor;
    public bool steerAssistance = true;
    public float SteerAssistanceMinVelocity = 20f;
	
    public bool TCS = true;
    public float TCSAllowedSlip;
    public float TCSMinVelocity = 20f;

    public bool ABS = true;
    public float ABSAllowedSlip;
    public float ABSMinVelocity = 20f;

    public bool ESP = true;
    public float ESPStrength = 2f;
    public float ESPMinVelocity = 35f;
}
