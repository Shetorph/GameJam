using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] List<GameObject> checkpoints;
    [SerializeField] Vector3 vectorPoint;
    [SerializeField] float dead;

    private void Update()
    {
        if(player.transform.position.y < -dead)
        {
            player.transform.position = vectorPoint;
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        vectorPoint = player.transform.position;
        Destroy(col.gameObject);
    }
}
