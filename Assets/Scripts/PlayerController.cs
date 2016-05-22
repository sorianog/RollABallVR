using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class PlayerController : MonoBehaviour {

    public float speed;
    private Rigidbody rigBod;
    private int count;
    public Text countText;
    public Text winText;

    void Start()
    {
        rigBod = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }

    /// <summary>
    /// Update is called once per frame 
    /// </summary>
    void Update()
    {

    }

    /// <summary>
    /// Called before performing any physics calculations 
    /// </summary>
    void FixedUpdate()
    {
        float moveHort = Input.GetAxis("Horizontal");
        float moveVert = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHort, 0.0f, moveVert);

        rigBod.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Score: " + count.ToString();
        if (count >= 14)
        {
            winText.text = "You Win!";
        }
    }
}
