using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class flashText : MonoBehaviour
{
    Text flashingText1;
    void Start()
    {
        //get the Text component
        flashingText1 = GetComponent<Text>();
        //Call coroutine BlinkText on Start
        StartCoroutine(BlinkText1());
    }
    //function to blink the text
    public IEnumerator BlinkText1()
    {
        //blink it forever. You can set a terminating condition depending upon your requirement
        while (true)
        {
            //set the Text's text to blank
            flashingText1.text = "";
            //display blank text for 0.5 seconds
            yield return new WaitForSeconds(1f);
            //display “I AM FLASHING TEXT” for the next 0.10 seconds
            flashingText1.text = "Press A";
            yield return new WaitForSeconds(1f);
        }
    }
}
