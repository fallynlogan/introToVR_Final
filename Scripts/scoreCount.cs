using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class scoreCount : MonoBehaviour
{
    int score = 0;
    bool hasDeleted = false;
    public Text scoreText;
    public AudioSource diamondBeep;
    public float targetTime = 60f;
    bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        diamondBeep = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //decrement time counter
        targetTime -= Time.deltaTime;

        //if the object deleted was a diamond increment score counter and change text on screen 
        if(hasDeleted == true & gameOver == false)
        {
            score++;
            scoreText.text = score.ToString();
            Debug.Log(score.ToString());

        }
            hasDeleted = false;

        if(targetTime <= 0)
        {
            gameOver = true;
        }

        if(gameOver == true)
        {
            Destroy(scoreText);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("in collision function");
        Debug.Log(collision.collider.gameObject.name);
        Destroy(collision.collider.gameObject);
        //Destroy(gameObject);
        if(collision.collider.gameObject.name == "diamond(Clone)")
        {
            diamondBeep.Play();
            Debug.Log("diamond deleted");
            hasDeleted = true;
        }
    }

}
