using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch : MonoBehaviour
{
    public float speed;
    bool yon = true;
    bool durdur = true;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (durdur)
        {
            if (transform.eulerAngles.x < 2)
            {
                yon = true;
            }
            if (transform.eulerAngles.x > 43)
            {
                yon = false;
            }

            if (yon)
            {
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(45, 0, 0), Time.deltaTime * speed);
            }
            if (!yon)
            {
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 0), Time.deltaTime * speed);
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            durdur = false;
            gameObject.SetActive(false);
        }
    }
}
