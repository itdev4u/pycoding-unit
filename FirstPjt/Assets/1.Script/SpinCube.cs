using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinCube : MonoBehaviour
{
    /*
     * STEP 01
    public Vector3 RotateAmount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(RotateAmount);
    }
    */

    /*
     * STEP 02
    private Quaternion rotateVector;
    private float plusRotate = 0.5f;
    void Start()
    {
        
    }

    void Update()
    {
        rotateVector = Quaternion.Euler(new Vector3(plusRotate, plusRotate, plusRotate));
        gameObject.GetComponent<Transform>().localRotation = rotateVector;
        plusRotate += 0.5f;
    }
    */
    /* 
     * STEP03
    */
    private Quaternion rotateVector;
    private float plusRotate = 0.5f;
    private float speed = 5f;
    void Start()
    {
        
    }

    void Update()
    {
        rotateVector = Quaternion.Euler(new Vector3(plusRotate, plusRotate, plusRotate));
        gameObject.GetComponent<Transform>().localRotation = rotateVector;
        plusRotate += 0.5f;
    }

    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }
    }
}
