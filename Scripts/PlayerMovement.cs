using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public bool canMove = false;
    public Rigidbody2D rb; 
    public Text counterText;

    public int moveCounter; 
    public ParticleSystem ps;
    public GameObject spikes;
    public string currentLevel;

        // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        counterText.text = moveCounter.ToString();
        
    }
    

    // Update is called once per frame
    void Update()
    
    {
        if(canMove == true)
        {
            if(Input.GetKeyDown(KeyCode.UpArrow))
            {
            rb.velocity = new Vector2 (0 , 1 * speed * Time.deltaTime);
            moveCounter --;
            counterText.text = moveCounter.ToString();;
            }

            if(Input.GetKeyDown(KeyCode.DownArrow))
            {
            rb.velocity = new Vector2 (0 , -1 * speed * Time.deltaTime);
            moveCounter --;
            counterText.text = moveCounter.ToString();;
            }

            if(Input.GetKeyDown(KeyCode.LeftArrow))
            {
            rb.velocity = new Vector2 (-1 * speed * Time.deltaTime, 0);
            moveCounter --;
            counterText.text = moveCounter.ToString();;
            }
            if(Input.GetKeyDown(KeyCode.RightArrow))
            {
            rb.velocity = new Vector2 (1 * speed * Time.deltaTime, 0);
            moveCounter --;
            counterText.text = moveCounter.ToString();;
            }

            if(moveCounter < 0)
            {
                SceneManager.LoadScene(currentLevel);
                
            }
        }
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            canMove = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {       
    canMove = false;                              
    }

    


}
