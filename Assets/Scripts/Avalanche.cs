using UnityEngine;
using System.Collections;

public class Avalanche : MonoBehaviour {

    private Transform start;

	// Use this for initialization
	void Awake () {
        start = transform;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");
        if (other.gameObject.CompareTag("Boundary")){
            transform.position = start.position;
        }
    }
}
