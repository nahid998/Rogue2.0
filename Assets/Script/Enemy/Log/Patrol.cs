using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : Log
{
    //public Transform[] path;
    //public int currentPoint;
    //public Transform currentGoal;
    //public float roundingDistance;

    //// Update is called once per frame
    //void //Update()
    //{
        
    //}

    //public override  void CheckDistance()
    //{
    //    if (Vector2.Distance(target.position, transform.position) <= chaseRadius && Vector3.Distance(target.position, transform.position) > attackRadius)
    //    {
    //        if (currentState == EnemyState.idle || currentState == EnemyState.walk && currentState != EnemyState.stagger)
    //        {
    //            Vector3 temp = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
    //            changeAnim(temp - transform.position);
    //            myRB.MovePosition(temp);
    //            //ChangeState(EnemyState.walk); 
    //            anim.SetBool("wakeUp", true);
    //        }

    //    }
    //    else if (Vector3.Distance(target.position, transform.position) > chaseRadius)
    //    {
    //        if (Vector3.Distance(transform.position, path[currentPoint].position)> roundingDistance)
    //        {

    //        }
    //        else
    //        {
    //            changeGoal();
    //        }
    //        Vector3 temp = Vector3.MoveTowards(transform.position, path[currentPoint].position, moveSpeed * Time.deltaTime);
    //        changeAnim(temp - transform.position);
    //        myRB.MovePosition(temp);
    //    }

    //}
    //private void changeGoal()
    //{
    //    if (currentPoint == path.Length - 1)
    //    {
    //        currentPoint = 0;
    //        currentGoal = path[0];
    //    }
    //    else
    //    {
    //        currentPoint++;
    //        currentGoal = path[currentPoint];
    //    }
    //}
}
