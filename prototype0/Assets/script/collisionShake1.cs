using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using EZCameraShake;

public class collisionShake1 : MonoBehaviour
{   bool alrealdyShake = false;
    public float magnitude = 3f;
    private void OnCollisionEnter2D()
    {
        
        if (!alrealdyShake)
        {
            CameraShaker.Instance.ShakeOnce(magnitude, 4f, .1f, 1f);
            alrealdyShake = true;
        }

        
    }
}
