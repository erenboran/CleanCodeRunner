using System;
using System.Collections;
using System.Collections.Generic;
using UdemyProject2.Movements;
using UnityEngine;


namespace UdemyProject2.Controller
{
    public class EnemyController : MonoBehaviour
    {
        [SerializeField] float _moveSpeed = 10f;
        VerticalMover _mover;
        public float MoveSpeed => _moveSpeed;

        [SerializeField] float _maxLifeTime = 10f;
        float _currentTime;

        void Awake()
        {
            _mover = new VerticalMover(this);
        }


        private void Update()
        {
            _currentTime += Time.deltaTime;
            if (_currentTime > _maxLifeTime)
            {
                _currentTime = 0f;
                KillYourSelf();

            }
        }


        // Update is called once per frame
        void FixedUpdate()
        {
            _mover.FixedTick();

        }

        void KillYourSelf()
        {
            Destroy(this.gameObject);
        }
    }

}

