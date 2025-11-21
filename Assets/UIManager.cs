using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
[System.Serializable]
public class UIData
{
    public int money = 0;
    public int playerHealth = 100;
}

public class UIManager : MonoBehaviour
{
    public static UIManager GlobalUIManager = null;
    
    public UIData CurrentUIData = null;
    
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI playerHealthText;

    private void Awake()
    {
        GlobalUIManager = this;
    }

    void Update()
    {
        if (CurrentUIData.playerHealth <= 0)
        {
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }
        UpdateScoreText();
        UpdatePlayerHealthText();
    }

    private void UpdateScoreText()
    {
        int money = CurrentUIData.money;
        scoreText.text = money.ToString();
    }

    private void UpdatePlayerHealthText()
    {
        int playerHealth = CurrentUIData.playerHealth;
        playerHealthText.text = "Health:" + playerHealth.ToString();
    }

    public void UpdateMoney()
    {
        CurrentUIData.money += 1;
    }
}
