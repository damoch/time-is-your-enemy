using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;
using System.Text;

public class Controller : MonoBehaviour {
    public DateTime time;
    public Text timer;
    public Text playerInfo;
    public Character player;

	// Use this for initialization
	void Start () {
        player = GetComponent<Character>();
 

        player = createCharacter("Damian");
        updateCharacterInfo();

        time = DateTime.Parse("1.01.2016 8:00");
        timer.text = time.ToString("HH:mm");
        Debug.Log(time.ToString());
	}

    private Character createCharacter(string name)
    {
        player.name = name;
        player.cash = 2000f;
        player.tiredness = UnityEngine.Random.Range(0, 9);
        player.concetration = UnityEngine.Random.Range(0, 9);
        player.happiness = UnityEngine.Random.Range(80, 89);
        return player;
    }

    private void updateCharacterInfo()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Name: ");
        sb.Append(player.name);
        sb.Append("\n");
        sb.Append("Cash: $");
        sb.Append(player.cash.ToString());
        sb.Append("\n");
        sb.Append("Tiredness: ");
        sb.Append(player.tiredness.ToString());
        sb.Append("%\n");
        sb.Append("Concetration: ");
        sb.Append(player.concetration.ToString());
        sb.Append("%\n");
        sb.Append("Happiness: ");
        sb.Append(player.happiness.ToString());
        sb.Append("%\n");

        playerInfo.text = sb.ToString();
    }

    public void party()
    {
        Debug.Log("Having hella good time");
    }

    public void work()
    {
        time=time.AddHours(1);

        timer.text = time.ToString("HH:mm");
        player.tiredness += UnityEngine.Random.Range(0, 9);
        updateCharacterInfo();
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
