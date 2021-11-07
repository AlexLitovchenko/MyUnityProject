using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Our_word : MonoBehaviour
{
    [SerializeField] private InputField InputName;

    public void Value()
    {
        if (InputName.text == "")
        {
            Debug.Log("Error");
        }
        else
        {
            TextMenu.our_word = InputName.text;
            
            Debug.Log(TextMenu.our_word);
        }
    }

  
}
