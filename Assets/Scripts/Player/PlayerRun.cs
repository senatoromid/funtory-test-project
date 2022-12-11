using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRun : MonoBehaviour
{
    float speed = 6;
    Animator animMove;

    private Vector3 camRotation;
    private Transform cam;
 

    [Range(-45, -15)]
    public int minAngle = -30;
    [Range(30, 80)]
    public int maxAngle = 45;
    [Range(50, 500)]
    public int sensitivity = 200;

    private void Awake()
    {
        cam = Camera.main.transform;
    }

    void Start()
    {
        animMove = gameObject.GetComponent<Animator>();
      
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontal, 0, vertical) * (speed * Time.deltaTime));

        if (vertical != 0)
        {
            print(vertical);
            animMove.SetTrigger("play");
        }
        else
        {
           
            animMove.SetTrigger("stop");
        }
    }
    private void Rotate()
    {
        transform.Rotate(Vector3.up * sensitivity * Time.deltaTime * Input.GetAxis("Mouse X"));

        camRotation.x -= Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        camRotation.x = Mathf.Clamp(camRotation.x, minAngle, maxAngle);

        cam.localEulerAngles = camRotation;
    }
}
