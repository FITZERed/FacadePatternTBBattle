using UnityEngine;

public class DoorFacade : MonoBehaviour
{
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
