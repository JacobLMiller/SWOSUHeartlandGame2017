using UnityEngine;
using System.Collections;

public class TriggerLaunch : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(GameObject Other)
    {
        if (Other.tag == "Player")
        {

            Vector3 launch = new Vector3(0.0f, 50.0f, 0.0f);
            rb.AddForce(launch);

        }
    }
}