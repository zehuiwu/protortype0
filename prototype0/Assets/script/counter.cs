using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class counter : MonoBehaviour
{
    public int score = 0;
    public void increaseScore()
    {
        score += 1;
    }
}
