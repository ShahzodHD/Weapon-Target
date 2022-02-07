using UnityEngine;

public class SoudShot : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip shotClips;
    public void PlaySoundShot()
    {
        audioSource.PlayOneShot(shotClips);
    }


}
