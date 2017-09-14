using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoalScript : MonoBehaviour {

    
    private bool sceneChange = false;

    void Update()
    {
        if (sceneChange)
        {
            int i = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(i + 1);
            sceneChange = false;
        }
    }
    void OnCollisionEnter(Collision other){
        if (other.gameObject.CompareTag("Player")){
            sceneChange = true;
        }
    }

}
