using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {
    private string v;

    public Character(string name)
    {
        this.name = name;
    }

    public string Name { get; set; }
    public float cash { get; set; }
    public int tiredness { get; set; }
    public int concetration { get; set; }
    public int happiness { get; set; }



    // Use this for initialization
    void Start () {
	
	}
	

}
