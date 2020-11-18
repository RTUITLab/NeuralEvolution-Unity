using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HogMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 10f;

    private Rigidbody rbHog;
    private Vector3 rotation;

    private Animator Boar_anim;



    private void Start()
    {
        rbHog = GetComponent<Rigidbody>();
        rotation = new Vector3(0, 45f, 0);
        Boar_anim = GetComponentInChildren<Animator>();
    }

    public void Move(Action action)
    {
        switch (action.Action_)
        {
            case 0:
                //Debug.Log("Action 0");
                Boar_anim.SetBool("Walk", false);
                break;
            case 1:
                //Debug.Log("Action 1");
                rbHog.AddForce(transform.forward * speed * Time.deltaTime, ForceMode.Impulse);
                Boar_anim.SetBool("Walk", true);
                break;
            case 2:
                //Debug.Log("Action 2");
                transform.Rotate(rotation * Time.deltaTime);
                Boar_anim.SetBool("Walk", false);
                break;
            case 3:
                //Debug.Log("Action 3");
                Boar_anim.SetBool("Walk", false);
                transform.Rotate(-rotation * Time.deltaTime);
                break;
            case 4:
                //Debug.Log("Action 4");
                Boar_anim.SetBool("Walk", false);
                break;
        }
    }
}
