using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public InputAction moveAction;
    public InputAction shootAction;
    public float xRange;
    public GameObject foodPrefab;

    private void Awake()
    {
        moveAction = InputSystem.actions.FindAction("Move");

        shootAction = InputSystem.actions.FindAction("Shoot");
    }
    private void Update()
    {
        //xRange = Camera.main.orthographicSize; 

        var HorizontalInput = moveAction.ReadValue<Vector2>().x;
        transform.Translate(HorizontalInput * speed * Time.deltaTime * Vector3.right);

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (shootAction.triggered)
        {
            Instantiate(foodPrefab, transform.position, Quaternion.identity);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine
            (
                new Vector3(-xRange, transform.position.y, transform.position.z),
                new Vector3(xRange, transform.position.y, transform.position.z)
            );
    }
}
