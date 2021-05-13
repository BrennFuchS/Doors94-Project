using System;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioClip engineThrottle;
    public float engineThrottleVolume = 0.35f;
    public float engineThrottlePitchFactor = 1f;

    public AudioClip engineNoThrottle;
    public float engineNoThrottleVolume = 0.35f;
    public float engineNoThrottlePitchFactor = 1f;

    public AudioClip startEngine;
    public float startEngineVolume = 1f;
    public float startEnginePitch = 1f;
    public GameObject enginePosition;

    public AudioClip transmission;
    public float transmissionVolume = 0.5f;
    public float transmissionVolumeReverse = 0.5f;
    public float transmissionSourcePitch = 1f;

    public AudioClip brakeNoise;
    public float brakeNoiseVolume = 0.2f;

    public AudioClip skid;
    public float skidVolume = 1f;
    public float skidPitchFactor = 1f;

    public AudioClip crashHiSpeed;
    public float crashHighVolume = 0.75f;

    public AudioClip crashLowSpeed;
    public float crashLowVolume = 0.7f;

    public AudioClip scrapeNoise;
    public float scrapeNoiseVolume = 1f;

    public AudioClip ABSTrigger;
    public float ABSTriggerVolume = 0.2f;

    public AudioClip shiftTrigger;
    public float shiftTriggerVolume = 1f;

    public AudioClip wind;
    public float windVolume = 1f;

    public AudioClip rollingNoiseGrass;
    public AudioClip rollingNoiseSand;
    public AudioClip rollingNoiseOffroad;
}
