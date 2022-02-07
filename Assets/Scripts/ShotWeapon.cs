using UnityEngine;

public class ShotWeapon : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform positionShot;
    [SerializeField] private Joystick joystick;

    [SerializeField] private SoudShot soudShot;


    [SerializeField] private float coolDown;

    private float delay;

    private void Update() 
    {
        JoystickController();

        delay = delay - Time.deltaTime;
    }

    public void Shot()
    {
        if (delay <= 0)
        {
            Instantiate(bullet, positionShot.position, transform.rotation);
            delay = coolDown;

            soudShot.PlaySoundShot();
        }
    }

    private void JoystickController()
    {
        var vector = new Vector2(joystick.Horizontal, joystick.Vertical);
        transform.rotation = Quaternion.FromToRotation(Vector3.up, vector);
    }
}
