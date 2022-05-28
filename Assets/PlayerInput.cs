using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                OnPlayerClick(hit);
            }
        }
    }

    void OnPlayerClick(RaycastHit hit)
    {
        if (hit.collider.CompareTag("ClickPlane"))
        {
            Vector3 MouseWorldPosition = hit.point;
            OnPlayerClickGroundPlane(MouseWorldPosition);
        }
        if (hit.collider.CompareTag("HandJoke"))
        {
            OnPlayerClickHandJoke(hit.collider.GetComponent<HandJokeCollider>());
        }
    }

    void OnPlayerClickGroundPlane(Vector3 MouseWorldPosition)
    {
        PlayerSelector selector = GetComponent<PlayerSelector>();
        if (selector.IsSelected())
        {
            selector.GetCurrent().GetComponent<MoveToStatus>().TargetPosition = MouseWorldPosition;
            selector.GetCurrent().ToNewStatus(CharacterStatusEnum.MoveTo);
            selector.ClearSelected();
            OnCommanded();
        }
    }

    void OnPlayerClickHandJoke(HandJokeCollider SelectedHandJoke)
    {
        PlayerSelector selector = GetComponent<PlayerSelector>();
        if (selector.IsSelected())
        {
            if (selector.GetCurrent() == SelectedHandJoke.getMain())
            {
                selector.GetCurrent().ToNewStatus(CharacterStatusEnum.Fallback);
                OnCommanded();
                return;
            }
            selector.ClearSelected();
        }
        GetComponent<PlayerSelector>().OnSelectedHandJoke(SelectedHandJoke.getMain());
    }

    void OnCommanded()
    {
        if (StatusControll.instance.IsStatusEqual(new ReadyStatus()))
        {
            StatusControll.ToNewStatus(new GameStatus());
        }
    }

}
