using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Trigger1 : MonoBehaviour
{
    public PlayableDirector timeline;

    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.tag == "Player1")
        {
            timeline.Play();

        }



    }



}
