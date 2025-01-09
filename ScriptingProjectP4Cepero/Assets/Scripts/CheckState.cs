using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckState : MonoBehaviour
{
    public GameObject MyObject;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Active Self: " + MyObject.activeSelf);
        Debug.Log("Active in Hierarchy" + MyObject.activeInHierarchy);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
