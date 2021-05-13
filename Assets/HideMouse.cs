using UnityEngine;
using System.Collections;

public class HideMouse : MonoBehaviour 
{
    void FixedUpdate()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
