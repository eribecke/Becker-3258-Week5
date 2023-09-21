using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Laser : MonoBehaviour
{
    [SerializeField] float laserSpeed;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, laserSpeed, 0) * Time.deltaTime;
    }

}
