using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class engelHareket : MonoBehaviour
{
    public Transform baslangic;
    public Transform son;
    public float hiz;
    Vector3 konum;
    bool sol = true;
    bool sag = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        konum = transform.position;
        if (sol)
        {
            transform.position = Vector3.Lerp(konum, baslangic.position, Time.deltaTime * hiz);
        }
        if (sag)
        {
            transform.position = Vector3.Lerp(konum, son.position, Time.deltaTime * hiz);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "engel")
        {
            sol = !sol; 
            sag = !sag;

        }
    }
}
