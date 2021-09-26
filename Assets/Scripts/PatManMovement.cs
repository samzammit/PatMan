using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatManMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject PatMan;
    public float movementSpeed = 0.1f;
    Vector2 startingPos;
    Vector2 secondPos;
    Vector2 thirdPos;
    Vector2 fourthPos;
    bool left, right, up, down;


    void Start()
    {
        startingPos = new Vector2(-0.5f, -0.75f);
        secondPos = new Vector2(-0.5f, 0.5f);
        thirdPos = new Vector2(1.1f, 0.5f);
        fourthPos = new Vector2(1.1f, -0.75f);
        PatMan.transform.position = startingPos;
    }

    // Update is called once per frame
    void Update()
    {
        PatMan.transform.position = Vector2.MoveTowards(PatMan.transform.position, secondPos, movementSpeed*Time.deltaTime);
        //PatMan.transform.rotation = 
        //PatMan.transform.position = Vector2.MoveTowards(PatMan.transform.position, thirdPos, movementSpeed * Time.deltaTime);

    }
}

//ROTATING PATS HEAD
// Z = 90 FIRST (UP) --> Z = 0 (LEFT) --> Z = 270 (DOWN) --> Y = 180


/*  
 *  MOVEMENT AROUND THE BLOCK
 *  Starting position --> X = -0.5, Y = -0.75   (-0.5, -0.75);
 *  Second Position --> X = 0.5, Y = 0.5        (0.5, 0.5);
 *  Third Position --> X = 1.1, Y = 0.5         (1.1, 0.5);
 *  Fourth Position --> X = 1.1, Y = -0.75      (1.1, -0.75);
 *  Final Position --> X = -0.5, Y = -0.75      (-0.5, -0.75);
 */
