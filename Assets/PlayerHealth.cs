using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public void TakeDamage(int damage)
    {
        UIManager.GlobalUIManager.CurrentUIData.playerHealth -= damage;
    }
}
