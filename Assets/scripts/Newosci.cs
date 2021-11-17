using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Newosci : MonoBehaviour
{



    [SerializeField]
    [Tooltip("speed")]
    float speed = 2f;

    [SerializeField]
    [Tooltip("border")]
    float Border = 5f;

    Vector3 curVel = new Vector3(-1, 0, 0);

    void Start()
    {
        Transform t = GetComponent<Transform>();

        //t.position = Position;
        Vector3 Position = t.position;
        //timer = 0;
        speed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        Transform t = GetComponent<Transform>();
        if (t.position.x >= Border)
            curVel = new Vector3(-0.1f * speed, 0f, 0f);
        if (t.position.x <= -Border)
            curVel = new Vector3(0.1f * speed, 0f, 0f);

        t.position += curVel;



        /*timer += Time.deltaTime;
        curVel.x = oscillated(timer, speed, Border);
        t.position = (Position + curVel); // startpos.x+[-10....10] = [10*cos(time*speed)*/
    }

    float oscillated(float time, float speed, float scale)
    {
        return Mathf.Cos(time * speed) * scale;
    }

}
