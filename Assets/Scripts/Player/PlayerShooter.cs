using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooter : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float fireInterval = 0.15f;

    private bool isFirePressed = false;
    private float fireTimer = 0f;

    public void OnAttack(InputValue value)
    {
        if (value.isPressed == true)
        {
            Debug.Log("isPressed == true");
            isFirePressed = true;
            //Fire();
        }
        else
        {
            Debug.Log("isPressed == false");
            isFirePressed = false;
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