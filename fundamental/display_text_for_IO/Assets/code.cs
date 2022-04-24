using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class code : MonoBehaviour
{

    public GameObject textDisplay;
    public GameObject Input;

    public string theName;

    public void StoreName()
    {
        theName = Input.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = "welcome > " + theName + " < to the game";
    }





}
