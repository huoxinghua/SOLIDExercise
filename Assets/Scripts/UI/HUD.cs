using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUD : MonoBehaviour
{
    [SerializeField] TMP_Text healthText;
    [SerializeField] TMP_Text scoreText;

    private void Start()
    {
        HealthManager.Instance.takeDamaged.AddListener(UpdateHealthDisplay);
        HealthManager.Instance.restoreHealth.AddListener(UpdateHealthDisplay);

        ScoreManager.Instance.addScore.AddListener(UpdateCollectDisplay);

        UpdateHealthDisplay();
        UpdateCollectDisplay();
    }
    private void UpdateHealthDisplay()
    {
        healthText.text = "Health :" + HealthManager.Instance.playerHealth.ToString();
    }

    private void UpdateCollectDisplay()
    {
        scoreText.text = "Score :" + ScoreManager.Instance.score.ToString();
    }

}
