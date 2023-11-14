using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    [SerializeField]
    private Transform platform1;
    [SerializeField]
    private Transform platform2;
    [SerializeField]
    private TextMeshProUGUI scoreText;
    private int score=0;

    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Controll"))
        {
            platform1.position = new Vector3(platform1.position.x, platform2.position.y + 8.0f, platform1.position.z);
            score += 5;
            scoreText.text = "Puan: " + score.ToString();
        }
        if (collision.CompareTag("Controll2"))
        {
            platform2.position = new Vector3(platform2.position.x, platform1.position.y + 8.0f, platform2.position.z);
            score += 5;
            scoreText.text = "Puan: " + score.ToString();
        }
    }
}

