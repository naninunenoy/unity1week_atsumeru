using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity1WeekAtsumeru {
    public interface IInputProvider {
        bool GetAttack();
        Direction2D GetMovement();
    }
}
