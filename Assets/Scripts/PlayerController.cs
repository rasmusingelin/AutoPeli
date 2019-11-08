using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    public float rotationSpeed;
    public float Vertical;
    public float Horizontal;


    // Start is called before the first frame update
    void Start()
    {
        this.rotationSpeed = 30f;
    }

    // Update is called once per frame
    void Update()
    {
        this.Vertical = Input.GetAxis("Vertical");
        this.Horizontal = Input.GetAxis("Horizontal");

        this.transform.Translate(this.transform.forward * Speed * this.Vertical * Time.deltaTime);
        this.transform.Rotate(new Vector3(0, 25 * this.Horizontal * Time.deltaTime, 0));
    }
}
 