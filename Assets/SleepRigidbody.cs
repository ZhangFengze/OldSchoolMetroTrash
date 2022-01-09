using UnityEngine;

public class SleepRigidbody : MonoBehaviour
{
    void Start()
    {
        foreach (var rb in gameObject.GetComponentsInChildren<Rigidbody>())
        {
            rb.Sleep();
        }
    }
}
