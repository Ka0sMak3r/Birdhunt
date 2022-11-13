using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillCounter : MonoBehaviour
{

    public Text counter;
    int killcount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DisplayKills();
    }

    public void KillIncrement()
    {
        killcount++;
    }

    public void DisplayKills()
    {
        counter.text = killcount.ToString();
    }
}
