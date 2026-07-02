using UnityEngine;

public class Physicsmover : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector3 moveDirection;
    [SerializeField] private Rigidbody objectRigidBody;

    // Update is called once per frame
    private void Update()
    {
        ////direct control (transfor.Translate...)
        //transform.Translate(moveDirection * speed * Time.deltaTime);


        ////Physics-based movement (rigidbody.AddForce)
        //objectRigidBody.AddForce(moveDirection * speed);
        objectRigidBody.AddTorque(moveDirection * speed);

        ////Physics-based Movement (Rigidbody.MovePosition)
        //objectRigidBody.MovePosition(objectRigidBody.position + moveDirection * speed * Time.fixedDeltaTime);

    }
}
