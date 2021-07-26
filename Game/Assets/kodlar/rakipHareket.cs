using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class rakipHareket : MonoBehaviour
{
    public NavMeshAgent rakip;
    Transform top;
    bool hareket = false;
    // Start is called before the first frame update
    void Start()
    {
        top = GameObject.Find("top/default").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(hareket)
        {
            rakip.destination = top.position;
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            hareket = true;
        }
    }
}
