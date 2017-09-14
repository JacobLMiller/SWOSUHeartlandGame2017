using UnityEngine;//THis is going onto our player
using System.Collections;

public class Collision: MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}