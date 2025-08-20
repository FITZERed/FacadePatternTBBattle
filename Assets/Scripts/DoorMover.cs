using UnityEngine;

public class DoorMover : MonoBehaviour
{
    public void Move(Vector3 offset) => transform.localPosition += offset;

}
