using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            Debug.Log(Input.inputString);
        }
        if (Input.GetButtonDown("Fire2"))
        {
            Debug.Log("Game Exited");
            SceneManager.LoadScene("selectSong");
        }
        
    }
}
