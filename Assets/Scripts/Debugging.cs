using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Debugging : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.L))
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            int nextSceneIndex = currentSceneIndex +1;

            if (nextSceneIndex == SceneManager.sceneCountInBuildSettings) {
                nextSceneIndex = 0;
            } 
            SceneManager.LoadScene(nextSceneIndex);
        }
        else if (Input.GetKey(KeyCode.C))
        {
            GetComponent<BoxCollider>().enabled = !GetComponent<BoxCollider>().enabled;
        }
    }
}
