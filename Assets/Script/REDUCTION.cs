using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class REDUCTION : MonoBehaviour
{
    // Start is called before the first frame update
    private bool lerp = false;

    public Vector3 temp;




    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        if (temp.x >= 0)
        {
            temp = transform.localScale;
            temp.x = temp.x - Time.deltaTime;
            transform.localScale = temp;


        }

        else { }
        


    }
}