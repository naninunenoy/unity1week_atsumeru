using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity1WeekAtsumeru {
    public enum Direction2D {
        None = 0,
        Up,
        Down,
        Right,
        Left
    }

    public static class DirectionExtension {
        private static Quaternion leftRotation = Quaternion.AngleAxis(90.0F, Vector3.forward);
        private static Quaternion downRotation = Quaternion.AngleAxis(180.0F, Vector3.forward);
        private static Quaternion rightRotation = Quaternion.AngleAxis(270.0F, Vector3.forward);
        public static Quaternion ToRotation(this Direction2D direction) {
            switch (direction) {
            case Direction2D.Left:
                return leftRotation;
            case Direction2D.Down:
                return downRotation;
            case Direction2D.Right:
                return rightRotation;
            case Direction2D.Up:
            default:
                return Quaternion.identity;
            }
        }

        public static Vector3 ToUnitVector3(this Direction2D direction) {
            switch (direction) {
            case Direction2D.Up:
                return Vector3.up;
            case Direction2D.Down:
                return Vector3.down;
            case Direction2D.Right:
                return Vector3.right;
            case Direction2D.Left:
                return Vector3.left;
            default:
                return Vector3.zero;
            }
        }

        public static void Rotate2D(this Transform transform, Direction2D to) {
            switch (to) {
            case Direction2D.Up:
            case Direction2D.Down:
            case Direction2D.Right:
            case Direction2D.Left:
                transform.rotation = to.ToRotation();
                break;
            default:
                // no rotation
                break;
            }
        }

        public static void Move2D(this Transform transform, Direction2D to, float speed) {
            transform.position += speed * to.ToUnitVector3();
        }
    }
}
