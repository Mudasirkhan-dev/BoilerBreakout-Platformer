using System.Collections;
using System.Collections.Generic;
using TarodevController;
using UnityEngine;

public class RespawnScript : MonoBehaviour
{
    [SerializeField] private GameObject player;
    public GameObject respawnPoint;

    public GameObject deathParticles;
    public GameObject spwanParticles;


    public void DieAndSpawn()
    {
        StartCoroutine(DieByDisablePlayerGO());
    }


    public IEnumerator DieByDisablePlayerGO ()
    {
        if (player.transform.parent != null)
        {
            player.transform.SetParent(null);

            player.SetActive(false);
            GameObject deathFx = Instantiate(deathParticles.gameObject, player.transform.position, Quaternion.identity);
            Destroy(deathFx, 2f);
            Debug.Log("Die");
            yield return new WaitForSeconds(2f);
            player.transform.position = respawnPoint.transform.position;
            GameObject SpwanFx = Instantiate(spwanParticles.gameObject, player.transform.position, Quaternion.identity);
            player.SetActive(true);
            Destroy(SpwanFx, 2f);
            Debug.Log("Spawn");
        }
        else
        {
            player.SetActive(false);
            GameObject deathFx = Instantiate(deathParticles.gameObject, player.transform.position, Quaternion.identity);
            Destroy(deathFx, 2f);
            Debug.Log("Die");
            yield return new WaitForSeconds(2f);
            player.transform.position = respawnPoint.transform.position;
            GameObject SpwanFx = Instantiate(spwanParticles.gameObject, player.transform.position, Quaternion.identity);
            player.SetActive(true);
            Destroy(SpwanFx, 2f);
            Debug.Log("Spawn");


        }

        //player.SetActive(false);
        //GameObject deathFx = Instantiate(deathParticles.gameObject, player.transform.position, Quaternion.identity);
        //Destroy(deathFx, 2f);
        //Debug.Log("Die");
        //yield return new WaitForSeconds(2f);
        //player.transform.position = respawnPoint.transform.position;
        //GameObject SpwanFx = Instantiate(spwanParticles.gameObject, player.transform.position, Quaternion.identity);
        //player.SetActive(true);
        //Destroy(SpwanFx, 2f);
        //Debug.Log("Spawn");


    }
}