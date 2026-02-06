using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            float x = Random.Range(-10, 10);
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            if (animalPrefabs[animalIndex] != null)
            {
                Instantiate(animalPrefabs[animalIndex],
                    new Vector3(x, 0, 20),
                    Quaternion.Euler(0, 180, 0));
            }
            else
            {
                Debug.LogWarning($"null prefab at index {animalIndex}");
            }
        }
    }
}
