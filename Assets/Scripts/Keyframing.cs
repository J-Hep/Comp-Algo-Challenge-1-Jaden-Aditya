using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyframing : MonoBehaviour
{

    public GameObject item;
    public float waitingDuration = 2f;
    public Vector3[] keyFrameArray;

    public void KeyFrame(Vector3[] keys, GameObject inputItem, float wD, string style)
    {

        switch (style)
        {

            case "position":
                StartCoroutine(timingPosition());
                IEnumerator timingPosition()
                {

                    for (int i = 0; i < keys.Length; i++)
                    {
                        inputItem.transform.position = keys[i];
                        yield return new WaitForSeconds(wD);
                        print("WAITING");

                    }
                }
                break;

            case "scale":
                StartCoroutine(timingScale());
                IEnumerator timingScale()
                {

                    for (int i = 0; i < keys.Length; i++)
                    {
                        inputItem.transform.localScale = keys[i];
                        yield return new WaitForSeconds(wD);
                        print("WAITING");

                    }
                }
                break;

            case "rotate":
                StartCoroutine(timingRotate());
                IEnumerator timingRotate()
                {

                    for (int i = 0; i < keys.Length; i++)
                    {
                       // inputItem.transform.rotation = keys[i];
                        yield return new WaitForSeconds(wD);
                        print("WAITING");

                    }
                }
                break;



        }
           
        
    }


    // Start is called before the first frame update
    void Start()
    {
        Vector3[] vec = { new Vector2(160, 200), new Vector2(160, 300), new Vector2(160, 375)};

        KeyFrame(keyFrameArray, item, waitingDuration, "position");
    }


    float time = 0;

    // Update is called once per frame
    void Update()
    {

         time += Time.deltaTime;

    }

  
}
