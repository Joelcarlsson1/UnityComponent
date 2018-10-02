using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondScript : MonoBehaviour
{
    public SpriteRenderer rend;
    public Transform other;
    public Color newColor;
    [Range(-720, 720)]
    public float rotationSpeed;
    // Use this for initialization
    void Start()
    {
        rend.color = newColor;
        rend.color = new Color(0.4f, 0.5f, 0.8f);
        //other.position = new Vector3(5, 4, other.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 0f, -rotationSpeed * Time.deltaTime);
        }
        transform.Translate(5f * Time.deltaTime, 0f, 0f, Space.Self);
    }
}
