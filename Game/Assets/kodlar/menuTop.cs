using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuTop : MonoBehaviour
{
    Rigidbody fizik;
    public float hiz;
    bool zemin = false;
    bool ters = false;
    int x = 2;
    // Start is called before the first frame update
    void Start()
    {
        //Application.targetFrameRate = 60;
        
        fizik = GetComponent<Rigidbody>();
        

    }

    // Update is called once per frame
    void Update()
    {

        if(zemin)
        {
            fizik.AddForce(new Vector3(x, 10, 0) * hiz);
            zemin = false;
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Respawn")
        {
            zemin = true;
            ters = !ters;
            if (ters)
            {
                x = -2;
            }
            if (!ters)
            {
                x = 2;
            }
        }
    }
}
