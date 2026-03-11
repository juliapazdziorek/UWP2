using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    private CharacterController _controller;

    private void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        var x = Input.GetAxis("Horizontal");
        var z = Input.GetAxis("Vertical");

        var move = transform.right * x + transform.forward * z;

        _controller.Move(move * speed * Time.deltaTime);
    }
}