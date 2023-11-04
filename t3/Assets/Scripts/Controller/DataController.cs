using Model.Waypoints;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Controller
{
    public class DataController : MonoBehaviour
    {
        [SerializeField] private List<GameObject> _patientPrefabs = new List<GameObject>();

        private void Start()
        {
            InitializeWaypointsReception();
            InitializeWaypointsWaitingRoom();
        }

        public List<GameObject> GetPatientPrefabs()
        {
            return _patientPrefabs;
        }

        private void InitializeWaypointsReception()
        {
            GameObject waypointsParent = GameObject.Find("WaypointsReception");
            if (waypointsParent != null)
            {
                foreach (Transform waypoint in waypointsParent.transform)
                {
                    WaypointReceptionModel.GetInstance().AddWaypoint(waypoint);
                    Debug.Log("Waypoint charg�");
                }
            }
            else
            {
                Debug.LogError("WaypointsWaitingRoom GameObject not found in the scene.");
            }
        }

        private void InitializeWaypointsWaitingRoom()
        {
            GameObject waypointsParent = GameObject.Find("WaypointsWaitingRoom");
            if (waypointsParent != null)
            {
                foreach (Transform waypoint in waypointsParent.transform)
                {
                    WaypointWaitingRoomModel.GetInstance().AddWaypoint(waypoint);
                }
            }
            else
            {
                Debug.LogError("WaypointsWaitingRoom GameObject not found in the scene.");
            }
        }
    }
}

