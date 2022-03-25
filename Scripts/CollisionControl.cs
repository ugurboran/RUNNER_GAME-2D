using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CollisionControl : MonoBehaviour
{
    public TMP_Text healthText;
    public TMP_Text gradeText;
    public TMP_Text pointText;
    int grade = 0;
    int health = 3;
    GameObject wall;
    // Start is called before the first frame update
    void Start()
    {
        wall = GameObject.Find("Parent_Duvar1");
    }

    // Update is called once per frame
    void Update()
    {
        if (health == 0)
        {
            healthText.text.Equals("NO HEALTH");
            SceneManager.LoadScene("GameOverScreen");
        }

    }

    private void OnCollisionEnter2D(Collision2D collision){



        if (collision.gameObject.name.Equals("Obstacle"))
        {
            Destroy(collision.gameObject);
            health = health - 1;
            healthText.text = health.ToString();
        }

        else if (collision.gameObject.name.Equals("Obstacle (1)"))
        {
            Destroy(collision.gameObject);
            health = health - 1;
            healthText.text = health.ToString();
        }

        else if (collision.gameObject.name.Equals("Obstacle (2)"))
        {
            Destroy(collision.gameObject);
            health = health - 1;
            healthText.text = health.ToString();
        }

        else if (collision.gameObject.name.Equals("Obstacle4"))
        {
            Destroy(collision.gameObject);
            health = health - 1;
            healthText.text = health.ToString();
        }

        else if (collision.gameObject.name.Equals("Obstacle5"))
        {
            Destroy(collision.gameObject);
            health = health - 1;
            healthText.text = health.ToString();
        }

        else if (collision.gameObject.name.Equals("Obstacle6"))
        {
            Destroy(collision.gameObject);
            health = health - 1;
            healthText.text = health.ToString();
        }

        else if (collision.gameObject.name.Equals("Obstacle7"))
        {
            Destroy(collision.gameObject);
            health = health - 1;
            healthText.text = health.ToString();
        }

        else if (collision.gameObject.name.Equals("Obstacle8"))
        {
            Destroy(collision.gameObject);
            health = health - 1;
            healthText.text = health.ToString();
        }

        else if (collision.gameObject.name.Equals("Obstacle9"))
        {
            Destroy(collision.gameObject);
            health = health - 1;
            healthText.text = health.ToString();
        }

        else if (collision.gameObject.name.Equals("Obstacle10"))
        {
            Destroy(collision.gameObject);
            health = health - 1;
            healthText.text = health.ToString();
        }

        else if (collision.gameObject.name.Equals("Obstacle11"))
        {
            Destroy(collision.gameObject);
            health = health - 1;
            healthText.text = health.ToString();
        }

        else if (collision.gameObject.name.Equals("Grade1"))
        {
            Destroy(collision.gameObject);
            grade = grade + 1;
            gradeText.text = grade.ToString();
        }

        else if (collision.gameObject.name.Equals("Grade2"))
        {
            Destroy(collision.gameObject);
            grade = grade + 1;
            gradeText.text = grade.ToString();
        }

        else if (collision.gameObject.name.Equals("Grade1 (1)"))
        {
            Destroy(collision.gameObject);
            grade = grade + 1;
            gradeText.text = grade.ToString();
        }

        else if (collision.gameObject.name.Equals("Grade2 (1)"))
        {
            Destroy(collision.gameObject);
            grade = grade + 1;
            gradeText.text = grade.ToString();
        }

        else if (collision.gameObject.name.Equals("Grade2 (2)"))
        {
            Destroy(collision.gameObject);
            grade = grade + 1;
            gradeText.text = grade.ToString();
        }

        else if (collision.gameObject.name.Equals("Parent_Duvar1"))
        {
            wall.GetComponent<Animator>().SetTrigger("Activate_Bridge");
        }

        pointText.text = grade.ToString();
        
    }

}
