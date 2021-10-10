using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Coin")
        {
            gameObject.GetComponent<CoinCounter>().coins++;
            Destroy(col.gameObject);
        }
    }
}
