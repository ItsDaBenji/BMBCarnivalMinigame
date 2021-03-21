using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMBFillCanister : MonoBehaviour
{

    [SerializeField] float currentFill = 0, maxFill;
    [SerializeField] float fillRate;

    private void FillCanister()
    {
        Debug.Log("Filling");
        currentFill += fillRate * Time.deltaTime;
        if(currentFill >= maxFill)
        {
            Debug.Log("Completely filled");
            BMBGameManager.instance.score += 10;
            Destroy(gameObject);
        }
    }
    
}
