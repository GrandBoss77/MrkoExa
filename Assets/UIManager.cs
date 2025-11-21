using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.UI;

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

    private void Awake()
    {
        GlobalUIManager = this;
    }

    void Update()
    {
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        int money = CurrentUIData.money;
        scoreText.text = money.ToString();
    }

    public void UpdateMoney()
    {
        CurrentUIData.money += 1;
    }
}
