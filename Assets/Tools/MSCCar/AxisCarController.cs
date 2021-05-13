using UnityEngine;

public class AxisCarController : CarController
{
	public string throttleAxis = "Throttle";
	public string brakeAxis = "Brake";
	public string steerAxis = "Horizontal";
	public string handbrakeAxis = "Handbrake";
	public string clutchAxis = "Clutch";
	public string shiftUpButton = "ShiftUp";
	public string shiftDownButton = "ShiftDown";
	public string startEngineButton = "StartEngine";

	public bool normalizeThrottleInput;
	public bool exponentialThrottleInput;
	public bool normalizeBrakesInput;
	public bool exponentialBrakesInput;
	public bool normalizeClutchInput;
	public bool exponentialClutchInput;
}