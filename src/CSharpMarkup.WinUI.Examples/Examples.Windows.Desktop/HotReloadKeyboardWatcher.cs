#if WINDOWS && DEBUG
using KeyboardHookLite;
using System.Diagnostics;
using System.Windows.Input;

namespace CSharpMarkup.WinUI;

public static class HotReloadKeyboardWatcher
{
    static KeyboardHook hook = null;

    static (Key key, bool down)[] toggle = new[] {
        (Key.LeftCtrl, true),
        (Key.S, true),
        (Key.S, false),
        (Key.S, true),
        (Key.S, false),
        (Key.LeftCtrl, false)
    };

    static int toggleMatchedLength = 0;

    static (Key key, bool down)[] rebuild = new[] {
        (Key.LeftCtrl, true),
        (Key.S, true),
        (Key.S, false),
        (Key.LeftCtrl, false)
    };

    static int rebuildMatchedLength = 0;

    static bool isOn = false;

    public delegate void ParameterlessEventHandler();

    public static event ParameterlessEventHandler CtrlUpAfterS;

    public static void Enable(bool enable)
    {
        if (enable && hook is null && Debugger.IsAttached)
        {
            hook = new();
            hook.KeyboardPressed += KeyboardPressed;
            if (!isOn) ToggleOnOff();
        }
        else if (!enable && hook is not null)
        {
            if (isOn) ToggleOnOff();
            hook.Dispose();
            hook = null;
            toggleMatchedLength = rebuildMatchedLength = 0;
        }
    }

    static void KeyboardPressed(object sender, KeyboardHookEventArgs e)
    {
        var input = (e.InputEvent.Key, e.KeyPressType == KeyboardHook.KeyPressType.KeyDown);

        if (IsMatch(input, toggle, ref toggleMatchedLength)) ToggleOnOff();
        else if (isOn && IsMatch(input, rebuild, ref rebuildMatchedLength)) CtrlUpAfterS?.Invoke();
    }

    static bool IsMatch((Key key, bool down) input, (Key key, bool down)[] sequence, ref int index)
    {
        if (sequence[index] == input)
        {
            if (++index == sequence.Length) { index = 0; return true; }
        }
        else
        {
            index = 0;
        }
        return false;
    }

    static void ToggleOnOff()
    {
        isOn = !isOn;
        Debug.WriteLine($"\U0001F525 Rebuild UI on Hot Reload for WinUI 3 is now {(isOn ? "ON" : "OFF")}; see https://github.com/VincentH-Net/CSharpForMarkup#fast-inner-dev-loop-with-net-hot-reload for how to use");
    }
}
#endif