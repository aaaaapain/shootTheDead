using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public GameObject blood;
    public AudioClip deathClip;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
            if(hit.collider != null)
            {
                if (hit.collider.tag == "Skelton")
                {
                    AudioSource.PlayClipAtPoint(deathClip, transform.position);
                    Instantiate(blood, transform.position, Quaternion.identity);
                    gameObject.GetComponent<GameManager>().KillSkelton();
                    
                }
            }
        }
    }
}
