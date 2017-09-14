using UnityEngine;
using System.Collections;

public class AppearWhenDeactivated : MonoBehaviour {

    public GameObject trigger;
    public GameObject objectAppear;

    void Update()
    {
        if (!trigger.activeSelf)
        {
            objectAppear.gameObject.SetActive(true);
        }
    }

}
