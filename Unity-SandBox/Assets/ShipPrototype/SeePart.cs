using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeePart : MonoBehaviour
{
    private Rigidbody2D rgb2d;
    private Collider2D myCollider;

    public int dept;
    public float currX;
    public float currY;

    public GameMgr1 gameMgr;
    public bool isActive;


    // Start is called before the first frame update
    void Start()
    {
        rgb2d = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();
       

        gameMgr = FindObjectOfType<GameMgr1>();

        currX = transform.localPosition.x;
        currY = transform.localPosition.y;
       
    }

    void Update()
    {
        //isActive = Physics2D.IsTouchingLayers(myCollider, whatIsInRange);
        
    }

    void OnMouseDown()
    {
        gameMgr.SetNewDir(currX, currY, dept);
        gameMgr.CheckDept();
        //isActive = gameMgr.isDeep;
        if (isActive)
        {
            if(gameMgr.isDeep == true)
            {
                gameMgr.ShipMoving();
            }
        }
        
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("range"))
        {
            isActive = true;

        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("range"))
        {
            isActive = true;

        }
    }


    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("range"))
        {
            isActive = false;
        }
    }




}
