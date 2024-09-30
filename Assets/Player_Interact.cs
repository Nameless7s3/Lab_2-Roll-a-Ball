using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player_Interact : MonoBehaviour
{
    public int score;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI winText;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup"))
        {
            score++;
            SetScoreText();
            Destroy(other.gameObject);
            if(score == 5)
            {
                WinGameText();
            }
        }
    }

    void SetScoreText()
    {
        scoreText.text = "Score : " + score.ToString();
    }

    void WinGameText()
    {
        scoreText.enabled = false;
        winText.enabled = true;
    }
}
