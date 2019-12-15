using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdownTimer : MonoBehaviour
{
    public float targetTime = 60f;
    public Text countdownText;
    public Text gameoverText;
    public Text scoreText;
    public Text timeText;

    // Update is called once per frame
    void Update()
    {
        targetTime -= Time.deltaTime;
        //Debug.Log(targetTime);
        countdownText.text = targetTime.ToString();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            

        if(targetTime <= 0f )
        {
            timerEnded();
            countdownText.text = "Times up";
        }
    }

    void timerEnded()
    {
        //Debug.Log("the timer has ended");
        //Destroy(scoreText);
        Destroy(timeText);
        gameoverText.text = "Game Over";
    }
}
