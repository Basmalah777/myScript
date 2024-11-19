using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18
{

    public class GenericsTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            GameContainer<string> stringContainer = new GameContainer<string>();
            stringContainer.SetItem("Healing Position");
            string storedItem = stringContainer.GetItem();
            Debug.Log("Stored item : " + storedItem);
            string description = GameUtils.DescribeItem(storedItem);
            Debug.Log(description);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
