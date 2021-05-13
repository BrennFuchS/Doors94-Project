using System;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    public GameObject model;
    public GameObject caliperModel;

    public bool tirePuncture;

    public bool onGroundDown;

    public float mass = 50f;
    public float radius = 0.34f;
    public float rimRadius;
    public float width = 0.2f;
	
    public float brakeFrictionTorque = 1500f;

    public float wheelFrictionTorque;
    public float brake;
    public float handbrake;
    public float steering;

    public float compression;

    public float normalForce;
}