using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ceiling : MonoBehaviour
{
    public bool isDroped = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("load scene");
            SceneManager.LoadScene("JsStage1");
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision != null)
        {
            this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }
}
