using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellCraft : MonoBehaviour
{
    GameObject ally;
    GameObject enemy;
    GameObject thing;
    GameObject self;

   public  GameObject form;

    SpellBound spell;


     // Start is called before the first frame update
    void Start()
    {
        ally = GameObject.FindGameObjectWithTag("Ally");
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        thing = GameObject.FindGameObjectWithTag("Object");
        self = GameObject.FindGameObjectWithTag("Player");

        Debug.Log("tiene forma");
        spell = new SpellBound(enemy, form);

     }
    private void Update()
    {
        
    }
    public void throwing()
    {

    }

 


    public void myDropdownValueChangedHandler(Dropdown objectivesDropDown)
    {
        switch (objectivesDropDown.value)
        {
            case 0:
                Debug.Log("Self");
                spell.objective = ally;
                break;


            case 1:
                Debug.Log("Alli");
                spell.objective = enemy;
                break;

            case 2:
                spell.objective = thing;
                Debug.Log("Enemy");
                break;

            case 3:
                spell.objective = thing;
                Debug.Log("object");
                break;


        }
    }

    public void bottonSpell()
    {
        int vel = 5;

        GameObject unoMas = Instantiate(spell.type ,new Vector3(0,2,0),Quaternion.identity) as GameObject;
      //  Debug.Log("Llego aqui loco " + "esto es " self);
        //throwing(unoMas, );
    }


}
