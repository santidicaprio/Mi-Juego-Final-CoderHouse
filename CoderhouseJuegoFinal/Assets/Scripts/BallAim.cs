using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallAim : MonoBehaviour
{
    [SerializeField] float rotateSpeed;


    private float _horizontalMove;
    private float _verticalMove;
    void Start()
    {

    }

    
    void Update()
    {
        Rotation();
    }

    void Rotation()
    {
        var rotationX = Input.GetAxisRaw("Mouse X") * rotateSpeed * Time.deltaTime;
        var rotationY = Input.GetAxisRaw("Mouse Y") * rotateSpeed * Time.deltaTime;

        transform.Rotate(rotationY, rotationX, 0f);
        

    }
}
