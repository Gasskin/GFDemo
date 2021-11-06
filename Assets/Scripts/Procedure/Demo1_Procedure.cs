using GameFramework.Fsm;
using GameFramework.Procedure;
using UnityEngine;
using UnityGameFramework.Runtime;

public class Demo1_Procedure : ProcedureBase
{
    protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
    {
        GameEntry.GetComponent<SceneComponent>().LoadScene("Assets/Scenes/Demo1.unity");
    }
}
