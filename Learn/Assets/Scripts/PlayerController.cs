using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{


    public float speed=0;
    private Rigidbody rb;
    private float Count;
    private float movementX;
    private float movementY;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Count = 0;
        SetCountText();
        winTextObject.SetActive(false);
    }
    void SetCountText()
    {
        countText.text = "Count:" + Count.ToString();
        if(Count>=5)
        {
            winTextObject.SetActive(true);
        }
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;

        movementY = movementVector.y;
   }
    void FixedUpdate()
    {

        Vector3 movement = new Vector3(movementX, 0.0f, movementY); 

        rb.AddForce(movement*speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            Count++;
            SetCountText();
        }
    }
}
