using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour 
{
    public GameObject cowPrefab;
    public float respawnTime = 1.0f;
    private Vector3 screenBounds;

    // Use this for initialization
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(Wave());
    }
    private void spawnEnemy()
    {
        GameObject a = Instantiate(cowPrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x * -2, Random.Range(-screenBounds.y, screenBounds.y));
    }
    IEnumerator Wave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
    









}


    //public GameObject[] spawnPoints;
    //GameObject currentPoint;
    //int index;

    //public GameObject[] enemies;
    //public float minTimeBtwSpawns;
    //public float maxTimeBtwSpawns;
    //public bool canSpawn;
    //public float spawnTime;
    //public int enemiesInRoom;
    //public bool spawnerDone;
    ////public GameObject spawnerDoneGameObject;

    //private void Start()
    //{
    //    Invoke("SpawnEnemy", 0.5f);
    //}

    //private void Update()
    //{
    //    if (canSpawn)
    //    {
    //        spawnTime -= Time.deltaTime;
    //        if (spawnTime < 0)
    //        {
    //            spawnTime = 2;
    //        }
    //    }
    //}

    //void SpawnEnemy()
    //{
    //    index = Random.Range(0, spawnPoints.Length);
    //    currentPoint = spawnPoints[index];
    //    float timeBtwSpawns = Random.Range(minTimeBtwSpawns, maxTimeBtwSpawns);

    //    if (canSpawn)
    //    {
    //        Instantiate(enemies[Random.Range(0, enemies.Length)], currentPoint.transform.position, Quaternion.identity);
    //        enemiesInRoom++;
    //    }

    //    //Invoke("SpawnEnemy", timeBtwSpawns);
    //    //if (spawnerDone)
    //    //{
    //    //    spawnerDoneGameObject.SetActive(true);
    //    //}
    //}

//private int waveCount; // This will keep track of the wave count, and increase the number when necessary

//private int enemyCount;
//public GameObject enemyPrefab;
//private float spawnRate = 1.0f;
//private float waveTextTimer = 1.0f;
//private float timeBetweenWaves = 5.0f; //How long it takes for each wave to start
//private float spawnRange = 9.0f;

//[SerializeField] private TextMeshProUGUI _waveCountTxt;
//[SerializeField] private TextMeshProUGUI _bossWaveIndicatorTxt;
//[SerializeField] private bool _isWaveActive = true; //This is needed to control the coroutine which we’ll code in the next segment of this article
//[SerializeField] private bool _stopSpawning = false;
//private void Start()
//{
//    StartCoroutine(waveSpawner());
//}
//IEnumerator waveSpawner()
//{
//    while(_isWaveActive == true && _stopSpawning == false)
//    {
//        Vector3 spawnPos = new Vector3(Random.Range(-9.3f, 9.3f), 7f, 0f);
//        int randomEnemy = Random.Range(0, 5);
//        _isWaveActive = false;

//        for(int i = 0; i < enemyCount; i++)
//        {
//            ActivateWaveText();
//            yield return new WaitForSeconds(waveTextTimer);
//            _waveCountTxt.gameObject.SetActive(false);
//            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
//            //GameObject enemyClone = Instantiate(enemies[randomEnemy], spawnPos, Quaternion.identity);
//            yield return new WaitForSeconds(spawnRate);

//            if(waveCount >= 5)
//            {
//                _bossWaveIndicatorTxt.gameObject.SetActive(true);
//                EndEnemyWaves();
//                yield return new WaitForSeconds(3f);
//                Debug.Log("Final boss stage!");

//            }
//        }
//        spawnRate -= 1;
//        enemyCount += 1;
//        yield return new WaitForSeconds(timeBetweenWaves);
//        waveCount += 1;
//        _isWaveActive = true;


//    }
//}
//public void EndEnemyWaves()
//{
//    _stopSpawning = true;
//    GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
//    foreach(GameObject enemy in enemies)
//    {
//        GameObject.Destroy(enemy);
//    }
//}
// private void ActivateWaveText()
//{
//    _waveCountTxt.text = "Wave: " + waveCount.ToString();
//    _waveCountTxt.gameObject.SetActive(true);
//}

//private Vector3 GenerateSpawnPosition()
//{
//    float spawnPosX = Random.Range(-spawnRange, spawnRange);
//    float spawnPosZ = Random.Range(-spawnRange, spawnRange);

//    Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);

//    return randomPos;
//}
//Enemy Reference
//    public GameObject enemyPrefab;
//    private float spawnRange = 9.0f;
//    public int enemyCount;
//    public int waveNumber = 1;

//    void Start()
//    {
//        SpawnEnemyWave(waveNumber);


//    }


//    void Update()
//    {
//        enemyCount = FindObjectsOfType<Enemy>().Length;

//        //keeps tracks for enemies whenevr they get destroyed
//        if (enemyCount == 0)
//        {
//            waveNumber++;
//            SpawnEnemyWave(waveNumber);

//        }
//    }
//    void SpawnEnemyWave(int enemiesToSpawn)
//    {
//        for (int i = 0; i < enemiesToSpawn; i++)
//        {
//            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
//        }
//    }

//    private Vector3 GenerateSpawnPosition()
//    {
//        float spawnPosX = Random.Range(-spawnRange, spawnRange);
//        float spawnPosZ = Random.Range(-spawnRange, spawnRange);

//        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);

//        return randomPos;
//    }

//}
