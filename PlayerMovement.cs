using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    [Header("PlayerStats")]

    public  int health = 1;

    public int level = 2;

    [Header("PlayerMovement")]

    [SerializeField] private float speed = 1;

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
