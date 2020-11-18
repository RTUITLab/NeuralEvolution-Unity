using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour
{
    [SerializeField]
    private GameObject foodPrefab;
    private List<GameObject> foodInstances = new List<GameObject>();
    [SerializeField]
    private int startFoodCount = 1;

    // for spawn food
    public  Vector3 foodPos { get; private set; }


    private void Start()
    {

        for (int i = 0; i < startFoodCount; i++)
            CreateFood();
    }

    void Update()
    {
       
    }

    private void CreateFood()
    {
        foodPos = new Vector3(Random.Range(-7f, 7f), 0.6f, Random.Range(-7f, 7f));
        foodInstances.Add(Instantiate(foodPrefab, foodPos, new Quaternion()));
        //foodInstances[foodInstances.Count - 1].GetComponent<Food>().foodManager = this;
        // foodCount++;
    }

    public void DestroyFoodInstance(GameObject foodInstance)
    {
        foodInstances.RemoveAt(foodInstances.IndexOf(foodInstance));
        Destroy(foodInstance);
        CreateFood();
    }
}
