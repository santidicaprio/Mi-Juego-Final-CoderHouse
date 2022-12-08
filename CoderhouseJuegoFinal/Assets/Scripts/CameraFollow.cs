using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField] Transform target;

    private Vector3 _offSet;

    private void Start()
    {
        _offSet = transform.position - target.position;
    }

    private void Update()
    {
        transform.position = new Vector3(target.position.x + _offSet.x, target.position.y + _offSet.y, target.position.z + _offSet.z);
    }
}
