using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingdomSelect : MonoBehaviour
{
    public List<Kingdom> kingdoms = new List<Kingdom>();
    
    [Space]

    [Header("Public References")]
    public GameObject _kingdomPointPrefab;

    void Start()
    {
        foreach (Kingdom kingdom in kingdoms)
        {
            SpawnKingdomPoint(kingdom);
        }
    }

    private void SpawnKingdomPoint(Kingdom kingdom)
    {
        GameObject newInstance = Instantiate(_kingdomPointPrefab, Vector3.zero, Quaternion.identity);
        newInstance.transform.eulerAngles = new Vector3(kingdom.y, -kingdom.x, 0);
        newInstance.transform.SetParent(transform);
    }

    void Update()
    {
        
    }
}

[System.Serializable]
public class Kingdom
{
    public string name;

    [Range(-180, 180)]
    public float x;
    [Range(-89, 89)]
    public float y;
}
