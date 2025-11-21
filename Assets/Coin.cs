using System;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            UIManager.GlobalUIManager.CurrentUIData.money += 1;
            Destroy(gameObject);
        }
    }
}
