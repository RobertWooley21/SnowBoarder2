using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        [SerializeField] float loadDelay;
        [SerializeField] ParticleSystem finishEffect;
    }
    // Start is called before the first frame update
    void Start()
    {
        finishEffect.play();
        Debug.Log("your Finush");
        GetComponent<Aido>   
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
