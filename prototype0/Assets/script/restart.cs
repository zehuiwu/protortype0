using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class restart : MonoBehaviour
{
    [SerializeField] Text Cong;
    [SerializeField] Text score;
    public counter count;
    public float delay = 1f;
    private void OnCollisionEnter2D()
    {
        Cong.enabled = true;
        score.text = "Number of Collision: " + count.score.ToString();
        score.enabled = true;
        Invoke("Restart", delay);
        
  
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
