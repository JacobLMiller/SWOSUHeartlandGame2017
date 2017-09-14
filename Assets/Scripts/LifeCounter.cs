using UnityEngine;
using System.Collections;

public class LifeCounter : MonoBehaviour {

    private int life;

    public GameObject player;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

    }

    void Update()
    {
    }
}
