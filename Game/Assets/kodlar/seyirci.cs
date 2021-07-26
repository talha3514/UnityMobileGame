using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seyirci : MonoBehaviour
{
    public float hiz;
    Vector3 vec;
    bool yukari = true;
    bool asagi = false;
    float y;
    void Start()
    {
        vec = new Vector3(0, transform.position.y+1, 0);
        y = transform.position.y;
        
    }
    // Update is called once per frame
    void Update()
    {
        
        if (yukari)
        {
            
            transform.position = transform.position + vec * Time.deltaTime * hiz;
        }
        if (asagi)
        {
            
            transform.position = transform.position - vec * Time.deltaTime * hiz;
        }
        if (transform.position.y > y+1)
        {
            asagi = true;
            yukari = false;
        }
        if (transform.position.y < y-0.2)
        {
            asagi = false;
            yukari = true;
        }
    }
}
