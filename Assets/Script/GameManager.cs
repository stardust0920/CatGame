using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int killScore = 0;
    public Text killText;
    public GameObject cat;
    public GameObject food;
    public GameObject dog;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        InvokeRepeating("MakeFood", 0f, 0.1f);
        InvokeRepeating("MakeCat", 0f, 0.7f);
    }
    void MakeCat()
    {
        Instantiate(cat);
    }

    private void Update()
    {
        killText.text = killScore.ToString();
    }

    // Update is called once per frame
    void MakeFood()
    {
        float x = dog.transform.position.x;
        float y = dog.transform.position.y + 0.2f;
        Instantiate(food, new Vector3(x, y, 0), Quaternion.identity);
    }
}
