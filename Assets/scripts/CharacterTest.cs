using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assignment18
{
    public class CharacterTest : MonoBehaviour
    {
        void Start()
        {

            Soldier soldier = new Soldier();


            Officer officer = new Officer("Captain basmalah", 90, new Position(5, 5, 5));


            Character[] characters = { soldier, officer };


            for (int i = 0; i < characters.Length; i++)
            {
                characters[i].DisplayInfo();
            }


            Debug.Log("Soldier's Health before attack: " + soldier.Health);


            officer.Attack(20, soldier, "shooting");


            Debug.Log("Soldier's Health after attack: " + soldier.Health);
        }
    }
}



