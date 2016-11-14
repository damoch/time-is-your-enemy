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
    public float tiredness { get; set; }
    public float concetration { get; set; }
    public float happiness { get; set; }



    // Use this for initialization
    void Start () {
	
	}
	

}
