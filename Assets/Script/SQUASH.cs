using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SQUASH : MonoBehaviour
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
        temp = transform.localScale;
        temp.x = temp.x + Time.deltaTime;
        temp.y = temp.y - Time.deltaTime;

        transform.localScale = temp;
    }
}
