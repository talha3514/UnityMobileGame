using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kaleci : MonoBehaviour
{
    bool sol = true;
    bool sag = false;
    Vector3 vec;
    public float hiz;
    float x;
    // Start is called before the first frame update
    void Start()
    {
        vec = new Vector3(transform.position.x+1, 0, 0);
        x = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (sol)
        {
            transform.position = transform.position - vec * Time.deltaTime * hiz;
        }
        if(sag)
        {
            transform.position = transform.position + vec * Time.deltaTime * hiz;
        }

        if (transform.position.x < x-3)
        {
            sag = true;
            sol = false;
        }
        if (transform.position.x > x+3)
        {
            sag = false;
            sol = true;
        }

    }
}
