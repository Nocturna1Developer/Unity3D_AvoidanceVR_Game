using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelChanger : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        SceneManager.LoadScene(1);
    }
}
