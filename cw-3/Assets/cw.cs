using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cw : MonoBehaviour
{
    string heroname = "Othman";
    int heropower = 3000;
    string villainname = "Abdurahman";
    int villainpower = 1000;
    float playerspeed = 10.0f;
    float speed = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        if (heropower > villainpower)
        {
            print("Othman is stronger than Abdulrahman");
        }
        else if (heropower == villainpower) 
        {
            print("They are equal");
        }
        else
        {
            print("Abdulrahman is stronger than Othman");
        }
        print(playerspeed);
        print(speed);
    }
    // Update is called once per frame
    void Update()
    {

    }
    void setspeed(float newspeed)
    {
        print("old speed is" + playerspeed);
        playerspeed = newspeed;
        print("new speed is" + playerspeed);
    }
}
