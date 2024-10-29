using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureSpawner : MonoBehaviour
{

    // Reference to the creature prefab
    public GameObject creaturePrefab;

    // Spawn locations for the creatures
    public Vector3 spawnLocation1 = new Vector3(0, 0, 0);   // Adjust positions as needed
    public Vector3 spawnLocation2 = new Vector3(2, 0, 2);
    public Vector3 spawnLocation3 = new Vector3(-2, 0, -2);

    // Start is called before the first frame update
    void Start()
    {
        // Check if the creaturePrefab is assigned
        if (creaturePrefab == null)
        {
            Debug.LogError("Creature prefab is not assigned in the inspector!");
            return;
        }

        // Instantiate 3 copies of the creature at specified locations
        Instantiate(creaturePrefab, spawnLocation1, Quaternion.identity);
        Instantiate(creaturePrefab, spawnLocation2, Quaternion.identity);
        Instantiate(creaturePrefab, spawnLocation3, Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
