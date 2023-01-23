using UnityEngine;

public class RotateReticle : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 15;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0, Space.World);
    }
}
