using UnityEngine;
using System.Collections;

public class BadBoxStationary : MonoBehaviour
{
    private Transform target;
    private Transform myTransform;

    public float Speed;
    public float Rotate;
    public float range;

    private bool LiamNissan = false;

    void Awake()
    {
        myTransform = transform;
    }

    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
    }


    void Update()
    {
        RaycastHit hit;
        Ray badBox = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(badBox, out hit, range))
        {
            
            if (hit.collider.tag == "Player")
            {
                LiamNissan = true;
                
            }
        }
        if (LiamNissan)
        {
            myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
                Quaternion.LookRotation(target.position - myTransform.position), Rotate * Time.deltaTime);
            myTransform.position += myTransform.forward * Speed * Time.deltaTime;
        }
    }

}
