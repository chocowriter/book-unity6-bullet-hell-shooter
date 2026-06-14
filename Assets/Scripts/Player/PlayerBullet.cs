using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float lifeTime = 3f;

    private float timer;

    private void OnEnable()
    {
        timer = 0f;
    }

    private void Update()
    {
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);

        timer += Time.deltaTime;
        if (timer >= lifeTime)
        {
            Destroy(gameObject);
        }
    }
}