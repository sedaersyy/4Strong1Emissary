using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DüsenKayalar : MonoBehaviour
{
    public GameObject kayalar;
    public GameObject kayalar1;
    public GameObject fake;
    public GameObject kayalar2;
    bool calistir;
    void Start()
    {
        kayalar.GetComponent<Rigidbody>();
        
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag=="Player")
        {
            kayalar.SetActive(true);
            kayalar1.SetActive(true);
            kayalar2.SetActive(true);
            Destroy(fake);
        }
    }
}
