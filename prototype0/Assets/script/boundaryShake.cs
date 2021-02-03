using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class boundaryShake : MonoBehaviour
{
    public float magnitude = 3f;
    public counter count;
    private void OnCollisionEnter2D()
    {
        CameraShaker.Instance.ShakeOnce(magnitude, 4f, .1f, 1f);
        count.increaseScore();
    }
}
