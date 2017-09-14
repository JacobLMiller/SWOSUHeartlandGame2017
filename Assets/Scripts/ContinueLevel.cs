using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ContinueLevel : MonoBehaviour {

    void ContinueScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
