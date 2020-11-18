using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitalCamera : MonoBehaviour
{
    [SerializeField]
    private GameObject Target;
    [SerializeField]
    private Transform lookPosition;
    private Vector3 offset;
    private float deltaY;
    private float sensetivity = 3f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        offset = Target.transform.position - transform.position;    
    }

    void Update()
    {
        deltaY += Input.GetAxis("Mouse X") * sensetivity;
        Quaternion rotation = Quaternion.Euler(0,deltaY,0);
        transform.position = Target.transform.position - (rotation * offset);
        transform.LookAt(lookPosition.position);
    }
}
