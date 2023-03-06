using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float Force;
    private Rigidbody2D rb;
    private Animator anim;
    private int score = 0;
    public Text scoreText;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ClickedOnMouse();
        }

        else
        {
            anim.SetBool("click", false);
            //return;
        }
    }

    void ClickedOnMouse()
    {
        rb.velocity = new Vector2(0, 1) * Force;
        anim.SetBool("click", true);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "PipeScore")
        {
            //Increment score
            score = score + 1;
            scoreText.text = "Score : " + score.ToString();
        }
    }
}
