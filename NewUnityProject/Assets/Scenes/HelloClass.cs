using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Animal jack = new Animal();
        jack.name = "Jack";
        jack.sound = "Bark";
        jack.weight = 4.5f;

        Animal nate = new Animal();
        nate.name = "Nate";
        nate.sound = "Nyaa";
        nate.weight = 1.2f;

        Animal annie = new Animal();
        annie.name = "Annie";
        annie.sound = "wee";
        annie.weight = 0.5f;

        nate = jack;

        nate.name = "JIMMY";

        Debug.Log(jack.name);
        Debug.Log(jack.sound);
        Debug.Log(nate.name);
        Debug.Log(nate.sound);
        Debug.Log(annie.name);
        Debug.Log(annie.sound);
    }
}

public class Animal
{
    public string name;
    public string sound;
    public float weight;

}