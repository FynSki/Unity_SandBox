using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeTest : MonoBehaviour
{
    public bool isActive;
    public LayerMask whatIsGround;
    private Collider2D myCollider;

    public float moveSpeed;

    public Rigidbody2D myRgr;

    public bool onEnter;
    public bool onStay;
    public bool onExit;



    // Start is called before the first frame update
    void Start()
    {
        myRgr = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        isActive = Physics2D.IsTouchingLayers(myCollider, whatIsGround);
        MoveHorizontalRigh();
        MoveHorizontalLeft();
        MoveVertical();
    }

    public void MoveHorizontalRigh()
    {
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            //zmiana połozenia odnośnie nowego położenia
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
            
        }

    }
    public void MoveHorizontalLeft()
    {
        if (Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            //zmiana połozenia odnośnie nowego położenia
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * (moveSpeed / 2) * Time.deltaTime, 0f, 0f));
            
        }

    }

    public void MoveVertical()
    {
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            //zmiana połozenia odnośnie nowego położenia
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
        }
    }


  
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "sea")
        {
            onEnter = true;

        }
    }
   
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("sea"))
        {
            onStay = true;

        }
    }


    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("sea"))
        {
            onExit = true;
        }
    }

}
