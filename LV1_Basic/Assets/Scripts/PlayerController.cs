using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float speed;
    [SerializeField] Text txtScore;
    int score;
    [SerializeField] ParticleSystem particleSystem;
    [SerializeField] GameObject panelGameOver;
    bool isgameOver;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(rb.velocity.magnitude < 2) { 
            particleSystem.Stop();
        }
        else
        {
            if(particleSystem.isPlaying)
            {
                particleSystem.Play();
            }
        }
    }
    private void FixedUpdate()
    {
        if (!isgameOver)
        {
            float moveHorizontal = Input.GetAxisRaw("Horizontal");
            float moveVertical = Input.GetAxisRaw("Vertical");
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            rb.AddForce(movement * speed);
        }
        
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Coin"))
        {
            score++;
            txtScore.text = "Score: " + score.ToString();
            Destroy(col.gameObject);
        }
        if (col.gameObject.CompareTag("Enemy"))
        {
            isgameOver = true;
            rb.velocity = Vector3.zero;
            rb.isKinematic = true; 
            panelGameOver.SetActive(true);
        }
    } 
    public void playAgain()
    {
        SceneManager.LoadScene("Game");
    }
}
