using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Patman;
    [SerializeField] public float movementSpeed = 1f;
    public KeyCode lastInput;
    public Vector2 startingPos = new Vector2(-0.5f, 0.5f);
    
    void Start()
    {
        Patman.transform.position = startingPos;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w")) {
            pos.y += movementSpeed * Time.deltaTime;
            lastInput = KeyCode.W;
            Debug.Log("Last input is : " + lastInput);
        }

        if (Input.GetKey("a")){
            pos.x -= movementSpeed * Time.deltaTime;
            lastInput = KeyCode.A;
            Debug.Log("Last input is : " + lastInput);

        }

        if (Input.GetKey("s")){
            pos.y -= movementSpeed * Time.deltaTime;
            lastInput = KeyCode.S;
            Debug.Log("Last input is : " + lastInput);

        }

        if (Input.GetKey("d")){
            pos.x += movementSpeed * Time.deltaTime;
            lastInput = KeyCode.D;
            Debug.Log("Last input is : " + lastInput);

        }

        transform.position = pos;
    }
}
