using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class Movement : MonoBehaviour
{
    private DoorFacade nearbyDoor;
    [SerializeField] private Transform transform;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && nearbyDoor != null)
        {
            nearbyDoor.OpenDoor();
            nearbyDoor = null; // only opens once
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position = transform.position + new Vector3(0, 0.5f, 0);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position = transform.position + new Vector3(0, -0.5f, 0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(-0.5f, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(0.5f, 0, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent<DoorFacade>(out DoorFacade door))
        {
            Debug.Log("There is door");
            nearbyDoor = door;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.TryGetComponent<DoorFacade>(out DoorFacade door) && door == nearbyDoor)
        {
            Debug.Log("There is no door");
            nearbyDoor = null;
        }
    }
}
