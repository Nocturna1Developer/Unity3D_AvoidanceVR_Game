using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelChange : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        SceneManager.LoadScene(0);
    }
}