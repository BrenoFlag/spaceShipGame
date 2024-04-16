using UnityEngine;

public class LaserBehavior : MonoBehaviour
{
    void Update()
    {
        transform.position += Vector3.up * (50 * Time.deltaTime);
        if (transform.position.y > 31)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter()
    {
        Destroy(gameObject);
    }
}
