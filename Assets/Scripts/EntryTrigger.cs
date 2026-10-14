using UnityEngine;

public class EntryTrigger : MonoBehaviour
{
    public CarTeleportManager manager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            manager.SetCanEnter(true);

            // Show "Enter Vehicle" UI
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            manager.SetCanEnter(false);

            // Hide UI
        }
    }
}