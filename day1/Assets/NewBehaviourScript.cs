using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

     string heroName = "mr.moad";
        int heroAge = 26;
        float heroHeight = 176.8f;
        string heroSuperPower = "super spee";

        string villainName = "demon";
        int villainAge = 55;
        float vililanHeight = 177.5f;
        string villainSuperPower = "Laser shooting";



        int ageDifference = 55 - 26 ;

    string VillainSuperPower = "none";

    // Start is called before the first frame update
    void Start()
    {
        
        print(ageDifference);
        print (heroName + heroAge + heroHeight + heroSuperPower );
        print (villainName + villainAge + vililanHeight + villainSuperPower);
        print(heroAge + 5);

     

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
