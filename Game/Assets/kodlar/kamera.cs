using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ParticleSystemJobs;

public class kamera : MonoBehaviour
{
    public GameObject top;
    Vector3 aradakiMesafe;
    int yon = 0;
    bool sol = false;
    bool sag = false;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        aradakiMesafe = transform.position - top.transform.position;
       
    }
    

    // Update is called once per frame
    void Update()
    {
        transform.position = top.transform.position + aradakiMesafe;
        if(Time.timeScale == 1)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (yon % 2 == 0)
                {
                    sol = true;
                    sag = false;
                }
                if (yon % 2 == 1)
                {
                    sol = false;
                    sag = true;
                }
                yon++;
            }
            if (sol)
            {
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 30, 0), Time.deltaTime * speed);
            }
            if (sag)
            {
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, -30, 0), Time.deltaTime * speed);
            }
        }
        

    }

}
