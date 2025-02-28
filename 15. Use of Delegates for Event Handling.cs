using System;

delegate void ButtonClickHandler();

class Button
{
    public event ButtonClickHandler? OnClick;

    public void Click()
    {
        if (OnClick != null)
        {
            OnClick();
        }
    }
}