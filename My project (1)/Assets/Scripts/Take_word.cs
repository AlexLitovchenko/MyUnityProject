using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Take_word : MonoBehaviour
{
    [SerializeField] private Text text;

    public void Awake()
    {
        text.text = TextMenu.our_word;
    }
}
