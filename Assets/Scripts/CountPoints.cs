using UnityEngine;
using UnityEngine.UI;

public class CountPoints : MonoBehaviour
{
    [SerializeField] private GameObject ScoreText;
    private int point;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerBullet")
        {
            point++;
            ScoreText.GetComponent<Text>().text = "Score: " + point;
        }
    }
}
