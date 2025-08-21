using UnityEngine;

public class DoorFacade : MonoBehaviour
{
    // A simple example for Facade. DoorFacade manages disabling the collider,
    // visually moving the door sprite, and playing the sound
    // and the player only interacts with it.
    [SerializeField] private DoorSound sound;
    [SerializeField] private DoorMover mover;
    [SerializeField] private DoorCollider collider;
    [SerializeField] private Vector3 openOffset;
    private bool _isOpen = false;

    public void OpenDoor()
    {
        if (!_isOpen)
        {
            Debug.Log("Open door");
            sound.PlaySound();
            collider.DisableCollider();
            mover.Move(openOffset);
            _isOpen = true;
        }
    }
}
