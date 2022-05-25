using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipScr : MonoBehaviour
{
    public float baseMovement;
    public float movement;

    public float baseCapasity;
    public float capasity;

    public float BaseDipping;
    public float dipping;

    public int baseMoves;
    public int moves;

    public Vector3 newPosition;
    public float shipX;
    public float shipY;

    public bool canSwim;
    
    // Start is called before the first frame update
    void Start()
    {
        shipX = transform.localPosition.x;
        shipY = transform.localPosition.y;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StatUpdate()
    {
        movement = baseMovement - capasity;
        dipping = BaseDipping - capasity;
    }

    public void moveToLocation(float newX , float newY)
    {
        newPosition.x = newX;
        newPosition.y = newY;

       transform.position = newPosition;
        
    }

    

}
