using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selectSong : MonoBehaviour

    //find joystick and use that instead probably easier 
{

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            //Debug.Log(Input.inputString);
        }
        //load danceMonkey scene 
        if (Input.GetButtonDown("Fire3"))
        {
            //Debug.Log("load Dance Monkey");
            SceneManager.LoadScene("danceMonkey", LoadSceneMode.Single);
        }

        //load heyBB scene
        if(Input.GetButtonDown("Jump"))
        {
            //Debug.Log("load Hey BB");
            SceneManager.LoadScene("heyBB");
        }

        //load dealWivIt scene
        if (Input.GetButtonDown("Fire2"))
        {
            //Debug.Log("load Deal Wiv It");
            SceneManager.LoadScene("dealWivIt");
        }

        
    }
}
