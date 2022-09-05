# ScriptableObjectHelper

*Adds some basic scriptable objects and helpers for it that I end up using a lot*
  
___
## Requirements

Unity 2020.2.4f1 or later versions.

This library depends on:  
- You must have **GIT** installed in order to be able to download the package automatically. You can follow these instructions to install git: https://git-scm.com/book/en/v2/Getting-Started-Installing-Git
___
## How to Install with GitUrl
1. Open the **Package Manager Window**  
2. On the top left **+** sign, select Add Package from git URL...
3. Paste **https://github.com/tateexon/ScriptableObjectHelper.git** in the text field

## How to use
1. In the Editor Project tab right click and go to Create->Game Events->(Select the event you want from the list)
2. Name the new scriptable object what you want, for example if you selected a Bool Event and name it "SwitchFlippedSO"
3. To raise the event you can do something like this
    
```c#
[SerializeField] BoolEvent _switchFlippedEvent;
private bool switchFlipped;

// and then to raise the event
public void SwitchFlipped() {
    switchFlipped = !switchFlipped;
    switchFlippedEvent.Raise(switchFlipped);
}
```
4. Add your script as a component to the object you want to trigger the event and drag and drop the SwitchFlippedSO scriptable object into the component.
5. Then on the object or prefab you want to listen to the event add the Listener for the type of game event you created. For our example we would add the BoolListener.
6. Drag and drop your SwitchFlippedSO onto the components Game Event and then select what you want the unity event to do by adding it to the list and setting the component and function you want called. You will need a function in the script that accepts a bool. For example if the prefab is a door and you have a script that is listening for the switch to be flipped to open/close it you would have a function in the script like this to listen to the bool event:
```c#
// do something when the switch is flipped or pressed
public void SwitchFlipped(bool switchFlipped) {
    if (switchFlipped) {
        // lift door
    } else {
        // close door
    }
}
```
7. You are now all hooked up for the scriptable object based event to trigger when the switch is flipped.