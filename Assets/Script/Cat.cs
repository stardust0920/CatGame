using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cat : MonoBehaviour
{

    public int hp = 5;
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-2f, 2f);
        float y = 5.5f;
        transform.position = new Vector3(x, y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, -0.02f, 0);
        if(transform.position.y < -4)
        {
            SceneManager.LoadScene("MainScene");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "food")
        {
            hp -= 1;
            if(hp < 0)
            {
                GameManager.instance.killScore += 1;
                Destroy(gameObject);
            }
        }
    }
}
