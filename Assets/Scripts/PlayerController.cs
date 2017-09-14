using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public GameObject player;
    public float launchForce;
    public GameObject Tut1;
    public GameObject Tut2;
    public GameObject keyWall1;
    public GameObject keyWall2;
    public GameObject keyWall3;


    private Animation playerRise;
    private Rigidbody rb;
    private bool Key1;
    private bool launchBool = false;
    private bool sceneChange = false;
    private static int lifeCount = 5;
    private static int PuCount = 0;
    private bool bossFight = false;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerRise = GetComponent<Animation>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        Vector3 launch = new Vector3(0.0f, launchForce, 0.0f);

        rb.AddForce(movement * speed);
        if (launchBool)
        {
            rb.AddForce(launch);
        }

    }
    void Update()
    {
        if (sceneChange)
        {
            int i = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(i + 1);
            sceneChange = false;
        }
        if (lifeCount == 0)
        {
           SceneManager.LoadScene("Game Over");
            lifeCount = 5;
        }
        if (bossFight)
        {
            SceneManager.LoadScene("Level 1 (The Revengeance)");
        }
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("BadWall"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            lifeCount--;
        }
        if (other.gameObject.CompareTag("Launcher"))
        {
            launchBool = true;
        }

        if (other.gameObject.CompareTag("Goal"))
        {
            if (PuCount == 50)
            {
                bossFight = true;
            }
            else
            {
                sceneChange = true;
            }
        }  
        if (other.gameObject.CompareTag("Key 1"))
        {
            other.gameObject.SetActive(false);
            keyWall1.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("Key 2")){
            other.gameObject.SetActive(false);
            keyWall2.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("Key 3"))
        {
            other.gameObject.SetActive(false);
            keyWall3.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("Grow"))
        {
            transform.localScale = new Vector3(3, 3, 3);
        }
        if (other.gameObject.CompareTag("Shrink"))
        {
            transform.localScale = new Vector3(.2f, .2f, .2f);
        }
        if (other.gameObject.CompareTag("Pickup")){
            other.gameObject.SetActive(false);
            PuCount++;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("TutBlock1"))
        {
            Tut1.gameObject.SetActive(true);
        }
        if (other.gameObject.CompareTag("TutBlock2"))
        {
            Tut2.gameObject.SetActive(true);
        }
    }
    void OnCollisionEnter(Collision other)
    {

    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Launcher"))
        {
            launchBool = false;
        }
        if (other.gameObject.CompareTag("TutBlock1"))
        {
            Tut1.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("TutBlock2"))
        {
            Tut2.gameObject.SetActive(false);
        }
    }
}
