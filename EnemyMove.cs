using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform goal;
    private NavMeshAgent agent;
    void Start()
    {
        // ��������� ���������� ������
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        // ������� ����� ����������
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        agent.destination = goal.position;
    }
}
