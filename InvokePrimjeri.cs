using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokePrimjeri : MonoBehaviour
{
    int timer = 0;
    int sekunde = 0;
    int minute = default;
    [SerializeField] GameObject[] objekt;
    LineRenderer lineRenderer;

    private void Start()
    {

        lineRenderer = GetComponent<LineRenderer>();
        InvokeRepeating(nameof(Spawner), 0, 1);
    }
    private void Timer()
    {
        minute = (int)timer / 60;
        if (sekunde == 60) sekunde = 0;
        print(string.Format("{0:00} : {1:00}", minute, sekunde));
        sekunde++;
        timer++;
        lineRenderer.positionCount = timer;
        lineRenderer.SetPosition(timer - 1, new Vector3(0, timer, timer));
    }

    private void Spawner()
    {
        float randomX = Random.Range(-10f, 10f);
        float randomY = Random.Range(-11.3f, 20);
        float randomZ = Random.Range(-15.1f, 15.2f);
        int rng = Random.Range(0, objekt.Length);

        Instantiate(objekt[rng], new Vector3(randomX, randomY, randomZ), Quaternion.identity);
    }

    private void GlupiHpZadatak(ref float hp)
    {
        hp += 5;
        hp -= (hp / 100) * 2.5f;
    }
    private void OnTriggerStay(Collider other)
    {
        float hp = default;
        hp += 5 * Time.deltaTime;
    }
}
