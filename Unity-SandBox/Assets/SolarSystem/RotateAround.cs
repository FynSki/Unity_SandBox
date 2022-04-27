using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    // ========================================
    //	VARIABLES
    // ========================================
    public Transform rotationCenter;

    public float rotationRadius = 2f;
    public float angularSpeed = 2f;

    public float posX;
    public float posY;
    public float zDir;
    public float angle;

    public bool iaConstant;

    // ========================================
    //	START
    // ========================================
    void Start()
    {
        
    }

    // ========================================
    //	UPDATE
    // ========================================
    void Update()
    {
        if(iaConstant)
        {
            ConstantRotation();
        }
    }

    // ========================================
    //	FUNCTIONS
    // ========================================
    public void ConstantRotation()
    {
        posX = rotationCenter.position.x + Mathf.Cos(angle) * rotationRadius;
        posY = rotationCenter.position.y + Mathf.Sin(angle) * rotationRadius;
        transform.position = new Vector2(posX, posY);
        angle = angle + Time.deltaTime * (-1f * angularSpeed);

        if (angle >= 360f)
        {
            angle = 0f;
        }
    }

    public void RotationOnRound()
    {
        transform.Rotate(new Vector3(0, 0, zDir));
    }


    // END SCRIPT
}
