using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Quaternion = UnityEngine.Quaternion;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using Vector3 = UnityEngine.Vector3;

public class Saw : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float movementDistance;
    private bool movingLeft;
    private float leftEdge;
    private float rightEdge;
    public string currentLevel;
    public ParticleSystem ps;
    public GameObject spikes;

    private void Awake()
    {
        leftEdge = transform.position.x - movementDistance;
        rightEdge = transform.position.x + movementDistance;
    }

    private void Update()
    {
        if(movingLeft)
        {
            if(transform.position.x > leftEdge) 
            {
                transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);
            }
            else 
                movingLeft = false;

        }
        else
        {
            if(transform.position.x < rightEdge)
            {
                transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
            }
            else
                movingLeft = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            StartCoroutine(WaitLoadScene()); 
            Instantiate(ps, spikes.transform.position, Quaternion.identity);           
        }     
    }


    IEnumerator WaitLoadScene()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(currentLevel);
    }

}
