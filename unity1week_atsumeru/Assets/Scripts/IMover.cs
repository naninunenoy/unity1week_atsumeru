using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity1WeekAtsumeru {
    public interface IMover {
        float Speed { set; get; }
        void MoveTo(Direction2D direction);
    }
}
