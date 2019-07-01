using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity1WeekAtsumeru {
    public class Actor : MonoBehaviour, IMover, IHeading {
        public float Speed { set; get; } = 0.1F;

        void Start() {

        }

        void Update() {

        }

        void IMover.MoveTo(Direction2D direction) { transform.Move2D(direction, Speed); }
        void IHeading.SetHeading(Direction2D direction) { transform.Rotate2D(direction); }
    }
}
