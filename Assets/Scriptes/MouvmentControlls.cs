using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvmentControlls : MonoBehaviour
{

    Vector3 birdDirection;
    [SerializeField] float strength = 5;
    [SerializeField] float gravity = -9.8f;
    [SerializeField] AudioClip flappSound;
    [SerializeField] AudioClip deathSound;

    bool isAlive=true;
    // Update is called once per frame
    void Update()
    {
        if (!isAlive) { return; }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
               
                birdDirection = Vector3.up * strength;
                GetComponent<AudioSource>().PlayOneShot(flappSound);
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            birdDirection = Vector3.up * strength;
        }

        birdDirection.y += gravity * Time.deltaTime;
        transform.position += birdDirection * Time.deltaTime;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Obstacle")
        {
            
            isAlive = false;
            GetComponent<AudioSource>().PlayOneShot(deathSound);
            FindObjectOfType<LoadIntertial>().LoadAd();
            //make function from Game manager
        }

       
    }
    

}
