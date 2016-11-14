using UnityEngine;
using System.Collections;
using System;

public class Controller : MonoBehaviour {
    public DateTime time;

    //public Character player = new Character("player1");

	// Use this for initialization
	void Start () {
        //player = new Character("player1");
        time = DateTime.Parse("1.01.2016 8:00");
        Debug.Log(time.ToString());
	}
	
    public void party()
    {
        Debug.Log("Having hella good time");
    }

    public void work()
    {
        Debug.Log("Working");
    }

    public void slackOff()
    {
        Debug.Log("Slacking off");
    }
    public void drink()
    {
        Debug.Log("Drinking lotta alcohol");
    }

    public void sleep()
    {
        Debug.Log("Goodnight");
    }


}
