using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win_Los : MonoBehaviour
{
    [SerializeField]
    private GameObject _obj;
    public GameObject True_Zone;
    private int _ind;

    // Start is called before the first frame update
    void Start()
    {
        
        _ind = _obj.name.Length - 7;
        _obj.name = _obj.name.Remove(_ind, 7);
  

    }

    // Update is called once per frame
   
    void FixedUpdate()
    {

        if (Input.anyKey == true)
        {
            
            
            if (TextMenu.our_word.ToLower() == _obj.name.ToLower())
            {
                if ((_obj.transform.position.y <= True_Zone.transform.position.y + True_Zone.transform.localScale.y / 2) && (_obj.transform.position.y >= True_Zone.transform.position.y - True_Zone.transform.localScale.y / 2) && (_obj.transform.position.x <= True_Zone.transform.position.x + True_Zone.transform.localScale.x / 2) && (_obj.transform.position.x >= True_Zone.transform.position.x - True_Zone.transform.localScale.x / 2))
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
