using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weight : MonoBehaviour {
    DistanceJoint2D distanceJoint;
    LineRenderer line;
    // Use this for initialization
    void Start () {

        distanceJoint = GetComponent<DistanceJoint2D>();
        line = GetComponent<LineRenderer>();


    }

    // Update is called once per frame
    void Update () {
        line.SetPosition(0, transform.position);
        line.SetPosition(1,
        distanceJoint.connectedBody.transform.position);
    }
}
