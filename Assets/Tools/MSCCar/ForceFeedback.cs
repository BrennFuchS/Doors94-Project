// ForceFeedback
using System.Runtime.InteropServices;
using UnityEngine;

public class ForceFeedback : MonoBehaviour
{
    public int factor = 1000;
    public float multiplier = 0.5f;
    public float smoothingFactor = 0.5f;
    public int clampValue = 20;
    public bool invertForceFeedback;
}
