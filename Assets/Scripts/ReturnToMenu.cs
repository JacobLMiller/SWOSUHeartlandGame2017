using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ReturnToMenu : MonoBehaviour {

    void loadMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
