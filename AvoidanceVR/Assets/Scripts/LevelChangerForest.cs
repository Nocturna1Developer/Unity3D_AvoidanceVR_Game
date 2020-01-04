using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelChangerForest : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        SceneManager.LoadScene(2);
    }
}