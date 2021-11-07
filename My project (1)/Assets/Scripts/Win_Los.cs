using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win_Los : MonoBehaviour
{
    [SerializeField]
    private GameObject obj;
    public GameObject True_Zone;
    private int ind;

    // Start is called before the first frame update
    void Start()
    {
        
        ind = obj.name.Length - 7;
        obj.name = obj.name.Remove(ind, 7);
  

    }

    // Update is called once per frame
   
    void FixedUpdate()
    {

        if (Input.anyKey == true)
        {
            
            
            if (TextMenu.our_word.ToLower() == obj.name.ToLower())
            {
                if ((obj.transform.position.y <= True_Zone.transform.position.y + True_Zone.transform.localScale.y / 2) && (obj.transform.position.y >= True_Zone.transform.position.y - True_Zone.transform.localScale.y / 2) && (obj.transform.position.x <= True_Zone.transform.position.x + True_Zone.transform.localScale.x / 2) && (obj.transform.position.x >= True_Zone.transform.position.x - True_Zone.transform.localScale.x / 2))
                {
                   // SceneManager.LoadScene(2);
                    Application.LoadLevel("Win");
                }
                else
                {
                   // SceneManager.LoadScene(3);
                    Application.LoadLevel("Lose");
                }
            }

        }
        

    }

    
}
