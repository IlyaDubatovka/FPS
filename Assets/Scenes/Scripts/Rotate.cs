using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = 3.0f;
    void Update()
    {
        transform.Rotate(0, speed, 0);
    }
}
