using UnityEngine;

public class CameraFollow2D : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float horizontalOffset;
    [SerializeField] private float smoothTime = 0.18f;

    private float horizontalVelocity;

    private void LateUpdate()
    {
        if (target == null) return;

        Vector3 position = transform.position;
        position.x = Mathf.SmoothDamp(
            position.x,
            target.position.x + horizontalOffset,
            ref horizontalVelocity,
            smoothTime);
        transform.position = position;
    }
}