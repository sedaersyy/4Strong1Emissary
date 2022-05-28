using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DüsenKayalar : MonoBehaviour
{
    public GameObject kayalar;
    public GameObject fake;
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
            Destroy(fake);
        }
    }
}
