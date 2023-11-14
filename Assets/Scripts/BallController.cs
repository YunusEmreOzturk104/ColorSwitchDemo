using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    [SerializeField]
    private int jumpForce;
    private Rigidbody2D rg;
    [SerializeField]
    private string currentColor;
    [SerializeField]
    private Color yellowColor;
    [SerializeField]
    private Color blueColor;
    [SerializeField]
    private Color pinkColor;
    [SerializeField]
    private Color purpleColor;
    private SpriteRenderer sr;
    [SerializeField]
    private TextMeshProUGUI finishText;
    [SerializeField]
    private Button restartButton;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        rg = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        randomColor();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
       
    }
    void Move()
    {
        if (Input.GetMouseButton(0))
        {
            rg.velocity = Vector2.up*jumpForce;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag != currentColor && !collision.CompareTag("Diamond") && !collision.CompareTag("ChangeColor") && !collision.CompareTag("Controll") && !collision.CompareTag("Controll2"))
        {
            finishText.gameObject.SetActive(true);
            Time.timeScale = 0;
            restartButton.gameObject.SetActive(true);
            Debug.Log("You Dead!!");
        }
        if (collision.CompareTag("ChangeColor"))
        {   
            randomColor();
        }
      

    }

    void randomColor()
    {
        int index = Random.Range(0, 4);
        switch (index)
        {
            case 0: currentColor = "Blue";sr.color = blueColor; break;
            case 1: currentColor = "Yellow";sr.color = yellowColor; break;
            case 2: currentColor = "Pink"; sr.color = pinkColor; break;
            case 3: currentColor = "Purple"; sr.color = purpleColor; break;
        }
    }
    public void RestartGame()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
