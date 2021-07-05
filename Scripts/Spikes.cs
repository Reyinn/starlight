using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Quaternion = UnityEngine.Quaternion;


public class Spikes : MonoBehaviour
{
    public string currentLevel;
    public ParticleSystem ps;
    public GameObject spikes;
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
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
