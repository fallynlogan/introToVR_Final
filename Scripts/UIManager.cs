using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SceneManager.LoadScene("selectSong");
            Debug.Log("Fire1 triggered");
            SceneManager.LoadScene("selectSong");
        }
    }

}
