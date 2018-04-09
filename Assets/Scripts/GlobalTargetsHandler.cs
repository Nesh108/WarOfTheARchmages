using UnityEngine;

namespace EasyAR
{
    public class GlobalTargetsHandler : MonoBehaviour
    {
        public EasyARBehaviour EasyArBehaviour;
        private void Awake()
        {
            EasyArBehaviour.Initialize();
            foreach (var behaviour in ARBuilder.Instance.ARCameraBehaviours)
            {
                behaviour.TargetFound += OnTargetFound;
                behaviour.TargetLost += OnTargetLost;
            }

            foreach (var behaviour in ARBuilder.Instance.ImageTrackerBehaviours)
            {
                behaviour.TargetLoad += OnTargetLoad;
                behaviour.TargetUnload += OnTargetUnload;
            }
        }

        void OnTargetFound(ARCameraBaseBehaviour arcameraBehaviour, TargetAbstractBehaviour targetBehaviour,
            Target target)
        {
            Debug.Log("<Global Handler> Found: " + target.Name + " - " + target.Id);
        }

        void OnTargetLost(ARCameraBaseBehaviour arcameraBehaviour, TargetAbstractBehaviour targetBehaviour,
            Target target)
        {
            Debug.Log("<Global Handler> Lost: " + target.Name + " - " + target.Id);
        }

        void OnTargetLoad(ImageTrackerBaseBehaviour trackerBehaviour, ImageTargetBaseBehaviour targetBehaviour,
            Target target, bool status)
        {
            Debug.Log("<Global Handler> Load target (" + status + "): " + target.Id + " (" + target.Name + ") " +
                      " -> " + trackerBehaviour);
        }

        void OnTargetUnload(ImageTrackerBaseBehaviour trackerBehaviour, ImageTargetBaseBehaviour targetBehaviour,
            Target target, bool status)
        {
            Debug.Log("<Global Handler> Unload target (" + status + "): " + target.Id + " (" + target.Name + ") " +
                      " -> " + trackerBehaviour);
        }
    }

}