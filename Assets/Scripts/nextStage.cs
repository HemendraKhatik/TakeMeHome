using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextStage : MonoBehaviour {

    [SerializeField]
    string strStage;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == strStage)
            Debug.Log("colliosion detect");
            SceneManager.LoadScene("level02");
    }
}
