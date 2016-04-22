using UnityEngine;
using System.Timers;
using System.Collections;

public class StopLight : MonoBehaviour {

    public Material off;
    public Material red;
    public Material yellow;
    public Material green;

    public GameObject redLight;
    public GameObject yellowLight;
    public GameObject greenLight;

    //public bool lightSwitch = true;
    public enum color { Red = 3, Yellow = 2, Green = 1};
    public int switch_on = 1;

    public float rateOfSwitch = 20.0f;
    private float switchDelay;
    // Use this for initialization
    void Start () {
        switch_on = PlayerPrefs.GetInt("switch_on", 1);
        rateOfSwitch = PlayerPrefs.GetFloat("rateOfSwitch", 20.0f);
    }
	
	// Update is called once per frame
	void Update () {
        if(Time.time > switchDelay)
        {
            switchDelay = Time.time + rateOfSwitch;
            PlayerPrefs.SetInt("switch_on", switch_on);
            PlayerPrefs.SetFloat("rateOfSwitch", rateOfSwitch);
            PlayerPrefs.Save();
            SwitchLight();
            switch_on++;
            if (switch_on > 3)
            {
                switch_on = 1;
            }
        }
	}

    void SwitchLight()
    {
        switch (switch_on)
        {
            case (int)color.Red:
                redLight.GetComponent<Renderer>().material = red;
                yellowLight.GetComponent<Renderer>().material = off;
                greenLight.GetComponent<Renderer>().material = off;
                break;
            case (int)color.Yellow:
                redLight.GetComponent<Renderer>().material = off;
                yellowLight.GetComponent<Renderer>().material = yellow;
                greenLight.GetComponent<Renderer>().material = off;
                break;

            case (int)color.Green:
                redLight.GetComponent<Renderer>().material = off;
                yellowLight.GetComponent<Renderer>().material = off;
                greenLight.GetComponent<Renderer>().material = green;
                break;

            default:
                break;
        }
    }
}