using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity1WeekAtsumeru {
    public class KeyDownInputProvider : IInputProvider {
        bool IInputProvider.GetAttack() {
            return Input.GetKeyDown(KeyCode.Space);
        }

        Direction2D IInputProvider.GetMovement() {
            if (Input.GetKey(KeyCode.UpArrow)) {
                return Direction2D.Up;
            } else if (Input.GetKey(KeyCode.DownArrow)) {
                return Direction2D.Down;
            } else if (Input.GetKey(KeyCode.RightArrow)) {
                return Direction2D.Right;
            } else if (Input.GetKey(KeyCode.LeftArrow)) {
                return Direction2D.Left;
            } else {
                return Direction2D.None;
            }
        }
    }
}
