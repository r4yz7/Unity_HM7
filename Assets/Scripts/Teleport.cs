using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public int SceneId = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<HeroMove>() != null)
        {
            SceneManager.LoadScene(SceneId); 
        }
    }
}
