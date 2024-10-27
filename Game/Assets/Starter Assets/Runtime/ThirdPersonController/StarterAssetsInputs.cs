using UnityEngine;
#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
#endif

namespace StarterAssets
{
    public class StarterAssetsInputs : MonoBehaviour
    {
        public Vector2 move;
        public Vector2 look;
        public bool jump;
        public bool sprint;
        public bool analogMovement;
        public bool aim;   
        public bool hit;   
        public bool ball;  

#if ENABLE_INPUT_SYSTEM
        public void OnMove(InputValue value)
        {
            MoveInput(value.Get<Vector2>());
        }

        public void OnLook(InputValue value)
        {
            LookInput(value.Get<Vector2>());
        }

        public void OnJump(InputValue value)
        {
            JumpInput(value.isPressed);
        }

        public void OnSprint(InputValue value)
        {
            SprintInput(value.isPressed);
        }

        public void OnAim(InputValue value)  // Add this method
        {
            AimInput(value.isPressed);
        }

        public void OnHit(InputValue value)  // Add this method
        {
            HitInput(value.isPressed);
        }

        public void OnBall(InputValue value)  // Add this method
        {
            BallInput(value.isPressed);
        }
#endif

        public void MoveInput(Vector2 newMoveDirection)
        {
            move = newMoveDirection;
        }

        public void LookInput(Vector2 newLookDirection)
        {
            look = newLookDirection;
        }

        public void JumpInput(bool newJumpState)
        {
            jump = newJumpState;
        }

        public void SprintInput(bool newSprintState)
        {
            sprint = newSprintState;
        }

        public void AimInput(bool newAimState)  // Add this method
        {
            aim = newAimState;
        }

        public void HitInput(bool newHitState)  // Add this method
        {
            hit = newHitState;
        }

        public void BallInput(bool newBallState)  // Add this method
        {
            ball = newBallState;
        }
    }
}
