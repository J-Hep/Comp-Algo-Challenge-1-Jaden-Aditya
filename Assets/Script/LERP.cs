using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LERP : MonoBehaviour
{
    // Start is called before the first frame update
    private bool lerp = false;

    public Vector3 startPos;
    public Vector3 endPos=new Vector3(4,4,0);

    public float expectedTime = 2.7f, timeTaken;
    


    void Start()
    {
        startPos = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        timeTaken = timeTaken + Time.deltaTime;
        float timeCovered = timeTaken / expectedTime;
        transform.position = Vector3.Lerp(startPos, endPos, timeCovered);
        
    }
}
