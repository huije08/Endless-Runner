using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RoadManager : MonoBehaviour
{

    [SerializeField] List <GameObject> roads;
   
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < roads.Count; i++)
        {
            roads[i].transform.Translate(SpeedTreeImporter * Vector3.back * Time.deltaTime);
        }
    }
}
