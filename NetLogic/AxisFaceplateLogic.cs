using FTOptix.Core;
using FTOptix.NetLogic;
using UAManagedCore;

public class AxisFaceplateLogic : BaseNetLogic
{
    private IUAVariable GetVar(string relativePath)
    {
        var alias = Owner.GetVariable("AxisAlias");
        if (alias == null) return null;
        var axisId = (NodeId)alias.Value;
        if (axisId == null || axisId.IsEmpty) return null;
        var axisNode = Owner.Context.GetNode(axisId);
        return axisNode?.GetVariable(relativePath);
    }

    [ExportMethod]
    public void ServoOn()
    {
        var v = GetVar("Cmd/Servo_ON");
        if (v != null) v.Value = true;
    }

    [ExportMethod]
    public void ServoOff()
    {
        var v = GetVar("Cmd/Servo_ON");
        if (v != null) v.Value = false;
    }

    [ExportMethod]
    public void StopAll()
    {
        var jogFw = GetVar("Cmd/Jog_Fw");
        var jogBw = GetVar("Cmd/Jog_Bw");
        var stopAll = GetVar("Cmd/Stop_All");
        if (jogFw != null) jogFw.Value = false;
        if (jogBw != null) jogBw.Value = false;
        if (stopAll != null) stopAll.Value = true;
    }

    [ExportMethod]
    public void DoHome()
    {
        var v = GetVar("Cmd/Do_Home");
        if (v != null) v.Value = true;
    }

    [ExportMethod]
    public void FaultReset()
    {
        var v = GetVar("Cmd/Fault_Rst");
        if (v != null) v.Value = true;
    }

    [ExportMethod]
    public void JogForward()
    {
        var bw = GetVar("Cmd/Jog_Bw");
        var fw = GetVar("Cmd/Jog_Fw");
        if (bw != null) bw.Value = false;
        if (fw != null) fw.Value = true;
    }

    [ExportMethod]
    public void JogForwardStop()
    {
        var v = GetVar("Cmd/Jog_Fw");
        if (v != null) v.Value = false;
    }

    [ExportMethod]
    public void JogBackward()
    {
        var fw = GetVar("Cmd/Jog_Fw");
        var bw = GetVar("Cmd/Jog_Bw");
        if (fw != null) fw.Value = false;
        if (bw != null) bw.Value = true;
    }

    [ExportMethod]
    public void JogBackwardStop()
    {
        var v = GetVar("Cmd/Jog_Bw");
        if (v != null) v.Value = false;
    }

    [ExportMethod]
    public void GoPosition()
    {
        var v = GetVar("Cmd/Go_Pos");
        if (v != null) v.Value = true;
    }
}
