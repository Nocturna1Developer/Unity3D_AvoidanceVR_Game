using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public TextMesh infotext;

    public Player player;

    private float gameTimer = 0f;
    private float restartTimer = 3f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (player.reachedFinishline == false)
        {
            gameTimer = Time.deltaTime;

            infotext.text = "Avoid the rocks by jumping over them!\nTime: " + Mathf.Floor(gameTimer)  + " seconds!";   
        } else {
            infotext.text = "Avoid the rocks by jumping over them!\nYour time was: " + Mathf.Floor(gameTimer) + " seconds!";

            restartTimer -= Time.deltaTime;
            
            if (restartTimer <= 0f)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
