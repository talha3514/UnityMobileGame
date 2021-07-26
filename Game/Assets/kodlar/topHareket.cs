using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class topHareket : MonoBehaviour
{
    Rigidbody fizik;
    public float hiz;
    Vector3 vec;
    public Text sut;
    bool sutMu = false;
    bool sutEngel = true;
    int yon = 0;
    public AudioSource ses;
    public AudioClip sutSesi;
    public AudioClip golSesi;
    public AudioClip engelSesi;
    public ParticleSystem efekt;
    public GameObject partical;
    public int buildIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        fizik = GetComponent<Rigidbody>();
        efekt.Stop();
        buildIndex = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Time.timeScale == 1)
        {


            if (sutEngel)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    if (yon % 2 == 0)
                    {
                        vec = new Vector3(-3, 0, 3);
                        fizik.velocity = vec * hiz;
                        ses.PlayOneShot(sutSesi);


                    }
                    if (yon % 2 == 1)
                    {
                        vec = new Vector3(3, 0, 3);
                        fizik.velocity = vec * hiz;
                        ses.PlayOneShot(sutSesi);

                    }
                    if (transform.position.x > 0 && sutMu)
                    {
                        vec = new Vector3(-3, hiz * 0.07f, 3);
                        fizik.velocity = vec * hiz;
                        ses.PlayOneShot(sutSesi);
                    }
                    if (transform.position.x < 0 && sutMu)
                    {

                        vec = new Vector3(3, hiz * 0.07f, 3);
                        fizik.velocity = vec * hiz;
                        ses.PlayOneShot(sutSesi);
                    }
                    yon++;

                }
            }

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "gol")
        {

            sut.text = "GOALL!";
            ses.Stop();
            ses.PlayOneShot(golSesi);
            Invoke("NextLevel", 2f);

        }
        if (other.gameObject.tag == "sut")
        {
            hiz *= 2;
            sutMu = true;
            sut.text = "SHOOT!";
            
        }

        if (other.gameObject.tag == "korner")
        {
            ses.Stop();
            ses.PlayOneShot(engelSesi);
            sut.text = "OUT!";
            Invoke("gameOver", 3f);

        }
        if (other.gameObject.tag == "engel")
        {
            partical.transform.position = transform.position;
            efekt.Play();
            Invoke("efekStop", .1f);
            gameObject.SetActive(false);
            sut.text = "GAME OVER!";
            Invoke("gameOver", 3f);

        }


    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "rotate")
        {
            sutEngel = false;
        }

    }

    void efekStop()
    {
        efekt.Stop();
    }

    public void NextLevel()
    {
        int saveIndex = PlayerPrefs.GetInt("SaveIndex");
        if (buildIndex > saveIndex)
        {
            PlayerPrefs.SetInt("SaveIndex", buildIndex);
        }

        if (buildIndex == 10)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(buildIndex + 1);
        }
    }

    public void gameOver()
    {
        SceneManager.LoadScene(buildIndex);
    }
}
