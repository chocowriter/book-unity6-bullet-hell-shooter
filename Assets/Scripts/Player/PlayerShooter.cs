using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooter : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float fireInterval = 0.15f;

    private bool isFirePressed = false;
    private float fireTimer = 0f;

    public void OnFire(InputValue value)
    {
        if (value.isPressed == true)
        {
            isFirePressed = true;
            fireTimer = fireInterval;
        }
        else
        {
            isFirePressed = false;
            fireTimer = 0f;
        }
    }
    
    private void Update()
    {
        if (!isFirePressed)
            return;

        fireTimer += Time.deltaTime;

        if (fireTimer >= fireInterval)
        {
            Fire();
            fireTimer = 0f;
        }
    }
    

    private void Fire()
    {
        Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
    }
}