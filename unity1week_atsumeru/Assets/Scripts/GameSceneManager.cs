using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

namespace Unity1WeekAtsumeru {
    public class GameSceneManager : MonoBehaviour {
        [SerializeField] Actor mainActor = default;

        IList<IMover> movers = default;
        IList<IHeading> headings = default;
        IInputProvider inputProvider = default;

        void Awake() {
            movers = new List<IMover> { mainActor };
            headings = new List<IHeading> { mainActor };
            inputProvider = new KeyDownInputProvider();
        }
        void Start() {
            this.UpdateAsObservable()
                .Subscribe(_ => {
                    foreach(var m in movers) {
                        m.MoveTo(inputProvider.GetMovement());
                    }
                    foreach (var h in headings) {
                        h.SetHeading(inputProvider.GetMovement());
                    }
                })
                .AddTo(this);
        }

        // Update is called once per frame
        void Update() {

        }
    }
}
