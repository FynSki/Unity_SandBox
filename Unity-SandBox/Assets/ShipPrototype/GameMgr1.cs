using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr1 : MonoBehaviour
{
    public float newX;
    public float newY;

    public GameObject ships;
    public ShipScr shipScr;
    public float shipX;
    public float shipY;
    public bool isDeep;

    public bool isInRange;

    public int newDept;
    public GameObject deptInfo;

    
    
    // Start is called before the first frame update
    void Start()
    {
        ships = GameObject.FindWithTag("Player");
        shipScr = FindObjectOfType<ShipScr>();
    }

    // Update is called once per frame
    void Update()
    {
        ShipPosition();
    }

    public void ShipPosition()
    {
        shipX = ships.transform.localPosition.x;
        shipY = ships.transform.localPosition.y;
    }

    public void SetNewDir(float nXPos, float nYPos, int nDept )
    {
        newX = nXPos;
        newY = nYPos;
        newDept = nDept;
    }

    public void CheckDept()
    {
        if(shipScr.dipping <= newDept)
        {
            isDeep = true;
        }
        else
        {
            isDeep = false;
            deptInfo.SetActive(true);
        }
    }

    
    public void ShipMoving()
    {
        shipScr.moveToLocation(newX , newY);
    }
}
