using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UpdatedWireScript : MonoBehaviour
{
    private LineRenderer line;
    [SerializeField] private string destinationTag;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {

        line = GetComponent<LineRenderer>();
        line.enabled = false;
    }

    private void OnMouseDown()
    {
        offset = transform.position - MouseWorldPosition();
        line.enabled = true;
    }

    private void OnMouseDrag()
    {
        line.SetPosition(0, MouseWorldPosition()); //+offset usually
        line.SetPosition(1, transform.position);
    }

    private void OnMouseUp(){
        Vector3 rayOrigin = Camera.main.transform.position;
        Vector3 rayDir = MouseWorldPosition() - Camera.main.transform.position;
        RaycastHit hit;
        if(Physics.Raycast(rayOrigin, rayDir, out hit)){
            if(hit.transform.tag == destinationTag && hit.transform.position != transform.position){
                Debug.Log("hit");
                line.SetPosition(0, hit.transform.position);
                transform.gameObject.GetComponent<Collider>().enabled = false;
                hit.transform.gameObject.GetComponent<Collider>().enabled = false;
            }
            else{
                line.SetPosition(0, transform.position);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 MouseWorldPosition(){
        Vector3 mouseScreenPos = Input.mousePosition;
        mouseScreenPos.z = Camera.main.ScreenToWorldPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(mouseScreenPos);
    }
}
