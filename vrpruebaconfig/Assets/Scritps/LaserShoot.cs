using Oculus.Interaction.Locomotion;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class LaserShoot : MonoBehaviour
{

    public GameObject laserPrefab; //prefab del láser. 
    public Transform[] puntosCannon;
    public float laserSpeed = 20F; //velocidad del l�ser al salir disparado. 
    public float destroyTime = 5f;
    AudioSource laserBeam;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootLaser();
            laserBeam.Play();
        }
    }

    void ShootLaser()
    {
        // Recorre los puntos de cañón y dispara un láser desde cada uno
        foreach (Transform puntosCannon in puntosCannon)
        {
            // Instanciar el láser en el punto de cañón
            GameObject laser = Instantiate(laserPrefab, puntosCannon.position, puntosCannon.rotation);

            // Obtener el Rigidbody del láser
            Rigidbody rb = laser.GetComponent<Rigidbody>();
            if (rb != null)
            {
                
                // Lanzar el láser hacia adelante (en la dirección de la rotación del cañón)
                rb.linearVelocity = puntosCannon.up * laserSpeed;
                rb.angularVelocity = Vector3.zero;
            }
            // Destruir el láser después de un tiempo
            Destroy(laser, destroyTime);

        }

    }
}
