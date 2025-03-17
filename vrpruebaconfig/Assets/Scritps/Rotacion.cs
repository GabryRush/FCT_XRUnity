using UnityEngine;

public class Rotacion : MonoBehaviour
{

    [SerializeField] float velocidad = 30f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, velocidad * Time.deltaTime, 0);
    }
}
