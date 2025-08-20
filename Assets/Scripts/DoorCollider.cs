using UnityEngine;

public class DoorCollider : MonoBehaviour
{
    public void DisableCollider() => GetComponent<Collider2D>().enabled = false;

}
