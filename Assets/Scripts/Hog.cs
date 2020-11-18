using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hog : MonoBehaviour
{
    [SerializeField]
    private GameObject foodPrefab;
    [SerializeField]
    private int health = 100;
    [SerializeField]
    private int satiety = 100;
    [SerializeField]
    private float updatedTime = 5f;
    [SerializeField]
    private float epsilon;
    [SerializeField]
    private float epsilonAngle;
    [SerializeField]
    private float maxRange = 15f;
    [SerializeField]
    private float alpha = 1.2f;

    private float range = 1f;

    private int eatCounter = 0;

    private HogMovement movement;
    private GameObject foodInstance;
    private int initHealth;
    private int initSatiety;
    private float time = 0f;
    private Vector3 foodPos;    
    private Vector3 startPos;

    private float prevDist;
    private float foodDist;
    private float delta = 0f;

    private float angle = 0f;
    private float prevAngle = 0f;
    private float deltaAngle = 0f;


    private float reward = 0f;

    private float rewardSum = 0f;

    private int deaths = 0;

    private bool isAlive;

    private Client client;
    private Action action = new Action {Action_ = 0};

    private IEnumerator ServerCall()
    {
        float k = 0;
        float m = 0f;
        float isEated = 0f;

        foodPos = foodInstance.transform.position - transform.position;
        foodDist = foodPos.magnitude;
        angle = Vector3.SignedAngle(foodPos, transform.forward, Vector3.up);

        delta = foodDist - prevDist;
        deltaAngle = angle - prevAngle;

        reward = 0f;

        // Debug.Log("Delta - " + delta.ToString());

        // update Hog status
        if (time > updatedTime)
        {
            UpdateHealth();
            UpdateSatiety();
            time = 0f;
        }
        
        // calculate rewards
        if (action.Action_ == 4 && Food.isNear)
        {
            Debug.Log("Eat");
            isEated = 1f;
            health = initHealth;
            satiety = initSatiety;
            Food.isNear = false;
            eatCounter += 1;
            if (range < maxRange)
                range *= alpha;
            Destroy(foodInstance);
            CreateFood();
        }

        if (delta < 0 && delta < -epsilon)
        {
            k = 0.1f;
        }
        else if (delta > 0 && delta > epsilon)
        {
            k = -0.1f;
        }

        //if (deltaAngle < 0 && deltaAngle < -epsilonAngle)
        //{
        //    m = 0.1f;
        //}
        //else if (deltaAngle > 0 && deltaAngle > epsilonAngle)
        //{
        //   m = -0.1f;
        //}
        //if (Mathf.Abs(angle) < 90f)
        //{
        //    m = 1f - Mathf.Abs(angle) / 90f;
        //}
        //else
        //{
        //    m = -(Mathf.Abs(angle) / 90f - 1f);
        //}

        if (Mathf.Abs(angle) < deltaAngle)
            m = 0.05f;

        if (health <= 0)
        {
            reward = -1f;
            deaths += 1;
            isAlive = false;
        } 
        else
        {
            reward = isEated + m + k;
        }
        
        action = client.SendData(BuildData());

        Debug.Log("Action" + action.Action_.ToString());

        rewardSum += reward;

        if (!isAlive)
        {
            ReloadHog();
        }

        prevDist = foodDist;
        prevAngle = angle;

        yield return new WaitForSeconds(0.5f);
        StartCoroutine(ServerCall());
    }

    private EnvData BuildData()
    {
        EnvData new_data = new EnvData();
        new_data.IsAlive = isAlive;
        new_data.FoodX = foodDist;
        new_data.FoodZ = angle;
        new_data.Hp = health;
        new_data.Satiety = satiety;
        new_data.Reward = reward;

        return new_data;
    }

    private AgentData NewAgent()
    {
        AgentData data = new AgentData();
        data.EnvShape = 4;
        data.NumActions = 5;
        return data;
    }

    private void Start()
    {
        movement = GetComponent<HogMovement>();
        isAlive = true;
        CreateFood();
        
        startPos = transform.position;
        initHealth = health;
        initSatiety = satiety;

        prevDist = (foodPos - startPos).magnitude;
        prevAngle = Vector3.SignedAngle(foodPos, transform.forward, Vector3.up);

        // init brain
        client = new Client();
        AgentId agent = client.CreateAgent(NewAgent());
        StartCoroutine(ServerCall());
    }

    private void Update()
    {
        time += Time.deltaTime;
        movement.Move(action);
    }

    private void UpdateSatiety()
    {
        if (satiety > 0)
        {
            satiety -= 10;
            if (satiety < 0)
                satiety = 0;
        }
    }

    private void UpdateHealth()
    {
        if (satiety == 0 && health > 0)
        {
            health -= 10;
        }
    }

    private void ReloadHog()
    {
        health = initHealth;
        satiety = initSatiety;
        transform.position = startPos;
        reward = 0f;
        isAlive = true;
    }

    private void CreateFood()
    {
        Mathf.Min(maxRange, range);
        foodPos = new Vector3(Random.Range(-range, range), -0.5f, Random.Range(-range, range)) + transform.position;
        foodPos.x = Mathf.Clamp(foodPos.x, -maxRange, maxRange);
        foodPos.z = Mathf.Clamp(foodPos.z, -maxRange, maxRange);
        foodInstance = Instantiate(foodPrefab, foodPos, new Quaternion());
    }
}

