using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraSetup : MonoBehaviour
{
    [SerializeField] private float orthographicSize = 5f;
    [SerializeField] private Color backgroundColor = new Color(0f, 0f, 0.08f, 1f);

    private void Awake()
    {
        Camera camera = GetComponent<Camera>();

        camera.orthographic = true;
        camera.orthographicSize = orthographicSize;
        camera.clearFlags = CameraClearFlags.SolidColor;
        camera.backgroundColor = backgroundColor;

        transform.position = new Vector3(0f, 0f, -10f);
        transform.rotation = Quaternion.identity;
    }
}