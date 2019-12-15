using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class flashText2 : MonoBehaviour
{
    public float targetTime = 60f;
    bool gameOver = false;
    Text flashingText;
    void Start()
    {
        //get the Text component
        flashingText = GetComponent<Text>();
        //Call coroutine BlinkText on Start
        StartCoroutine(BlinkText());
    }

    void Update()
    {
        targetTime -= Time.deltaTime;
        Debug.Log(targetTime);
        Debug.Log(gameOver);

        if(targetTime == 1)
        {
            gameOver = true;
        }
    }
    //function to blink the text
    public IEnumerator BlinkText()
    {
        //blink it forever. You can set a terminating condition depending upon your requirement
        while (gameOver == false)
        {
            //set the Text's text to blank
            flashingText.text = "";
            //display blank text for 0.5 seconds
            yield return new WaitForSeconds(1f);
            //display “I AM FLASHING TEXT” for the next 0.10 seconds
            flashingText.text = "Time";
            yield return new WaitForSeconds(1f);
        }
    }
}
