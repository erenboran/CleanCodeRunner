using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyProject2.Controller
{
    public class SpawnController : MonoBehaviour
    {


        [SerializeField] EnemyController _enemyPrefab;
        [Range(0.1f, 5f)] [SerializeField] float _min = 0.1f;
        [Range(6f, 15f)] [SerializeField] float _max = 15f;
        float _maxSpawnTime;


        float _currentSpawnTime = 0f;
        private void OnEnable()
        {
            GetRandomMaxTime();
        }
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            _currentSpawnTime += Time.deltaTime;

            if (_currentSpawnTime > _maxSpawnTime)
            {
                Spawn();
            }
        }

        void Spawn()
        {
            EnemyController newEnemy = Instantiate(_enemyPrefab, transform.position, transform.rotation);
            newEnemy.transform.parent = this.transform;
            _currentSpawnTime = 0f;
            GetRandomMaxTime();
        }

        private void GetRandomMaxTime()
        {
            _maxSpawnTime = Random.Range(_min, _max);
        }
    }
}

