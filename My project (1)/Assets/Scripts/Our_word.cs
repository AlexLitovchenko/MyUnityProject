using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Our_word : MonoBehaviour
{
    [SerializeField] private InputField _InputName;

    public void Value()
    {
        if (_InputName.text == "")
        {
            Debug.Log("Error");
        }
        else
        {
            TextMenu.our_word = _InputName.text;
            
            Debug.Log(TextMenu.our_word);
        }
    }

  
}
