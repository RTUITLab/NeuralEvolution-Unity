using UnityEngine;

public class Food : MonoBehaviour
{
    public static bool isNear = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isNear = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isNear = false;
        }
    }
}
