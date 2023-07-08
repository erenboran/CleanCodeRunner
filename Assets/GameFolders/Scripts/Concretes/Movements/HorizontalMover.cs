using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UdemyProject2.Controller;


namespace UdemyProject2.Movements
{
    public class HorizontalMover
    {

        PlayerController _playerController;

        float _moveSpeed;
        float _moveBoundry;


        public HorizontalMover(PlayerController playerController)
        {
            _playerController = playerController;
            _moveSpeed = playerController.MoveSpeed;
            _moveBoundry = playerController.MoveBoundry;
        }

        public void TickFixed(float horizontal)
        {
            if (horizontal == 0f) return;

            _playerController.transform.Translate(Vector3.right * horizontal * Time.deltaTime * _moveSpeed);

            float xBoundary = Mathf.Clamp(_playerController.transform.position.x, -_moveBoundry, _moveBoundry);

            _playerController.transform.position = new Vector3(xBoundary, _playerController.transform.position.y, 0f);
        }
    }
}



