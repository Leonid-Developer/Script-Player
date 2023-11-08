using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    [Header("PlayerStats")]

    private int health;

    private int level;

    [Header("PlayerMovement")]

    [SerializeField] private float speed;

    private Vector3 Position;

    private void Start()
    {
        health += level;
        print(health);
    }
    private void Update()
    {
        Position.z += speed * Time.deltaTime;
        transform.position = Position;
    }
}
