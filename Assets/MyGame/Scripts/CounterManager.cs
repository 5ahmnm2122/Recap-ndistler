using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterManager : MonoBehaviour
{
    [SerializeField] Text counttxt;
    [SerializeField] int counter;
    [SerializeField] GameObject winner;

    public void AddCounter()
    {
        counter = counter + 1;

        counttxt.text = counter.ToString();

        if (counter == 10)
        {
            winner.SetActive(true);
            GetComponent<GameManager>().StopAllCoroutines();
        }
    }
}
