using UnityEngine;

public class DoorSound : MonoBehaviour
{
    [SerializeField] AudioSource _audioSource;

    public void PlaySound()
    {
        Debug.Log("Playing Sound");
        _audioSource.Play();
    }

}
