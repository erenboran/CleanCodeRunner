using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UdemyProject2.Movements;
using UdemyProject2.Abstract.Inputs;
using UdemyProject2.Inputs;
using UnityEngine.InputSystem;
    
namespace UdemyProject2.Controller
{
    public class PlayerController : MonoBehaviour
    {

        [SerializeField] float _moveSpeed = 10f;
        [SerializeField] float _moveBoundry = 4.5f;
        [SerializeField] float _jumpForce = 300f;
        [SerializeField] bool _isJump;

        HorizontalMover _horizontalMover;
        JumpWithRigidbody _jump;

        float _horizontal;
        
        IInputReader _input;

        public float MoveSpeed => _moveSpeed;
        public float MoveBoundry => _moveBoundry;

        private void Awake()
        {
            _horizontalMover = new HorizontalMover(this);
            _jump = new JumpWithRigidbody(this);
            _input = new InputReader(GetComponent<PlayerInput>());
        }

        void Update()
        {
            _horizontal = _input.Horizontal;

            if(_input.IsJump)
            {
                _isJump = true;
            }
        }
        private void FixedUpdate()
        {
            _horizontalMover.TickFixed(_horizontal);

            if(_isJump)
            {
                _jump.TickFixed(_jumpForce);
            }
            _isJump = false;

        }
        // Update is called once per frame

    }

}

