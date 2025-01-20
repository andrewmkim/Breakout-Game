using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
    int speed = 10;

    void Update()
    {
        float xSpeed = Input.GetAxis("Horizontal") * speed;
        Vector3 pos = transform.position;
        pos.x += xSpeed * Time.deltaTime;
        transform.position = pos;

        float ySpeed = Input.GetAxis("Vertical") * speed;
        Vector3 posy = transform.position;
        pos.y += ySpeed * Time.deltaTime;
        transform.position = posy;
    }
}
