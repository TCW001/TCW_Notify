# TCW_Notify

<b>Hello Devs</b>, this repository aims to <b>help other Devs</b> who want to <b>speed up their Project Development!</b>
Can only be used in <b>Unity 3D</b>.

<b>TCW Notify</b> is a notification with 4 types (Information, Success, Warning and Error). You can use this notification to let the client side know that you don't have X enough coins, bought item X, which is coming out
the limits of the map or even errors that may occur!

![notify](https://user-images.githubusercontent.com/100330702/205417410-b69bfb50-b50b-4ab6-b1af-a65d8a6f2345.png)

---

<b>Tutorial | Configuration in Unity 3D</b>

> After importing the repository, you can explore the Demo (Scene).

<b>1st Step</b> |
With Unity open, in the Hierarchy create a <b>Canvas</b>.

![Create_Canvas](https://user-images.githubusercontent.com/100330702/205410569-fe3e9437-b2c9-4f2d-9d63-c3401e9657b3.png)

---

<b>2nd Stage</b> |
After creating the <b>Canvas</b>, go to <b>TCW_Notify\Prefabs</b> and drag the Prefab <b>Notify_Content</b> into <b>Canvas</b>.

Position it to your liking!

![Prefab_Notify_Content](https://user-images.githubusercontent.com/100330702/205410956-d4eb79e3-0cd1-4f77-8e8f-726fdc285445.png)

---

<b> 3rd Step</b> |
Is ready! Now you can create a script and call the <b>Notify() Function</b>.

The function has 4 parameters.

![function](https://user-images.githubusercontent.com/100330702/205413377-5fa0f463-ec10-4efb-8e00-6ce118633a40.png)

The example can be followed if the script where the function is called is attached to the <b>Canvas</b>.
You can call the function like the code example below:

![example](https://user-images.githubusercontent.com/100330702/205413533-276e5beb-8ba6-4591-8d54-3a0f11165ed7.png)

> You can edit the source code (NotifyManager.cs)
