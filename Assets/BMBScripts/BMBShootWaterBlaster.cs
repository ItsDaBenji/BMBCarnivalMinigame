using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMBShootWaterBlaster : MonoBehaviour
{

    [SerializeField] Transform raySpawn;
    [SerializeField] float rayDistance;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hitInfo;

            if (Physics.Raycast(raySpawn.position, -transform.forward, out hitInfo, rayDistance))
            {
                if (hitInfo.collider.gameObject.CompareTag("Canister"))
                {
                    hitInfo.transform.SendMessage("FillCanister");
                }
                else
                {
                    Debug.Log("Missed");
                }
            }
        }
    }

}
