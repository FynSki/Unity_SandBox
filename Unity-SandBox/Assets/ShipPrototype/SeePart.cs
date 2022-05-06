using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeePart : MonoBehaviour
{

    public int dept;
    public float currX;
    public float currY;

    public GameObject ships;
    public ShipScr shipScr;
    public bool isActive;

    public float disX;
    public float disY;

    public float shipXdir;
    public float shipYdir;


    // Start is called before the first frame update
    void Start()
    {
        shipScr = FindObjectOfType<ShipScr>();
        ships = GameObject.FindWithTag("Player");
        currX = transform.localPosition.x;
        currY = transform.localPosition.y;
        checkDistance();
    }

    // Update is called once per frame
    void Update()
    {
        checkDistance();
        ships = GameObject.FindWithTag("Player");
        shipXdir = ships.transform.localPosition.x;
        shipYdir = ships.transform.localPosition.y;
    }

    public void checkDistance()
    {
        disX = currX - ships.transform.localPosition.x;
        disY = currY - ships.transform.localPosition.y;
    }

    public void IsActiveCheck()
    {
        if(disX <= 1 && disX >= -1 && disY <= 1 && disY >= -1)
        {
            isActive = true;
            shipScr.moveToLocation(currX, currY);
        }
    }

    void OnMouseDown()
    {
        ships = GameObject.FindWithTag("Player");
        shipScr.GetDept(dept);
        checkDistance();
        IsActiveCheck();

    }



}
