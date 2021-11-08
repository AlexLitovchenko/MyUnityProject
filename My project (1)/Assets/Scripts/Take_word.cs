using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Take_word : MonoBehaviour
{
    [SerializeField] private Text _text;

    public void Awake()
    {
        _text.text = TextMenu.our_word;
    }
}
