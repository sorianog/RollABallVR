using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start () {
        offset = transform.position - player.transform.position;
	}

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update () {
        transform.position = player.transform.position + offset;
	}
}
