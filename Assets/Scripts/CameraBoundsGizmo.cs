using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraBoundsGizmo : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Camera camera = GetComponent<Camera>();

        if (camera == null || !camera.orthographic)
        {
            return;
        }

        float height = camera.orthographicSize * 2f;
        float width = height * camera.aspect;

        Vector3 center = new Vector3(transform.position.x, transform.position.y, 0f);
        Vector3 size = new Vector3(width, height, 0f);

        Gizmos.DrawWireCube(center, size);
    }
}