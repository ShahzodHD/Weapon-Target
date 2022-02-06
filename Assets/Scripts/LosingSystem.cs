using UnityEngine;
using UnityEngine.UI;

public class LosingSystem : MonoBehaviour
{
    [SerializeField] private int attempts;
    [SerializeField] private Text TextGameOver;

    [SerializeField] private GameObject joystick;
    [SerializeField] private GameObject buttonShot;
    [SerializeField] private GameObject buttonRestart;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerBullet")
        {
            CountAttempt();
        }
    }

    public void CountAttempt()
    {
        attempts--;
        if (attempts <= 0)
        {
            TextGameOver.gameObject.SetActive(true);
            buttonRestart.SetActive(true);
            joystick.SetActive(false);
            buttonShot.SetActive(false);
        }
    }
}
