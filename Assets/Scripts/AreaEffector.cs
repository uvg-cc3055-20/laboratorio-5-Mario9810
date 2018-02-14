using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEffector : MonoBehaviour {
    public float time = 0;
    public bool active = true;
    public  GameObject effector; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		time = time+ Time.deltaTime;
        if (active ==false && time >= 5)
        {
            effector.SetActive(true);
            active = true;
            time = 0;
        }
        
        if(time >= 5 && active == true)
        {

            effector.SetActive(false);
            time = 0;
            active = false;
        }

	}
}
