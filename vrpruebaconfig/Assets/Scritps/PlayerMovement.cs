using UnityEngine;
using System.Collections.Generic;
using System.Collections;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        

        Vector3 direction = new Vector3(horizontalInput, verticalInput);
        direction.Normalize();


        transform.position += direction * speed * Time.deltaTime;
    }

}


