using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownHall : Building
{
    [SerializeField] GameObject unit;
    [SerializeField] Transform spawnLocation;
    float timer = 0.0f;

    public static float OrcSpawnTime = 10.0f;
    public static float HumanSpawnTime = 10.0f;

    float spawnTime;

    void Update()
    {
        spawnTime = (race == Races.Human) ? HumanSpawnTime : OrcSpawnTime;
       if (timer >= spawnTime)
        {
            timer = 0.0f;
            GameObject spawnedUnit = Instantiate(unit, spawnLocation.position, Quaternion.identity);
            if (spawnedUnit.tag == "Player")
                spawnedUnit.GetComponent<CharacterController>().OnDeselect();
        }

        timer += Time.deltaTime;
    }
}
