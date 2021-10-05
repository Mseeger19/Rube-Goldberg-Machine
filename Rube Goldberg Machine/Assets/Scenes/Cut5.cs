using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cut5 : MonoBehaviour
{
    [SerializeField] private Transform camera;

    [SerializeField] int offset = 10;

    BoxCollider2D boxCollider;

    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();



    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Cut5Ball"))
        {
            camera.position = new Vector3(camera.position.x + offset, camera.position.y, camera.position.z);
        }
    }

}