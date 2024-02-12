using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BallReset : MonoBehaviour
{
    float left_right = 5f; //[-55]
    
    //Transform initial;
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        //initial = transform;
        if (this.transform.position.x < -left_right || this.transform.position.x > left_right)
        {
            SceneManager.LoadScene(0);
        }
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.name == "Lane")
    //    {
    //        this.transform.position = initial.position;
    //        this.GetComponent<Rigidbody>().velocity = Vector3.zero;
    //        this.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    //    }
    //}
}
