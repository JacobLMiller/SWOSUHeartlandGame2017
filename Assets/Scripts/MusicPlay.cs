using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MusicPlay : MonoBehaviour {

	// Use this for initialization
	void Awake () {
	GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
    if (objs.Length > 1)
        Destroy(this.gameObject);

    DontDestroyOnLoad(this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
        if (SceneManager.GetActiveScene().name == "Game Over")
        {
            Destroy(this.gameObject);
        }
	}
}
