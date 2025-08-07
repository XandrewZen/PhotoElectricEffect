using UnityEngine;

public class Electron : MonoBehaviour
{
    private Vector3 startPosition;
    private Vector3 targetPosition;
    private bool returning = false;
    private float progress = 0f;
    public float speed = 1f;

    public void SetDestination(Vector3 destination)
    {
        startPosition = transform.position;
        targetPosition = destination;
    }

    void Update()
    {
        progress += Time.deltaTime * speed;

        float t = returning ? Mathf.Pow(progress, 2) : 1 - Mathf.Pow(1 - progress, 2); // Lerp curve

        transform.position = Vector3.Lerp(startPosition, targetPosition, t);

        if (progress >= 1f)
        {
            if (!returning)
            {
                // Start returning
                Vector3 temp = startPosition;
                startPosition = targetPosition;
                targetPosition = temp;
                progress = 0f;
                returning = true;
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
