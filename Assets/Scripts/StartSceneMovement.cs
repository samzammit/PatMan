using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSceneMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject PatMan;
    [SerializeField]public float movementSpeed = 1f;
    public GameObject startingPos;
    public GameObject secondPos;
    public GameObject thirdPos;
    public GameObject fourthPos;
    bool isStart, isFirst, isSecond, isThird, isFourth;


    void Start()
    {
   
        PatMan.transform.position = startingPos.transform.position;
        isStart = true;
        isFirst = false;
        isSecond = false;
        isThird = false;
        //isFourth = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isStart == true) {
            PatMan.transform.rotation = Quaternion.Euler(0, 0, 90);
            PatMan.transform.position = Vector2.MoveTowards(PatMan.transform.position, secondPos.transform.position, movementSpeed * Time.deltaTime);
        }
        if (PatMan.transform.position == secondPos.transform.position) {
            isFirst = true;
            isStart = false;
        }
       
         if (isFirst == true)
         {
             PatMan.transform.rotation = Quaternion.Euler(0, 0, 0);
             PatMan.transform.position = Vector2.MoveTowards(PatMan.transform.position, thirdPos.transform.position, movementSpeed * Time.deltaTime);
         }
        if (PatMan.transform.position == thirdPos.transform.position) {
            isSecond = true;
            isFirst = false;
        }

       
         if (isSecond == true)
         {
             PatMan.transform.rotation = Quaternion.Euler(0, 0, 270);
             PatMan.transform.position = Vector2.MoveTowards(PatMan.transform.position, fourthPos.transform.position, movementSpeed * Time.deltaTime);
         }
        if (PatMan.transform.position == fourthPos.transform.position) {
            isThird = true;
            isSecond = false;
        }



         if (isThird == true)
         {
             PatMan.transform.rotation = Quaternion.Euler(0, 180, 0);
             PatMan.transform.position = Vector2.MoveTowards(PatMan.transform.position, startingPos.transform.position, movementSpeed * Time.deltaTime);
         }
        if (PatMan.transform.position == startingPos.transform.position)
        {
            isStart = true;
            isThird = false;
        }



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
