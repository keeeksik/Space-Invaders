using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class EndGame : MonoBehaviour
{
    public GameObject windowEnd;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
              windowEnd.SetActive(true);
        }
    }
}
