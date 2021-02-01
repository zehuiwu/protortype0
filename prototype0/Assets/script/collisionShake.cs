using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using EZCameraShake;

public class collisionShake : MonoBehaviour
{   bool alrealdyShake = false;
    public float magnitude = 3f;
    public counter count;
    private void OnCollisionEnter2D()
    {
        
        if (!alrealdyShake)
        {
            CameraShaker.Instance.ShakeOnce(magnitude, 4f, .1f, 1f);
            alrealdyShake = true;
            count.increaseScore();
        }

        
    }
}
