/*
 Ease in / Ease out functions for Comp Anim Challenge 1 
 Jaden Hepburn 100791169
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EaseInEaseOut : MonoBehaviour
{
    public GameObject Item;
    public float t = 0;
    public float varDuration = 500f;
    public Vector2 varVec2 = new Vector2(0, 0);


    // Pass in accumulative delta time, starting position, ending position and how long the animation will take

    //This screwed with me so hard. I was thinking like ease into a parking space. Which would be this function yet its suppose to be ease out.
    public Vector2 easeOut(float t, Vector2 Pos, Vector2 Target, float duration)
    {

        t /= duration;

        float xCalc = Pos.x + (Target.x - Pos.x) * t;
        float yCalc = Pos.y + (Target.y - Pos.y) * t;

        Vector2 woah = new Vector2(xCalc, yCalc);

        return woah;
    }

    //THIS IS ACTING LIKE EASE IN & EASE OUT, WHY.
    public Vector2 easeIn(float t, Vector2 Pos, Vector2 Target, float duration)
    {
        duration = duration / 15; //Division in an attempt even out the speeds between ease out, default 15. 
        t /= duration;
        Vector2 woah = new Vector2((Target.x - Pos.x) * t * t + Pos.x, (Target.y - Pos.y) * t * t + Pos.y);
        return woah;
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        t += Time.deltaTime;

        Item.transform.position = easeIn(t, Item.transform.position, varVec2, varDuration);


    }
}